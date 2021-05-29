
namespace Interfata
{
    partial class Bon_de_ordin
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
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.button_genereaza = new System.Windows.Forms.Button();
            this.dateTimePicker3 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker4 = new System.Windows.Forms.DateTimePicker();
            this.textBox_nrcomanda = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button_genereaza_comanda = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Data Start";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = " hh:mm:ss";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(281, 95);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = " hh:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(281, 196);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(133, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Data Stop";
            // 
            // button_genereaza
            // 
            this.button_genereaza.BackColor = System.Drawing.Color.SandyBrown;
            this.button_genereaza.Location = new System.Drawing.Point(63, 309);
            this.button_genereaza.Name = "button_genereaza";
            this.button_genereaza.Size = new System.Drawing.Size(142, 50);
            this.button_genereaza.TabIndex = 5;
            this.button_genereaza.Text = "Genereaza bon de ordine";
            this.button_genereaza.UseVisualStyleBackColor = false;
            this.button_genereaza.Click += new System.EventHandler(this.button_genereaza_Click);
            // 
            // dateTimePicker3
            // 
            this.dateTimePicker3.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker3.Location = new System.Drawing.Point(56, 95);
            this.dateTimePicker3.Name = "dateTimePicker3";
            this.dateTimePicker3.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker3.TabIndex = 6;
            this.dateTimePicker3.ValueChanged += new System.EventHandler(this.dateTimePicker3_ValueChanged);
            // 
            // dateTimePicker4
            // 
            this.dateTimePicker4.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker4.Location = new System.Drawing.Point(56, 196);
            this.dateTimePicker4.Name = "dateTimePicker4";
            this.dateTimePicker4.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker4.TabIndex = 7;
            // 
            // textBox_nrcomanda
            // 
            this.textBox_nrcomanda.Location = new System.Drawing.Point(281, 250);
            this.textBox_nrcomanda.Name = "textBox_nrcomanda";
            this.textBox_nrcomanda.Size = new System.Drawing.Size(100, 22);
            this.textBox_nrcomanda.TabIndex = 2;
            this.textBox_nrcomanda.TextChanged += new System.EventHandler(this.textBox_nrcomanda_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(133, 250);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "Numar comanda:";
            // 
            // button_genereaza_comanda
            // 
            this.button_genereaza_comanda.BackColor = System.Drawing.Color.SandyBrown;
            this.button_genereaza_comanda.Location = new System.Drawing.Point(270, 309);
            this.button_genereaza_comanda.Name = "button_genereaza_comanda";
            this.button_genereaza_comanda.Size = new System.Drawing.Size(142, 50);
            this.button_genereaza_comanda.TabIndex = 9;
            this.button_genereaza_comanda.Text = "Genereaza comanda";
            this.button_genereaza_comanda.UseVisualStyleBackColor = false;
            this.button_genereaza_comanda.Click += new System.EventHandler(this.button_genereaza_comanda_Click);
            // 
            // Bon_de_ordin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(518, 388);
            this.Controls.Add(this.button_genereaza_comanda);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox_nrcomanda);
            this.Controls.Add(this.dateTimePicker4);
            this.Controls.Add(this.dateTimePicker3);
            this.Controls.Add(this.button_genereaza);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Name = "Bon_de_ordin";
            this.Text = "Bon_de_ordin";
            this.Load += new System.EventHandler(this.Bon_de_ordin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_genereaza;
        private System.Windows.Forms.DateTimePicker dateTimePicker3;
        private System.Windows.Forms.DateTimePicker dateTimePicker4;
        private System.Windows.Forms.TextBox textBox_nrcomanda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_genereaza_comanda;
    }
}