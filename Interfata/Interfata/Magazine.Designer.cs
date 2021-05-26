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
            this.label1 = new System.Windows.Forms.Label();
            this.veziMeniuButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.magazineComboBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Open Sans ExtraBold", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(21, 121);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(575, 51);
            this.signUpLabel.TabIndex = 19;
            this.signUpLabel.Text = "De unde vrei sa mananci azi?";
            this.signUpLabel.Click += new System.EventHandler(this.signUpLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(140, 186);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(336, 22);
            this.label1.TabIndex = 20;
            this.label1.Text = "**Alege un singur restaurant/supermarket";
            // 
            // veziMeniuButton
            // 
            this.veziMeniuButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veziMeniuButton.Location = new System.Drawing.Point(199, 494);
            this.veziMeniuButton.Name = "veziMeniuButton";
            this.veziMeniuButton.Size = new System.Drawing.Size(192, 39);
            this.veziMeniuButton.TabIndex = 22;
            this.veziMeniuButton.Text = "Vezi Meniu";
            this.veziMeniuButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(-2, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(627, 831);
            this.pictureBox1.TabIndex = 23;
            this.pictureBox1.TabStop = false;
            // 
            // magazineComboBox
            // 
            this.magazineComboBox.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magazineComboBox.FormattingEnabled = true;
            this.magazineComboBox.Items.AddRange(new object[] {
            "Splend\'eat",
            "Noodle Pack",
            "La Cuib",
            "Oxford",
            "Cartuf",
            "Mamma Mia",
            "Delicio"});
            this.magazineComboBox.Location = new System.Drawing.Point(144, 349);
            this.magazineComboBox.Name = "magazineComboBox";
            this.magazineComboBox.Size = new System.Drawing.Size(318, 34);
            this.magazineComboBox.TabIndex = 24;
            this.magazineComboBox.Text = "Alege un magazin...";
            this.magazineComboBox.SelectedIndexChanged += new System.EventHandler(this.magazineComboBox_SelectedIndexChanged);
            // 
            // Magazine
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 829);
            this.Controls.Add(this.magazineComboBox);
            this.Controls.Add(this.veziMeniuButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Magazine";
            this.Text = "Magazine";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button veziMeniuButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox magazineComboBox;
    }
}