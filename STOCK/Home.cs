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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            foreach (Categories item in adminPanel.categorylist)
            {
                procategory.Items.Add(item.CatName);
            }
        }

        private void Procategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (Categories item in adminPanel.categorylist)
            {
                if(item.CatName == procategory.Text)
                {
                foreach (Products pro in adminPanel.prolist)
                    {
                    if(item.ID == pro.proID)
                        {
                            ProductsList.Items.Add(pro.proName);
                        }
                    }
                }
            }
        }
    }
}
     