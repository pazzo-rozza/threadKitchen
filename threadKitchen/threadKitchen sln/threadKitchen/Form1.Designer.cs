namespace ThreadKitchen
{
    partial class ThreadKitchen
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.titolo = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lblPerc4 = new System.Windows.Forms.Label();
            this.lblPerc3 = new System.Windows.Forms.Label();
            this.lblPerc2 = new System.Windows.Forms.Label();
            this.lblPerc1 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.grb1 = new System.Windows.Forms.GroupBox();
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.progressBar3 = new System.Windows.Forms.ProgressBar();
            this.progressBar4 = new System.Windows.Forms.ProgressBar();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.grbConsole = new System.Windows.Forms.GroupBox();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.btnAvvia = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grb1.SuspendLayout();
            this.grbConsole.SuspendLayout();
            this.SuspendLayout();
            // 
            // titolo
            // 
            this.titolo.AutoSize = true;
            this.titolo.Dock = System.Windows.Forms.DockStyle.Top;
            this.titolo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titolo.ForeColor = System.Drawing.Color.Orange;
            this.titolo.Location = new System.Drawing.Point(0, 0);
            this.titolo.Name = "titolo";
            this.titolo.Size = new System.Drawing.Size(601, 38);
            this.titolo.TabIndex = 0;
            this.titolo.Text = "🍳 ThreadKitchen — La cucina dei thread";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(15, 33);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(17, 25);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = ".";
            // 
            // lblPerc4
            // 
            this.lblPerc4.AutoSize = true;
            this.lblPerc4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerc4.ForeColor = System.Drawing.Color.Lime;
            this.lblPerc4.Location = new System.Drawing.Point(605, 150);
            this.lblPerc4.Name = "lblPerc4";
            this.lblPerc4.Size = new System.Drawing.Size(29, 18);
            this.lblPerc4.TabIndex = 2;
            this.lblPerc4.Text = "0%";
            // 
            // lblPerc3
            // 
            this.lblPerc3.AutoSize = true;
            this.lblPerc3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerc3.ForeColor = System.Drawing.Color.Lime;
            this.lblPerc3.Location = new System.Drawing.Point(605, 114);
            this.lblPerc3.Name = "lblPerc3";
            this.lblPerc3.Size = new System.Drawing.Size(29, 18);
            this.lblPerc3.TabIndex = 3;
            this.lblPerc3.Text = "0%";
            // 
            // lblPerc2
            // 
            this.lblPerc2.AutoSize = true;
            this.lblPerc2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerc2.ForeColor = System.Drawing.Color.Lime;
            this.lblPerc2.Location = new System.Drawing.Point(605, 75);
            this.lblPerc2.Name = "lblPerc2";
            this.lblPerc2.Size = new System.Drawing.Size(29, 18);
            this.lblPerc2.TabIndex = 4;
            this.lblPerc2.Text = "0%";
            // 
            // lblPerc1
            // 
            this.lblPerc1.AutoSize = true;
            this.lblPerc1.Cursor = System.Windows.Forms.Cursors.Default;
            this.lblPerc1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPerc1.ForeColor = System.Drawing.Color.Lime;
            this.lblPerc1.Location = new System.Drawing.Point(605, 40);
            this.lblPerc1.Name = "lblPerc1";
            this.lblPerc1.Size = new System.Drawing.Size(29, 18);
            this.lblPerc1.TabIndex = 5;
            this.lblPerc1.Text = "0%";
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl4.Location = new System.Drawing.Point(15, 143);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(17, 25);
            this.lbl4.TabIndex = 6;
            this.lbl4.Text = ".";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl3.Location = new System.Drawing.Point(15, 107);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(17, 25);
            this.lbl3.TabIndex = 7;
            this.lbl3.Text = ".";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(15, 70);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(17, 25);
            this.lbl2.TabIndex = 8;
            this.lbl2.Text = ".";
            // 
            // grb1
            // 
            this.grb1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.grb1.Controls.Add(this.progressBar2);
            this.grb1.Controls.Add(this.progressBar3);
            this.grb1.Controls.Add(this.progressBar4);
            this.grb1.Controls.Add(this.lbl1);
            this.grb1.Controls.Add(this.lblPerc4);
            this.grb1.Controls.Add(this.lblPerc3);
            this.grb1.Controls.Add(this.progressBar1);
            this.grb1.Controls.Add(this.lblPerc2);
            this.grb1.Controls.Add(this.lblPerc1);
            this.grb1.Controls.Add(this.lbl4);
            this.grb1.Controls.Add(this.lbl3);
            this.grb1.Controls.Add(this.lbl2);
            this.grb1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grb1.Location = new System.Drawing.Point(12, 42);
            this.grb1.Name = "grb1";
            this.grb1.Size = new System.Drawing.Size(712, 188);
            this.grb1.TabIndex = 9;
            this.grb1.TabStop = false;
            this.grb1.Text = "👨🍳 Cuochi al lavoro";
            // 
            // progressBar2
            // 
            this.progressBar2.Location = new System.Drawing.Point(113, 145);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(489, 23);
            this.progressBar2.TabIndex = 11;
            // 
            // progressBar3
            // 
            this.progressBar3.Location = new System.Drawing.Point(113, 109);
            this.progressBar3.Name = "progressBar3";
            this.progressBar3.Size = new System.Drawing.Size(489, 23);
            this.progressBar3.TabIndex = 12;
            // 
            // progressBar4
            // 
            this.progressBar4.Location = new System.Drawing.Point(113, 75);
            this.progressBar4.Name = "progressBar4";
            this.progressBar4.Size = new System.Drawing.Size(489, 23);
            this.progressBar4.TabIndex = 13;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(113, 42);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(489, 23);
            this.progressBar1.TabIndex = 10;
            // 
            // grbConsole
            // 
            this.grbConsole.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.grbConsole.Controls.Add(this.rtbLog);
            this.grbConsole.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.grbConsole.Location = new System.Drawing.Point(13, 237);
            this.grbConsole.Name = "grbConsole";
            this.grbConsole.Size = new System.Drawing.Size(711, 334);
            this.grbConsole.TabIndex = 10;
            this.grbConsole.TabStop = false;
            this.grbConsole.Text = "📜 Log attività";
            // 
            // rtbLog
            // 
            this.rtbLog.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.rtbLog.Location = new System.Drawing.Point(6, 21);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.Size = new System.Drawing.Size(699, 307);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // btnAvvia
            // 
            this.btnAvvia.BackColor = System.Drawing.Color.Lime;
            this.btnAvvia.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAvvia.Location = new System.Drawing.Point(19, 598);
            this.btnAvvia.Name = "btnAvvia";
            this.btnAvvia.Size = new System.Drawing.Size(227, 70);
            this.btnAvvia.TabIndex = 11;
            this.btnAvvia.Text = "▶  Avvia cucina";
            this.btnAvvia.UseVisualStyleBackColor = false;
            this.btnAvvia.Click += new System.EventHandler(this.btnAvvia_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Red;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.Location = new System.Drawing.Point(252, 598);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(138, 70);
            this.btnReset.TabIndex = 12;
            this.btnReset.Text = "↺  Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // ThreadKitchen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(736, 818);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnAvvia);
            this.Controls.Add(this.grbConsole);
            this.Controls.Add(this.grb1);
            this.Controls.Add(this.titolo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "ThreadKitchen";
            this.Text = "🍳 ThreadKitchen";
            this.Load += new System.EventHandler(this.ThreadKitchen_Load);
            this.grb1.ResumeLayout(false);
            this.grb1.PerformLayout();
            this.grbConsole.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titolo;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lblPerc4;
        private System.Windows.Forms.Label lblPerc3;
        private System.Windows.Forms.Label lblPerc2;
        private System.Windows.Forms.Label lblPerc1;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.GroupBox grb1;
        private System.Windows.Forms.ProgressBar progressBar4;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.ProgressBar progressBar3;
        private System.Windows.Forms.GroupBox grbConsole;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.Button btnAvvia;
        private System.Windows.Forms.Button btnReset;
    }
}