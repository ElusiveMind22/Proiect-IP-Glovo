
namespace ProiectIP
{
    partial class Inregistreaza
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.checkBox_afiseaza_parola = new System.Windows.Forms.CheckBox();
            this.label_creare_cont = new System.Windows.Forms.Label();
            this.label_nu_aveti_cont = new System.Windows.Forms.Label();
            this.button_Stergere = new System.Windows.Forms.Button();
            this.button_iesire = new System.Windows.Forms.Button();
            this.button_autentificare = new System.Windows.Forms.Button();
            this.textBox_utilizator = new System.Windows.Forms.TextBox();
            this.textBox_parola = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox_confirma_parola = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox_afiseaza_parola
            // 
            this.checkBox_afiseaza_parola.AutoSize = true;
            this.checkBox_afiseaza_parola.Font = new System.Drawing.Font("Nirmala UI", 7.75F, System.Drawing.FontStyle.Bold);
            this.checkBox_afiseaza_parola.Location = new System.Drawing.Point(439, 262);
            this.checkBox_afiseaza_parola.Name = "checkBox_afiseaza_parola";
            this.checkBox_afiseaza_parola.Size = new System.Drawing.Size(117, 21);
            this.checkBox_afiseaza_parola.TabIndex = 20;
            this.checkBox_afiseaza_parola.Text = "Afiseza parola";
            this.checkBox_afiseaza_parola.UseVisualStyleBackColor = true;
            this.checkBox_afiseaza_parola.CheckedChanged += new System.EventHandler(this.checkBox_afiseaza_parola_CheckedChanged);
            // 
            // label_creare_cont
            // 
            this.label_creare_cont.AutoSize = true;
            this.label_creare_cont.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_creare_cont.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.label_creare_cont.Location = new System.Drawing.Point(294, 408);
            this.label_creare_cont.Name = "label_creare_cont";
            this.label_creare_cont.Size = new System.Drawing.Size(186, 23);
            this.label_creare_cont.TabIndex = 19;
            this.label_creare_cont.Text = "Inapoi la autentificare";
            this.label_creare_cont.Click += new System.EventHandler(this.label_creare_cont_Click);
            // 
            // label_nu_aveti_cont
            // 
            this.label_nu_aveti_cont.AutoSize = true;
            this.label_nu_aveti_cont.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label_nu_aveti_cont.Location = new System.Drawing.Point(321, 385);
            this.label_nu_aveti_cont.Name = "label_nu_aveti_cont";
            this.label_nu_aveti_cont.Size = new System.Drawing.Size(117, 23);
            this.label_nu_aveti_cont.TabIndex = 18;
            this.label_nu_aveti_cont.Text = "Aveti un cont";
            // 
            // button_Stergere
            // 
            this.button_Stergere.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_Stergere.Font = new System.Drawing.Font("Nirmala UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.button_Stergere.Location = new System.Drawing.Point(354, 300);
            this.button_Stergere.Name = "button_Stergere";
            this.button_Stergere.Size = new System.Drawing.Size(100, 47);
            this.button_Stergere.TabIndex = 17;
            this.button_Stergere.Text = "Stergere";
            this.button_Stergere.UseVisualStyleBackColor = false;
            this.button_Stergere.Click += new System.EventHandler(this.button_Stergere_Click);
            // 
            // button_iesire
            // 
            this.button_iesire.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_iesire.Font = new System.Drawing.Font("Nirmala UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.button_iesire.Location = new System.Drawing.Point(491, 300);
            this.button_iesire.Name = "button_iesire";
            this.button_iesire.Size = new System.Drawing.Size(100, 47);
            this.button_iesire.TabIndex = 16;
            this.button_iesire.Text = "Iesire";
            this.button_iesire.UseVisualStyleBackColor = false;
            this.button_iesire.Click += new System.EventHandler(this.button_iesire_Click);
            // 
            // button_autentificare
            // 
            this.button_autentificare.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.button_autentificare.Font = new System.Drawing.Font("Nirmala UI", 8.75F, System.Drawing.FontStyle.Bold);
            this.button_autentificare.Location = new System.Drawing.Point(181, 300);
            this.button_autentificare.Name = "button_autentificare";
            this.button_autentificare.Size = new System.Drawing.Size(144, 47);
            this.button_autentificare.TabIndex = 15;
            this.button_autentificare.Text = "Creeaza";
            this.button_autentificare.UseVisualStyleBackColor = false;
            this.button_autentificare.Click += new System.EventHandler(this.button_autentificare_Click);
            // 
            // textBox_utilizator
            // 
            this.textBox_utilizator.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox_utilizator.Location = new System.Drawing.Point(401, 79);
            this.textBox_utilizator.Name = "textBox_utilizator";
            this.textBox_utilizator.Size = new System.Drawing.Size(138, 22);
            this.textBox_utilizator.TabIndex = 14;
            this.textBox_utilizator.TextChanged += new System.EventHandler(this.textBox_utilizator_TextChanged);
            // 
            // textBox_parola
            // 
            this.textBox_parola.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox_parola.Location = new System.Drawing.Point(401, 162);
            this.textBox_parola.Name = "textBox_parola";
            this.textBox_parola.PasswordChar = '*';
            this.textBox_parola.Size = new System.Drawing.Size(138, 22);
            this.textBox_parola.TabIndex = 13;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(219, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 23);
            this.label2.TabIndex = 12;
            this.label2.Text = "Parola:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(219, 77);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 23);
            this.label1.TabIndex = 11;
            this.label1.Text = "Utilizator:";
            // 
            // textBox_confirma_parola
            // 
            this.textBox_confirma_parola.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.textBox_confirma_parola.Location = new System.Drawing.Point(401, 216);
            this.textBox_confirma_parola.Name = "textBox_confirma_parola";
            this.textBox_confirma_parola.PasswordChar = '*';
            this.textBox_confirma_parola.Size = new System.Drawing.Size(138, 22);
            this.textBox_confirma_parola.TabIndex = 22;
            this.textBox_confirma_parola.TextChanged += new System.EventHandler(this.textBox_confirma_parola_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(219, 215);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(146, 23);
            this.label3.TabIndex = 21;
            this.label3.Text = "Confirma parola:";
            // 
            // Inregistreaza
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(800, 481);
            this.Controls.Add(this.textBox_confirma_parola);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.checkBox_afiseaza_parola);
            this.Controls.Add(this.label_creare_cont);
            this.Controls.Add(this.label_nu_aveti_cont);
            this.Controls.Add(this.button_Stergere);
            this.Controls.Add(this.button_iesire);
            this.Controls.Add(this.button_autentificare);
            this.Controls.Add(this.textBox_utilizator);
            this.Controls.Add(this.textBox_parola);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Inregistreaza";
            this.Text = "Inregistreaza";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox_afiseaza_parola;
        private System.Windows.Forms.Label label_creare_cont;
        private System.Windows.Forms.Label label_nu_aveti_cont;
        private System.Windows.Forms.Button button_Stergere;
        private System.Windows.Forms.Button button_iesire;
        private System.Windows.Forms.Button button_autentificare;
        private System.Windows.Forms.TextBox textBox_utilizator;
        private System.Windows.Forms.TextBox textBox_parola;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox_confirma_parola;
        private System.Windows.Forms.Label label3;
    }
}