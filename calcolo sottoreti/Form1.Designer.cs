﻿namespace calcolo_sottoreti
{
    partial class Form1
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
            this.Calcola = new System.Windows.Forms.Button();
            this.Sottoreti = new System.Windows.Forms.TextBox();
            this.Host = new System.Windows.Forms.TextBox();
            this.Indirizzoprivato = new System.Windows.Forms.TextBox();
            this.Class = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Calcola
            // 
            this.Calcola.Location = new System.Drawing.Point(160, 43);
            this.Calcola.Name = "Calcola";
            this.Calcola.Size = new System.Drawing.Size(86, 66);
            this.Calcola.TabIndex = 0;
            this.Calcola.Text = "Calcola";
            this.Calcola.UseVisualStyleBackColor = true;
            this.Calcola.Click += new System.EventHandler(this.Calcola_Click);
            // 
            // Sottoreti
            // 
            this.Sottoreti.Location = new System.Drawing.Point(12, 43);
            this.Sottoreti.Name = "Sottoreti";
            this.Sottoreti.Size = new System.Drawing.Size(142, 20);
            this.Sottoreti.TabIndex = 1;
            // 
            // Host
            // 
            this.Host.Location = new System.Drawing.Point(12, 89);
            this.Host.Name = "Host";
            this.Host.Size = new System.Drawing.Size(142, 20);
            this.Host.TabIndex = 2;
            // 
            // Indirizzoprivato
            // 
            this.Indirizzoprivato.Location = new System.Drawing.Point(363, 89);
            this.Indirizzoprivato.Name = "Indirizzoprivato";
            this.Indirizzoprivato.Size = new System.Drawing.Size(142, 20);
            this.Indirizzoprivato.TabIndex = 3;
            // 
            // Class
            // 
            this.Class.Location = new System.Drawing.Point(363, 43);
            this.Class.Name = "Class";
            this.Class.Size = new System.Drawing.Size(142, 20);
            this.Class.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "sottorete";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "host";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(360, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "classe";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(360, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "indirizzo di rete (privato)";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Class);
            this.Controls.Add(this.Indirizzoprivato);
            this.Controls.Add(this.Host);
            this.Controls.Add(this.Sottoreti);
            this.Controls.Add(this.Calcola);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Calcola;
        private System.Windows.Forms.TextBox Sottoreti;
        private System.Windows.Forms.TextBox Host;
        private System.Windows.Forms.TextBox Indirizzoprivato;
        private System.Windows.Forms.TextBox Class;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}

