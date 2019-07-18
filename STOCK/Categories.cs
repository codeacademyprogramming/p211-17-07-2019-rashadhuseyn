using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STOCK
{
    public class Categories
    {

        public string CatName;
        public string ID { get; private set; }
        public static int id = 1;
        public Categories()
        {
            ID = new String('0', 5 - id.ToString().Length) + id.ToString();
            id++;
        }

    }
}
