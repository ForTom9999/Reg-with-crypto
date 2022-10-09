namespace Reg_with_crypto
{
    partial class Registration
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
            this.EmailTX = new System.Windows.Forms.TextBox();
            this.PasswordTX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.IsValidPasswordLBL = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.btnLogIn = new System.Windows.Forms.Button();
            this.ConfirmPasswordTX = new System.Windows.Forms.TextBox();
            this.confirmPassLBL = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EmailTX
            // 
            this.EmailTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EmailTX.Location = new System.Drawing.Point(21, 93);
            this.EmailTX.MaxLength = 128;
            this.EmailTX.Multiline = true;
            this.EmailTX.Name = "EmailTX";
            this.EmailTX.Size = new System.Drawing.Size(258, 35);
            this.EmailTX.TabIndex = 2;
            this.EmailTX.Text = "aaa@aa.hu";
            this.EmailTX.Leave += new System.EventHandler(this.EmailTX_Leave);
            // 
            // PasswordTX
            // 
            this.PasswordTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PasswordTX.Location = new System.Drawing.Point(392, 93);
            this.PasswordTX.Multiline = true;
            this.PasswordTX.Name = "PasswordTX";
            this.PasswordTX.PasswordChar = '*';
            this.PasswordTX.Size = new System.Drawing.Size(258, 35);
            this.PasswordTX.TabIndex = 2;
            this.PasswordTX.TextChanged += new System.EventHandler(this.PasswordTX_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(88, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 37);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(123, 276);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "HASH";
            this.label1.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.GhostWhite;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(292, 205);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(105, 73);
            this.button2.TabIndex = 0;
            this.button2.Text = "Reg";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.Location = new System.Drawing.Point(465, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(120, 37);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password";
            this.label3.Click += new System.EventHandler(this.label2_Click);
            // 
            // IsValidPasswordLBL
            // 
            this.IsValidPasswordLBL.AutoSize = true;
            this.IsValidPasswordLBL.Location = new System.Drawing.Point(410, 9);
            this.IsValidPasswordLBL.Name = "IsValidPasswordLBL";
            this.IsValidPasswordLBL.Size = new System.Drawing.Size(116, 16);
            this.IsValidPasswordLBL.TabIndex = 1;
            this.IsValidPasswordLBL.Text = "Password Strengh";
            this.IsValidPasswordLBL.Click += new System.EventHandler(this.label2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.GhostWhite;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(21, 205);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(105, 73);
            this.button4.TabIndex = 3;
            this.button4.Text = "Back";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.BackColor = System.Drawing.Color.GhostWhite;
            this.btnLogIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnLogIn.Location = new System.Drawing.Point(545, 207);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.Size = new System.Drawing.Size(105, 73);
            this.btnLogIn.TabIndex = 3;
            this.btnLogIn.Text = "Go to Login";
            this.btnLogIn.UseVisualStyleBackColor = false;
            this.btnLogIn.Click += new System.EventHandler(this.btnLOgIn_Click);
            // 
            // ConfirmPasswordTX
            // 
            this.ConfirmPasswordTX.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ConfirmPasswordTX.Location = new System.Drawing.Point(392, 143);
            this.ConfirmPasswordTX.Multiline = true;
            this.ConfirmPasswordTX.Name = "ConfirmPasswordTX";
            this.ConfirmPasswordTX.PasswordChar = '*';
            this.ConfirmPasswordTX.Size = new System.Drawing.Size(258, 35);
            this.ConfirmPasswordTX.TabIndex = 2;
            this.ConfirmPasswordTX.Leave += new System.EventHandler(this.textBox1_Leave);
            // 
            // confirmPassLBL
            // 
            this.confirmPassLBL.AutoSize = true;
            this.confirmPassLBL.Font = new System.Drawing.Font("Monotype Corsiva", 12.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.confirmPassLBL.Location = new System.Drawing.Point(104, 152);
            this.confirmPassLBL.Name = "confirmPassLBL";
            this.confirmPassLBL.Size = new System.Drawing.Size(154, 26);
            this.confirmPassLBL.TabIndex = 1;
            this.confirmPassLBL.Text = "Confirm password";
            this.confirmPassLBL.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.confirmPassLBL.Visible = false;
            this.confirmPassLBL.Click += new System.EventHandler(this.label2_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.btnLogIn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.ConfirmPasswordTX);
            this.Controls.Add(this.PasswordTX);
            this.Controls.Add(this.EmailTX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IsValidPasswordLBL);
            this.Controls.Add(this.confirmPassLBL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox EmailTX;
        private System.Windows.Forms.TextBox PasswordTX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label IsValidPasswordLBL;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnLogIn;
        private System.Windows.Forms.TextBox ConfirmPasswordTX;
        private System.Windows.Forms.Label confirmPassLBL;
    }
}

