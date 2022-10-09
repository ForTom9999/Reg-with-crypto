namespace Reg_with_crypto.FileIO
{
    partial class Form1
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
            this.LgnBTN = new System.Windows.Forms.Button();
            this.RegBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // LgnBTN
            // 
            this.LgnBTN.BackColor = System.Drawing.Color.GhostWhite;
            this.LgnBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.LgnBTN.Location = new System.Drawing.Point(45, 192);
            this.LgnBTN.Name = "LgnBTN";
            this.LgnBTN.Size = new System.Drawing.Size(175, 73);
            this.LgnBTN.TabIndex = 0;
            this.LgnBTN.Text = "Login";
            this.LgnBTN.UseVisualStyleBackColor = false;
            this.LgnBTN.Click += new System.EventHandler(this.LgnBTN_Click);
            // 
            // RegBTN
            // 
            this.RegBTN.BackColor = System.Drawing.Color.GhostWhite;
            this.RegBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RegBTN.Location = new System.Drawing.Point(453, 192);
            this.RegBTN.Name = "RegBTN";
            this.RegBTN.Size = new System.Drawing.Size(175, 73);
            this.RegBTN.TabIndex = 0;
            this.RegBTN.Text = "Registration";
            this.RegBTN.UseVisualStyleBackColor = false;
            this.RegBTN.Click += new System.EventHandler(this.RegBTN_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 47.18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(29, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(599, 96);
            this.label1.TabIndex = 1;
            this.label1.Text = "What do you want?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(682, 303);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RegBTN);
            this.Controls.Add(this.LgnBTN);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "index";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button LgnBTN;
        private System.Windows.Forms.Button RegBTN;
        private System.Windows.Forms.Label label1;
    }
}