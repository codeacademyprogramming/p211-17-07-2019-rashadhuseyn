using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCK
{
    public class Products
    {

        public string proName;
        public string proID { get;set; }
        public string ID { get; private set; }
        public static int id = 1;
        public Products()
        {
            ID = new String('0', 5 - id.ToString().Length) + id.ToString();
            id++;
        }
    }
}
