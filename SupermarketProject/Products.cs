using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketProject
{
    public class Products
    {
        int price;
        string? productname;
        
        public int Price
        {
            set { price = value; }
            get { return price; }
        }

        public string? ProductName
        {
            set { productname = value; }
            get { return productname; }
        }
    }
}
