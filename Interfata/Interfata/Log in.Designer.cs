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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
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
            this.usernameLogInLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogInLabel.Location = new System.Drawing.Point(116, 363);
            this.usernameLogInLabel.Name = "usernameLogInLabel";
            this.usernameLogInLabel.Size = new System.Drawing.Size(111, 26);
            this.usernameLogInLabel.TabIndex = 0;
            this.usernameLogInLabel.Text = "Username:";
            // 
            // parolaLogInLabel
            // 
            this.parolaLogInLabel.AutoSize = true;
            this.parolaLogInLabel.Font = new System.Drawing.Font("Open Sans SemiBold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLogInLabel.Location = new System.Drawing.Point(150, 420);
            this.parolaLogInLabel.Name = "parolaLogInLabel";
            this.parolaLogInLabel.Size = new System.Drawing.Size(76, 26);
            this.parolaLogInLabel.TabIndex = 2;
            this.parolaLogInLabel.Text = "Parola:";
            // 
            // usernameLogInTextBox
            // 
            this.usernameLogInTextBox.Location = new System.Drawing.Point(325, 368);
            this.usernameLogInTextBox.Name = "usernameLogInTextBox";
            this.usernameLogInTextBox.Size = new System.Drawing.Size(209, 20);
            this.usernameLogInTextBox.TabIndex = 3;
            // 
            // parolaLogInTextBox
            // 
            this.parolaLogInTextBox.Location = new System.Drawing.Point(325, 424);
            this.parolaLogInTextBox.Name = "parolaLogInTextBox";
            this.parolaLogInTextBox.Size = new System.Drawing.Size(209, 20);
            this.parolaLogInTextBox.TabIndex = 5;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Cera Pro", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(227, 635);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(134, 24);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Tine-ma minte";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // logInButton
            // 
            this.logInButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(197, 514);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(192, 39);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = true;
            // 
            // parolaUitataButton
            // 
            this.parolaUitataButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaUitataButton.Location = new System.Drawing.Point(197, 568);
            this.parolaUitataButton.Name = "parolaUitataButton";
            this.parolaUitataButton.Size = new System.Drawing.Size(192, 39);
            this.parolaUitataButton.TabIndex = 8;
            this.parolaUitataButton.Text = "Parola uitata";
            this.parolaUitataButton.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.Location = new System.Drawing.Point(0, -3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(622, 834);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // logInLabel
            // 
            this.logInLabel.AutoSize = true;
            this.logInLabel.Font = new System.Drawing.Font("Open Sans ExtraBold", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInLabel.Location = new System.Drawing.Point(134, 141);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(352, 131);
            this.logInLabel.TabIndex = 10;
            this.logInLabel.Text = "Log In";
            this.logInLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 829);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.parolaUitataButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.parolaLogInTextBox);
            this.Controls.Add(this.usernameLogInTextBox);
            this.Controls.Add(this.parolaLogInLabel);
            this.Controls.Add(this.usernameLogInLabel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "LogIn";
            this.Text = "Log In";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label usernameLogInLabel;
        private System.Windows.Forms.Label parolaLogInLabel;
        private System.Windows.Forms.TextBox usernameLogInTextBox;
        private System.Windows.Forms.TextBox parolaLogInTextBox;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button logInButton;
        private System.Windows.Forms.Button parolaUitataButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label logInLabel;
    }
}