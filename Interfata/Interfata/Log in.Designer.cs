namespace Interfata
{
    partial class LogIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn));
            this.usernameLogInLabel = new System.Windows.Forms.Label();
            this.parolaLogInLabel = new System.Windows.Forms.Label();
            this.usernameLogInTextBox = new System.Windows.Forms.TextBox();
            this.parolaLogInTextBox = new System.Windows.Forms.TextBox();
            this.rememberMeCheckBox = new System.Windows.Forms.CheckBox();
            this.logInButton = new System.Windows.Forms.Button();
            this.parolaUitataButton = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.logInLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLogInLabel
            // 
            this.usernameLogInLabel.AutoSize = true;
            this.usernameLogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogInLabel.Location = new System.Drawing.Point(155, 447);
            this.usernameLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.usernameLogInLabel.Name = "usernameLogInLabel";
            this.usernameLogInLabel.Size = new System.Drawing.Size(139, 29);
            this.usernameLogInLabel.TabIndex = 0;
            this.usernameLogInLabel.Text = "Username:";
            // 
            // parolaLogInLabel
            // 
            this.parolaLogInLabel.AutoSize = true;
            this.parolaLogInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLogInLabel.Location = new System.Drawing.Point(200, 517);
            this.parolaLogInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.parolaLogInLabel.Name = "parolaLogInLabel";
            this.parolaLogInLabel.Size = new System.Drawing.Size(96, 29);
            this.parolaLogInLabel.TabIndex = 2;
            this.parolaLogInLabel.Text = "Parola:";
            // 
            // usernameLogInTextBox
            // 
            this.usernameLogInTextBox.Location = new System.Drawing.Point(433, 453);
            this.usernameLogInTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.usernameLogInTextBox.Name = "usernameLogInTextBox";
            this.usernameLogInTextBox.Size = new System.Drawing.Size(277, 22);
            this.usernameLogInTextBox.TabIndex = 3;
            this.usernameLogInTextBox.TextChanged += new System.EventHandler(this.usernameLogInTextBox_TextChanged);
            // 
            // parolaLogInTextBox
            // 
            this.parolaLogInTextBox.Location = new System.Drawing.Point(433, 522);
            this.parolaLogInTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.parolaLogInTextBox.Name = "parolaLogInTextBox";
            this.parolaLogInTextBox.Size = new System.Drawing.Size(277, 22);
            this.parolaLogInTextBox.TabIndex = 5;
            this.parolaLogInTextBox.TextChanged += new System.EventHandler(this.parolaLogInTextBox_TextChanged);
            // 
            // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCheckBox.Location = new System.Drawing.Point(303, 782);
            this.rememberMeCheckBox.Margin = new System.Windows.Forms.Padding(4);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(172, 29);
            this.rememberMeCheckBox.TabIndex = 6;
            this.rememberMeCheckBox.Text = "Tine-ma minte";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
            this.rememberMeCheckBox.CheckedChanged += new System.EventHandler(this.rememberMeCheckBox_CheckedChanged);
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(263, 633);
            this.logInButton.Margin = new System.Windows.Forms.Padding(4);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(256, 48);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // parolaUitataButton
            // 
            this.parolaUitataButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaUitataButton.Location = new System.Drawing.Point(263, 699);
            this.parolaUitataButton.Margin = new System.Windows.Forms.Padding(4);
            this.parolaUitataButton.Name = "parolaUitataButton";
            this.parolaUitataButton.Size = new System.Drawing.Size(256, 48);
            this.parolaUitataButton.TabIndex = 8;
            this.parolaUitataButton.Text = "Parola uitata";
            this.parolaUitataButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -4);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(829, 1026);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.Location = new System.Drawing.Point(179, 174);
            this.logInLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(396, 135);
            this.logInLabel.TabIndex = 10;
            this.logInLabel.Text = "Log In";
            this.logInLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 1020);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.parolaUitataButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.parolaLogInTextBox);
            this.Controls.Add(this.usernameLogInTextBox);
            this.Controls.Add(this.parolaLogInLabel);
            this.Controls.Add(this.usernameLogInLabel);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "LogIn";
            this.Text = "Log In";
            this.Load += new System.EventHandler(this.LogIn_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLogInLabel;
        private System.Windows.Forms.Label parolaLogInLabel;
        private System.Windows.Forms.TextBox usernameLogInTextBox;
        private System.Windows.Forms.TextBox parolaLogInTextBox;
        private System.Windows.Forms.CheckBox rememberMeCheckBox;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button parolaUitataButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logInLabel;
    }
}