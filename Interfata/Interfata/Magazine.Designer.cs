namespace Interfata
{
    partial class Magazine
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magazine));
            this.signUpLabel = new System.Windows.Forms.Label();
            this.veziMeniuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.magazineComboBox = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.magazineComboBox2 = new System.Windows.Forms.ComboBox();
            this.FastFoodRadio = new System.Windows.Forms.RadioButton();
            this.RestaurantRadio = new System.Windows.Forms.RadioButton();
            this.SelectLocal = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(256, 118);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(299, 54);
            this.signUpLabel.TabIndex = 19;
            this.signUpLabel.Text = "De unde vrei";
            // 
            // veziMeniuButton
            // 
            this.veziMeniuButton.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.veziMeniuButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veziMeniuButton.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.veziMeniuButton.Location = new System.Drawing.Point(312, 610);
            this.veziMeniuButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.veziMeniuButton.Name = "veziMeniuButton";
            this.veziMeniuButton.Size = new System.Drawing.Size(245, 41);
            this.veziMeniuButton.TabIndex = 22;
            this.veziMeniuButton.Text = "Vezi Meniu";
            this.veziMeniuButton.UseVisualStyleBackColor = false;
            this.veziMeniuButton.Click += new System.EventHandler(this.veziMeniuButton_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.pictureBox1.Location = new System.Drawing.Point(-3, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 831);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // magazineComboBox
            // 
            this.magazineComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazineComboBox.FormattingEnabled = true;
            this.magazineComboBox.Items.AddRange(new object[] {
            "Splend\'eat",
            "Noodle Pack",
            "La Cuib",
            "Oxford",
            "Cartuf",
            "Mamma Mia",
            "Delicio"});
            this.magazineComboBox.Location = new System.Drawing.Point(287, 470);
            this.magazineComboBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magazineComboBox.Name = "magazineComboBox";
            this.magazineComboBox.Size = new System.Drawing.Size(296, 37);
            this.magazineComboBox.TabIndex = 24;
            this.magazineComboBox.Text = "Alege un magazin...";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(312, 766);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(245, 41);
            this.button1.TabIndex = 25;
            this.button1.Text = "Exit";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(312, 689);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 41);
            this.button2.TabIndex = 26;
            this.button2.Text = "Sign Out";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // magazineComboBox2
            // 
            this.magazineComboBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazineComboBox2.FormattingEnabled = true;
            this.magazineComboBox2.Items.AddRange(new object[] {
            "McDonalds",
            "KFC"});
            this.magazineComboBox2.Location = new System.Drawing.Point(287, 470);
            this.magazineComboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.magazineComboBox2.Name = "magazineComboBox2";
            this.magazineComboBox2.Size = new System.Drawing.Size(296, 37);
            this.magazineComboBox2.TabIndex = 27;
            this.magazineComboBox2.Text = "Alege un magazin...";
            // 
            // FastFoodRadio
            // 
            this.FastFoodRadio.AutoSize = true;
            this.FastFoodRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FastFoodRadio.Location = new System.Drawing.Point(491, 330);
            this.FastFoodRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.FastFoodRadio.Name = "FastFoodRadio";
            this.FastFoodRadio.Size = new System.Drawing.Size(145, 33);
            this.FastFoodRadio.TabIndex = 28;
            this.FastFoodRadio.TabStop = true;
            this.FastFoodRadio.Text = "FastFood";
            this.FastFoodRadio.UseVisualStyleBackColor = true;
            // 
            // RestaurantRadio
            // 
            this.RestaurantRadio.AutoSize = true;
            this.RestaurantRadio.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RestaurantRadio.Location = new System.Drawing.Point(192, 330);
            this.RestaurantRadio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.RestaurantRadio.Name = "RestaurantRadio";
            this.RestaurantRadio.Size = new System.Drawing.Size(159, 33);
            this.RestaurantRadio.TabIndex = 29;
            this.RestaurantRadio.TabStop = true;
            this.RestaurantRadio.Text = "Restaurant";
            this.RestaurantRadio.UseVisualStyleBackColor = true;
            // 
            // SelectLocal
            // 
            this.SelectLocal.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.SelectLocal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SelectLocal.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SelectLocal.Location = new System.Drawing.Point(312, 471);
            this.SelectLocal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SelectLocal.Name = "SelectLocal";
            this.SelectLocal.Size = new System.Drawing.Size(245, 41);
            this.SelectLocal.TabIndex = 30;
            this.SelectLocal.Text = "Select";
            this.SelectLocal.UseVisualStyleBackColor = false;
            this.SelectLocal.Click += new System.EventHandler(this.SelectLocal_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(180, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 54);
            this.label1.TabIndex = 31;
            this.label1.Text = "sa mananci astazi?";
            // 
            // Magazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 1020);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.SelectLocal);
            this.Controls.Add(this.RestaurantRadio);
            this.Controls.Add(this.FastFoodRadio);
            this.Controls.Add(this.magazineComboBox2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.magazineComboBox);
            this.Controls.Add(this.veziMeniuButton);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Magazine";
            this.Text = "Magazine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Button veziMeniuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.ComboBox magazineComboBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.ComboBox magazineComboBox2;
        private System.Windows.Forms.RadioButton FastFoodRadio;
        private System.Windows.Forms.RadioButton RestaurantRadio;
        private System.Windows.Forms.Button SelectLocal;
        private System.Windows.Forms.Label label1;
    }
}