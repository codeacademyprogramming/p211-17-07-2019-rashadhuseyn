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
    public partial class adminPanel : Form
    {
        public adminPanel()
        {
            InitializeComponent();
        }
        public static Categories[] categorylist;
        public void Catadder_Click(object sender, EventArgs e)
        {
         Int32.TryParse(catcount.Text, out int count);
         categorylist = new Categories[count];
           string cats = catname.Text;
            for (int i = 0; i < categorylist.Length; i++)
            {
                categorylist[i] = new Categories();
                categorylist[i].CatName =cats.Split(',')[i];
                procategory.Items.Add( cats.Split(',')[i]);
            }
            

        }
        public static Products[] prolist;
        private void Proadder_Click(object sender, EventArgs e)
        {
            Int32.TryParse(procount.Text, out int count2);
            prolist = new Products[count2];
            string products = proname.Text;
            for (int i = 0; i < prolist.Length; i++)
            {
                prolist[i] = new Products();
                prolist[i].proName = products.Split(',')[i];
                string procat = procategory.Text;
                foreach(Categories item in categorylist)
                {
                    if(item.CatName == procat)
                    {
                        prolist[i].proID = item.ID;
                    }
                }
                
            }
        }

        private void Gotostock_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.ShowDialog();
        }
    }
}
