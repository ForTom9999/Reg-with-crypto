using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Reg_with_crypto.FileIO
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Back to Index page BTN
            this.Hide();
            Form index = new Form1();
            index.ShowDialog();
        }

        private void LogInBTN_Click(object sender, EventArgs e)
        {
            // bool isRegEmail = Read.IsREgistredEmail(EmailTX.Text);
            int id = Read.GetID(EmailTX.Text);

            if (id!=-1)
            {
                if (Read.CheckPassword(PasswordTX.Text, id))
                {
                    this.Hide();
                    Form form = new YouAreIN();
                    form.ShowDialog();

                }
                
            }
            else MessageBox.Show("The email is registered!", "Email error!");

        }
    }
}
