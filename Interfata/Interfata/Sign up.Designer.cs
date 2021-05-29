namespace Interfata
{
    partial class Sign_up
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Sign_up));
            this.signUpButton = new System.Windows.Forms.Button();
            this.gdprCheckBox = new System.Windows.Forms.CheckBox();
            this.parolaSignUpTextBox = new System.Windows.Forms.TextBox();
            this.emailSignUpTextBox = new System.Windows.Forms.TextBox();
            this.usernameSignUpTextBox = new System.Windows.Forms.TextBox();
            this.parolaSignUpLabel = new System.Windows.Forms.Label();
            this.emailSignUpLabel = new System.Windows.Forms.Label();
            this.usernameSignUpLabel = new System.Windows.Forms.Label();
            this.newsletterCheckBox = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.signUpLabel = new System.Windows.Forms.Label();
            this.BackButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // signUpButton
            // 
            this.signUpButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpButton.Location = new System.Drawing.Point(243, 605);
            this.signUpButton.Margin = new System.Windows.Forms.Padding(4);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(256, 48);
            this.signUpButton.TabIndex = 15;
            this.signUpButton.Text = "Sign up";
            this.signUpButton.UseVisualStyleBackColor = true;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // gdprCheckBox
            // 
            this.gdprCheckBox.AutoSize = true;
            this.gdprCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gdprCheckBox.Location = new System.Drawing.Point(236, 738);
            this.gdprCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.gdprCheckBox.Name = "gdprCheckBox";
            this.gdprCheckBox.Size = new System.Drawing.Size(263, 29);
            this.gdprCheckBox.TabIndex = 14;
            this.gdprCheckBox.Text = "Sunt de acord cu GDPR";
            this.gdprCheckBox.UseVisualStyleBackColor = true;
            this.gdprCheckBox.CheckedChanged += new System.EventHandler(this.gdprCheckBox_CheckedChanged);
            // 
            // parolaSignUpTextBox
            // 
            this.parolaSignUpTextBox.Location = new System.Drawing.Point(420, 524);
            this.parolaSignUpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parolaSignUpTextBox.Name = "parolaSignUpTextBox";
            this.parolaSignUpTextBox.Size = new System.Drawing.Size(277, 22);
            this.parolaSignUpTextBox.TabIndex = 13;
            this.parolaSignUpTextBox.TextChanged += new System.EventHandler(this.parolaSignUpTextBox_TextChanged);
            // 
            // emailSignUpTextBox
            // 
            this.emailSignUpTextBox.Location = new System.Drawing.Point(420, 460);
            this.emailSignUpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.emailSignUpTextBox.Name = "emailSignUpTextBox";
            this.emailSignUpTextBox.Size = new System.Drawing.Size(277, 22);
            this.emailSignUpTextBox.TabIndex = 12;
            this.emailSignUpTextBox.TextChanged += new System.EventHandler(this.emailSignUpTextBox_TextChanged);
            // 
            // usernameSignUpTextBox
            // 
            this.usernameSignUpTextBox.Location = new System.Drawing.Point(420, 410);
            this.usernameSignUpTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameSignUpTextBox.Name = "usernameSignUpTextBox";
            this.usernameSignUpTextBox.Size = new System.Drawing.Size(277, 22);
            this.usernameSignUpTextBox.TabIndex = 11;
            this.usernameSignUpTextBox.TextChanged += new System.EventHandler(this.usernameSignUpTextBox_TextChanged);
            // 
            // parolaSignUpLabel
            // 
            this.parolaSignUpLabel.AutoSize = true;
            this.parolaSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaSignUpLabel.Location = new System.Drawing.Point(187, 519);
            this.parolaSignUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parolaSignUpLabel.Name = "parolaSignUpLabel";
            this.parolaSignUpLabel.Size = new System.Drawing.Size(96, 29);
            this.parolaSignUpLabel.TabIndex = 10;
            this.parolaSignUpLabel.Text = "Parola:";
            // 
            // emailSignUpLabel
            // 
            this.emailSignUpLabel.AutoSize = true;
            this.emailSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailSignUpLabel.Location = new System.Drawing.Point(188, 454);
            this.emailSignUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailSignUpLabel.Name = "emailSignUpLabel";
            this.emailSignUpLabel.Size = new System.Drawing.Size(95, 29);
            this.emailSignUpLabel.TabIndex = 9;
            this.emailSignUpLabel.Text = "E-mail:";
            // 
            // usernameSignUpLabel
            // 
            this.usernameSignUpLabel.AutoSize = true;
            this.usernameSignUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameSignUpLabel.Location = new System.Drawing.Point(141, 404);
            this.usernameSignUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameSignUpLabel.Name = "usernameSignUpLabel";
            this.usernameSignUpLabel.Size = new System.Drawing.Size(139, 29);
            this.usernameSignUpLabel.TabIndex = 8;
            this.usernameSignUpLabel.Text = "Username:";
            // 
            // newsletterCheckBox
            // 
            this.newsletterCheckBox.AutoSize = true;
            this.newsletterCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newsletterCheckBox.Location = new System.Drawing.Point(236, 788);
            this.newsletterCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.newsletterCheckBox.Name = "newsletterCheckBox";
            this.newsletterCheckBox.Size = new System.Drawing.Size(299, 29);
            this.newsletterCheckBox.TabIndex = 16;
            this.newsletterCheckBox.Text = "Aboneaza-ma la Newsletter";
            this.newsletterCheckBox.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(1, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(836, 1029);
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // signUpLabel
            // 
            this.signUpLabel.AutoSize = true;
            this.signUpLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signUpLabel.Location = new System.Drawing.Point(147, 121);
            this.signUpLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.signUpLabel.Name = "signUpLabel";
            this.signUpLabel.Size = new System.Drawing.Size(471, 135);
            this.signUpLabel.TabIndex = 18;
            this.signUpLabel.Text = "Sign up";
            // 
            // BackButton
            // 
            this.BackButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(243, 661);
            this.BackButton.Margin = new System.Windows.Forms.Padding(4);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(256, 48);
            this.BackButton.TabIndex = 19;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // Sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 1020);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.signUpLabel);
            this.Controls.Add(this.newsletterCheckBox);
            this.Controls.Add(this.signUpButton);
            this.Controls.Add(this.gdprCheckBox);
            this.Controls.Add(this.parolaSignUpTextBox);
            this.Controls.Add(this.emailSignUpTextBox);
            this.Controls.Add(this.usernameSignUpTextBox);
            this.Controls.Add(this.parolaSignUpLabel);
            this.Controls.Add(this.emailSignUpLabel);
            this.Controls.Add(this.usernameSignUpLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Sign_up";
            this.Text = "Sign up";
            this.Load += new System.EventHandler(this.Sign_up_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button signUpButton;
        private System.Windows.Forms.CheckBox gdprCheckBox;
        private System.Windows.Forms.TextBox parolaSignUpTextBox;
        private System.Windows.Forms.TextBox emailSignUpTextBox;
        private System.Windows.Forms.TextBox usernameSignUpTextBox;
        private System.Windows.Forms.Label parolaSignUpLabel;
        private System.Windows.Forms.Label emailSignUpLabel;
        private System.Windows.Forms.Label usernameSignUpLabel;
        private System.Windows.Forms.CheckBox newsletterCheckBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label signUpLabel;
        private System.Windows.Forms.Button BackButton;
    }
}