using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace STOCK
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Txtuser_TextChanged(object sender, EventArgs e)
        {
            labelhead.Text = $"Welcome,dear {txtuser.Text}!";
            labelerror.Visible = false;
        }

        private void BtnSingIn_Click(object sender, EventArgs e)
        {
            if (txtuser.Text == "admin" && txtpassword.Text == "Admin123")
            {
                adminPanel adminPanel = new adminPanel();
                adminPanel.ShowDialog();
            }
            else
            {
                labelerror.Visible = true;
            }
        }
    }
}
