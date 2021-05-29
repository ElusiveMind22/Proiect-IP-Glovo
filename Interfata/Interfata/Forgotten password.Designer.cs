
namespace Interfata
{
    partial class Forgotten_password
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
            this.EmailTextBox = new System.Windows.Forms.TextBox();
            this.HelpLabel = new System.Windows.Forms.Label();
            this.NextButton = new System.Windows.Forms.Button();
            this.BackButton = new System.Windows.Forms.Button();
            this.NextButton2 = new System.Windows.Forms.Button();
            this.NextButton3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailTextBox
            // 
            this.EmailTextBox.Location = new System.Drawing.Point(279, 134);
            this.EmailTextBox.Name = "EmailTextBox";
            this.EmailTextBox.Size = new System.Drawing.Size(100, 22);
            this.EmailTextBox.TabIndex = 0;
            // 
            // HelpLabel
            // 
            this.HelpLabel.AutoSize = true;
            this.HelpLabel.Location = new System.Drawing.Point(291, 94);
            this.HelpLabel.Name = "HelpLabel";
            this.HelpLabel.Size = new System.Drawing.Size(46, 17);
            this.HelpLabel.TabIndex = 1;
            this.HelpLabel.Text = "label1";
            this.HelpLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // NextButton
            // 
            this.NextButton.Location = new System.Drawing.Point(239, 185);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(75, 23);
            this.NextButton.TabIndex = 2;
            this.NextButton.Text = "Next";
            this.NextButton.UseVisualStyleBackColor = true;
            this.NextButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(294, 231);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // NextButton2
            // 
            this.NextButton2.Location = new System.Drawing.Point(335, 185);
            this.NextButton2.Name = "NextButton2";
            this.NextButton2.Size = new System.Drawing.Size(75, 23);
            this.NextButton2.TabIndex = 4;
            this.NextButton2.Text = "Next";
            this.NextButton2.UseVisualStyleBackColor = true;
            this.NextButton2.Click += new System.EventHandler(this.NextButton2_Click);
            // 
            // NextButton3
            // 
            this.NextButton3.Location = new System.Drawing.Point(433, 185);
            this.NextButton3.Name = "NextButton3";
            this.NextButton3.Size = new System.Drawing.Size(75, 23);
            this.NextButton3.TabIndex = 5;
            this.NextButton3.Text = "Next";
            this.NextButton3.UseVisualStyleBackColor = true;
            this.NextButton3.Click += new System.EventHandler(this.NextButton3_Click);
            // 
            // Forgotten_password
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NextButton3);
            this.Controls.Add(this.NextButton2);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.NextButton);
            this.Controls.Add(this.HelpLabel);
            this.Controls.Add(this.EmailTextBox);
            this.Name = "Forgotten_password";
            this.Text = "Forgotten_password";
            this.Load += new System.EventHandler(this.Forgotten_password_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox EmailTextBox;
        private System.Windows.Forms.Label HelpLabel;
        private System.Windows.Forms.Button NextButton;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.Button NextButton2;
        private System.Windows.Forms.Button NextButton3;
    }
}