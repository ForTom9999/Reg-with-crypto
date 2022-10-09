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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Write.IrEmail();
           // Write.IrHash();
        }

        private void RegBTN_Click(object sender, EventArgs e)
        {
            //To Registration
            // Read.FileCreate();
            
            this.Hide();
            Form Registration = new Registration();
            Registration.ShowDialog();
        }

        private void LgnBTN_Click(object sender, EventArgs e)
        {
            //To Log IN
            this.Hide();
            Form LogIn = new LogIn();
            LogIn.ShowDialog();
        }
    }
}
