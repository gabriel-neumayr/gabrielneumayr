namespace _13._2
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.start = new System.Windows.Forms.Button();
            this.sprachauswahl = new System.Windows.Forms.DomainUpDown();
            this.Frage = new System.Windows.Forms.TextBox();
            this.Antwort = new System.Windows.Forms.TextBox();
            this.lablefrage = new System.Windows.Forms.Label();
            this.lableAntwort = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // start
            // 
            this.start.ForeColor = System.Drawing.SystemColors.ControlText;
            this.start.Location = new System.Drawing.Point(98, 268);
            this.start.Name = "start";
            this.start.Size = new System.Drawing.Size(128, 93);
            this.start.TabIndex = 0;
            this.start.Text = "Start";
            this.start.UseVisualStyleBackColor = true;
            // 
            // sprachauswahl
            // 
            this.sprachauswahl.Location = new System.Drawing.Point(106, 83);
            this.sprachauswahl.Name = "sprachauswahl";
            this.sprachauswahl.Size = new System.Drawing.Size(120, 22);
            this.sprachauswahl.TabIndex = 1;
            this.sprachauswahl.Text = "Deutsch- Englisch ";
            // 
            // Frage
            // 
            this.Frage.Location = new System.Drawing.Point(581, 113);
            this.Frage.Name = "Frage";
            this.Frage.Size = new System.Drawing.Size(100, 22);
            this.Frage.TabIndex = 2;
            this.Frage.Tag = "";
            // 
            // Antwort
            // 
            this.Antwort.Location = new System.Drawing.Point(581, 239);
            this.Antwort.Name = "Antwort";
            this.Antwort.Size = new System.Drawing.Size(100, 22);
            this.Antwort.TabIndex = 3;
            this.Antwort.Tag = "";
            // 
            // lablefrage
            // 
            this.lablefrage.AutoSize = true;
            this.lablefrage.Location = new System.Drawing.Point(581, 83);
            this.lablefrage.Name = "lablefrage";
            this.lablefrage.Size = new System.Drawing.Size(43, 16);
            this.lablefrage.TabIndex = 4;
            this.lablefrage.Text = "Frage";
            // 
            // lableAntwort
            // 
            this.lableAntwort.AutoSize = true;
            this.lableAntwort.Location = new System.Drawing.Point(581, 206);
            this.lableAntwort.Name = "lableAntwort";
            this.lableAntwort.Size = new System.Drawing.Size(50, 16);
            this.lableAntwort.TabIndex = 5;
            this.lableAntwort.Text = "Antwort";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(25, 403);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(752, 23);
            this.progressBar1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.lableAntwort);
            this.Controls.Add(this.lablefrage);
            this.Controls.Add(this.Antwort);
            this.Controls.Add(this.Frage);
            this.Controls.Add(this.sprachauswahl);
            this.Controls.Add(this.start);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button start;
        private System.Windows.Forms.DomainUpDown sprachauswahl;
        private System.Windows.Forms.TextBox Frage;
        private System.Windows.Forms.TextBox Antwort;
        private System.Windows.Forms.Label lablefrage;
        private System.Windows.Forms.Label lableAntwort;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}

