using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ThreadKitchen
{
    public partial class ThreadKitchen : Form
    {
        public ThreadKitchen()
        {
            InitializeComponent();
        }
        private List<Chef> _chefs;

        private void ThreadKitchen_Load(object sender, EventArgs e)
        {
            _chefs = Chef.GetDefaultChefs();
            rtbLog.ForeColor = Color.Lime;
            rtbLog.AppendText("🍳 Cucina pronta. Premi «Avvia cucina» per iniziare." + Environment.NewLine);
        }

        private void btnAvvia_Click(object sender, EventArgs e)
        {
            // Disabilita il tasto per evitare che l'utente clicchi due volte
            btnAvvia.Enabled = false;
            btnReset.Enabled = true;

            // Creiamo il thread. La lambda () => serve a passare il parametro 0
            Thread t = new Thread(() => CookDish(0));

            // Background: se chiudi la finestra, il thread muore (importante!)
            t.IsBackground = true;
            // Avviamo il thread. Il programma NON si blocca qui, continua subito.
            t.Start();

            rtbLog.AppendText("▶ Mario (Thread secondario) ha iniziato a cucinare..." + Environment.NewLine);
        }
        private void btnReset_Click(object sender, EventArgs e)
        {
            // Azzera i dati nel modello
            _chefs[0].Progress = 0;
            _chefs[0].IsFinished = false;
            _chefs[0].ElapsedSeconds = 0;

            // Azzera la grafica (Qui NON crasha perché siamo nel Main Thread)
            progressBar1.Value = 0;
            lblPerc1.Text = "0%";

            // Ripristina i bottoni
            btnReset.Enabled = false;
            btnAvvia.Enabled = true;

            rtbLog.AppendText("↺ Reset eseguito. Cucina pulita." + Environment.NewLine);
        }
        // Prima di tutto, aggiungi questa variabile all'inizio della classe per i numeri casuali
        private Random _random = new Random();
        private void CookDish(int chefId)
        {
            // Misuriamo il tempo reale trascorso
            Stopwatch sw = Stopwatch.StartNew();

            // Ciclo finché il piatto non è pronto (Progress < 100)
            while (_chefs[chefId].Progress < 100)
            {
                // Simula il tempo di un passo di cottura (tra 100 e 500ms)
                Thread.Sleep(_random.Next(100, 500));

                // Avanza di un passo casuale tra 1 e 8
                int step = _random.Next(1, 9);
                _chefs[chefId].Progress = Math.Min(100, _chefs[chefId].Progress + step);

                // --- ATTENZIONE: IL CRASH AVVERRÀ QUI ---
                // Stiamo toccando i controlli UI da un thread secondario.
                this.Invoke(new Action(() => {
                    progressBar1.Value = _chefs[chefId].Progress;
                    lblPerc1.Text = _chefs[chefId].Progress + "%";
                }));
            }
            sw.Stop();
            _chefs[chefId].ElapsedSeconds = sw.Elapsed.TotalSeconds;
            _chefs[chefId].IsFinished = true;
        }

    }
}