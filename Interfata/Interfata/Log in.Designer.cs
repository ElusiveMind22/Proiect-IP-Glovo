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
            this.BackButton = new System.Windows.Forms.Button();
            this.checkBox_afiseaza_parola = new System.Windows.Forms.CheckBox();
            this.ResetButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // usernameLogInLabel
            // 
            this.usernameLogInLabel.AutoSize = true;
            this.usernameLogInLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogInLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.usernameLogInLabel.Location = new System.Drawing.Point(149, 388);
            this.usernameLogInLabel.Name = "usernameLogInLabel";
            this.usernameLogInLabel.Size = new System.Drawing.Size(113, 26);
            this.usernameLogInLabel.TabIndex = 0;
            this.usernameLogInLabel.Text = "Username:";
            // 
            // parolaLogInLabel
            // 
            this.parolaLogInLabel.AutoSize = true;
            this.parolaLogInLabel.Font = new System.Drawing.Font("Open Sans", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLogInLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.parolaLogInLabel.Location = new System.Drawing.Point(184, 430);
            this.parolaLogInLabel.Name = "parolaLogInLabel";
            this.parolaLogInLabel.Size = new System.Drawing.Size(78, 26);
            this.parolaLogInLabel.TabIndex = 2;
            this.parolaLogInLabel.Text = "Parola:";
            // 
            // usernameLogInTextBox
            // 
            this.usernameLogInTextBox.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLogInTextBox.Location = new System.Drawing.Point(296, 385);
            this.usernameLogInTextBox.Name = "usernameLogInTextBox";
            this.usernameLogInTextBox.Size = new System.Drawing.Size(209, 29);
            this.usernameLogInTextBox.TabIndex = 3;
           // 
            // parolaLogInTextBox
            // 
            this.parolaLogInTextBox.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaLogInTextBox.Location = new System.Drawing.Point(296, 430);
            this.parolaLogInTextBox.Name = "parolaLogInTextBox";
            this.parolaLogInTextBox.Size = new System.Drawing.Size(209, 29);
            this.parolaLogInTextBox.TabIndex = 5;
           // rememberMeCheckBox
            // 
            this.rememberMeCheckBox.AutoSize = true;
            this.rememberMeCheckBox.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rememberMeCheckBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rememberMeCheckBox.Location = new System.Drawing.Point(130, 508);
            this.rememberMeCheckBox.Name = "rememberMeCheckBox";
            this.rememberMeCheckBox.Size = new System.Drawing.Size(134, 24);
            this.rememberMeCheckBox.TabIndex = 6;
            this.rememberMeCheckBox.Text = "Tine-ma minte";
            this.rememberMeCheckBox.UseVisualStyleBackColor = true;
           // 
            // logInButton
            // 
            this.logInButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.logInButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInButton.Location = new System.Drawing.Point(211, 626);
            this.logInButton.Name = "logInButton";
            this.logInButton.Size = new System.Drawing.Size(184, 33);
            this.logInButton.TabIndex = 7;
            this.logInButton.Text = "Log in";
            this.logInButton.UseVisualStyleBackColor = false;
            this.logInButton.Click += new System.EventHandler(this.logInButton_Click);
            // 
            // parolaUitataButton
            // 
            this.parolaUitataButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.parolaUitataButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.parolaUitataButton.Location = new System.Drawing.Point(211, 681);
            this.parolaUitataButton.Name = "parolaUitataButton";
            this.parolaUitataButton.Size = new System.Drawing.Size(184, 33);
            this.parolaUitataButton.TabIndex = 8;
            this.parolaUitataButton.Text = "Parola uitata";
            this.parolaUitataButton.UseVisualStyleBackColor = false;
            this.parolaUitataButton.Click += new System.EventHandler(this.parolaUitataButton_Click);
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
            this.logInLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.logInLabel.Location = new System.Drawing.Point(132, 166);
            this.logInLabel.Name = "logInLabel";
            this.logInLabel.Size = new System.Drawing.Size(352, 131);
            this.logInLabel.TabIndex = 10;
            this.logInLabel.Text = "Log In";
            this.logInLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // BackButton
            // 
            this.BackButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BackButton.Location = new System.Drawing.Point(211, 734);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(184, 33);
            this.BackButton.TabIndex = 11;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = false;
            this.BackButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox_afiseaza_parola
            // 
            this.checkBox_afiseaza_parola.AutoSize = true;
            this.checkBox_afiseaza_parola.Font = new System.Drawing.Font("Open Sans SemiBold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox_afiseaza_parola.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.checkBox_afiseaza_parola.Location = new System.Drawing.Point(125, 478);
            this.checkBox_afiseaza_parola.Name = "checkBox_afiseaza_parola";
            this.checkBox_afiseaza_parola.Size = new System.Drawing.Size(139, 24);
            this.checkBox_afiseaza_parola.TabIndex = 12;
            this.checkBox_afiseaza_parola.Text = "Afiseaza parola";
            this.checkBox_afiseaza_parola.UseVisualStyleBackColor = true;
            this.checkBox_afiseaza_parola.CheckedChanged += new System.EventHandler(this.checkBox_afiseaza_parola_CheckedChanged);
            // 
            // ResetButton
            // 
            this.ResetButton.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ResetButton.Font = new System.Drawing.Font("Open Sans SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResetButton.Location = new System.Drawing.Point(321, 499);
            this.ResetButton.Name = "ResetButton";
            this.ResetButton.Size = new System.Drawing.Size(184, 33);
            this.ResetButton.TabIndex = 13;
            this.ResetButton.Text = "Reset";
            this.ResetButton.UseVisualStyleBackColor = false;
            this.ResetButton.Click += new System.EventHandler(this.ResetButton_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 829);
            this.Controls.Add(this.ResetButton);
            this.Controls.Add(this.checkBox_afiseaza_parola);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.logInLabel);
            this.Controls.Add(this.parolaUitataButton);
            this.Controls.Add(this.logInButton);
            this.Controls.Add(this.rememberMeCheckBox);
            this.Controls.Add(this.parolaLogInTextBox);
            this.Controls.Add(this.usernameLogInTextBox);
            this.Controls.Add(this.parolaLogInLabel);
            this.Controls.Add(this.usernameLogInLabel);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.CheckBox checkBox_afiseaza_parola;
        private System.Windows.Forms.Button ResetButton;
    }
}