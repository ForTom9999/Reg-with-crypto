using Reg_with_crypto.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Reg_with_crypto
{
    public partial class Registration : Form
    {
        private string input;

        public string Input { get => input; set => input = value; }

        public Registration()
        {
            InitializeComponent();
            
        }

      /*  private void button1_Click(object sender, EventArgs e)
        {
            //   input = Convert.ToString(NameTX.Text);
            input = "";
        }
             */
        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // REG btn
            Input = Convert.ToString(EmailTX.Text);
           
            label1.Text = Crypto.ToSHA256(Input);

            bool match = ConfirmPasswordTX.Text == PasswordTX.Text; // True
            bool isRegEmail = Read.IsREgistredEmail(EmailTX.Text);  // False
            bool check = CheckEmail.Check(EmailTX.Text);            // True

            if (match)
            {
                if (!isRegEmail)
                {
                    if (check)
                    {
                        
                            Write.Reg(EmailTX.Text, PasswordTX.Text);
                        MessageBox.Show("Registration is complete");

                    }
                    
                    else MessageBox.Show("Not valid email!", "Email error!");

                }

                else MessageBox.Show("The email is registered!", "Email error!");

            }
            else MessageBox.Show("The passwords are NOT same!", "Password error");



        }

        private void label2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("What are you doing?!?!");
         //   Crypto.CreateFile();
            
        }

        

        

        private void button4_Click(object sender, EventArgs e) //Vissza INDEX-re
        {
            this.Hide();
            Form index = new Form1();
            index.ShowDialog();
        }

        private void PasswordTX_TextChanged(object sender, EventArgs e)
        {
            CheckPassword.Check(PasswordTX.Text);
            switch (CheckPassword.score)
            {
                case 5:
                    {
                        IsValidPasswordLBL.Text = "WOW! AMAZING PASSWORD!!!!";
                        IsValidPasswordLBL.ForeColor = Color.Green; break;
                    }
                case 4:
                    {
                        IsValidPasswordLBL.Text = "Great Password!";
                        IsValidPasswordLBL.ForeColor = Color.Green; break;
                    }

                case 3:
                    {
                        IsValidPasswordLBL.Text = "It is a hard password!";
                        IsValidPasswordLBL.ForeColor = Color.Yellow; break;
                    }
                case 2:
                    {
                        IsValidPasswordLBL.Text = "It's a medium hard password";
                        IsValidPasswordLBL.ForeColor = Color.Yellow; break;
                    }
                case 1:
                    {
                        IsValidPasswordLBL.Text = "It is just a little simple password";
                        IsValidPasswordLBL.ForeColor = Color.Red; break;
                    }
                case 0:
                    {
                        IsValidPasswordLBL.Text = "This password is too simple";
                        IsValidPasswordLBL.ForeColor = Color.Red; break;
                    }
                default: IsValidPasswordLBL.Text = "ERROR!"; break;
            }
            CheckPassword.score = 0;
        }

        private void btnLOgIn_Click(object sender, EventArgs e)
        {
            //To Login
            this.Hide();
            Form LogIn = new LogIn();
            LogIn.ShowDialog();
        }

       

        private void EmailTX_Leave(object sender, EventArgs e)
        {
            // Email check
            // MessageBox.Show("Hiba");
        }


        private void PasswordTX_KeyUp(object sender, KeyEventArgs e)
        {
            PasswordTX.Text = "*";
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (ConfirmPasswordTX.Text == PasswordTX.Text)
            {
                confirmPassLBL.Visible = true;
                confirmPassLBL.ForeColor = Color.Green;
                confirmPassLBL.Text = "The passwords match!";
            }
            else
            {
                confirmPassLBL.Visible = true;
                confirmPassLBL.ForeColor = Color.Red;
                confirmPassLBL.Text = "The passwords DON'T match!!!!";
            }
        }
    }
}
