namespace Reg_with_crypto.FileIO
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
            this.EmailLBL = new System.Windows.Forms.Label();
            this.EmailTX = new System.Windows.Forms.TextBox();
            this.PasswordTX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.LogInBTN = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EmailLBL
            // 
            this.EmailLBL.AutoSize = true;
            this.EmailLBL.Font = new System.Drawing.Font("Monotype Corsiva", 27.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailLBL.Location = new System.Drawing.Point(83, 29);
            this.EmailLBL.Name = "EmailLBL";
            this.EmailLBL.Size = new System.Drawing.Size(124, 56);
            this.EmailLBL.TabIndex = 0;
            this.EmailLBL.Text = "Email";
            // 
            // EmailTX
            // 
            this.EmailTX.Location = new System.Drawing.Point(28, 88);
            this.EmailTX.Multiline = true;
            this.EmailTX.Name = "EmailTX";
            this.EmailTX.Size = new System.Drawing.Size(258, 44);
            this.EmailTX.TabIndex = 1;
            // 
            // PasswordTX
            // 
            this.PasswordTX.Location = new System.Drawing.Point(386, 88);
            this.PasswordTX.Multiline = true;
            this.PasswordTX.Name = "PasswordTX";
            this.PasswordTX.Size = new System.Drawing.Size(261, 44);
            this.PasswordTX.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 27.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(419, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(185, 56);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password";
            // 
            // LogInBTN
            // 
            this.LogInBTN.BackColor = System.Drawing.Color.GhostWhite;
            this.LogInBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LogInBTN.Location = new System.Drawing.Point(216, 156);
            this.LogInBTN.Name = "LogInBTN";
            this.LogInBTN.Size = new System.Drawing.Size(261, 73);
            this.LogInBTN.TabIndex = 2;
            this.LogInBTN.Text = "Log in";
            this.LogInBTN.UseVisualStyleBackColor = false;
            this.LogInBTN.Click += new System.EventHandler(this.LogInBTN_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.GhostWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(28, 218);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 73);
            this.button1.TabIndex = 2;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LogInBTN);
            this.Controls.Add(this.PasswordTX);
            this.Controls.Add(this.EmailTX);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.EmailLBL);
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Log in";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label EmailLBL;
        private System.Windows.Forms.TextBox EmailTX;
        private System.Windows.Forms.TextBox PasswordTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button LogInBTN;
        private System.Windows.Forms.Button button1;
    }
}