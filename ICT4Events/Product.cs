using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //teun van der wijst
    public class Product
    {
        private static int idnumber = 0;
        private int ID_product;
        private string product_name;
        private decimal bail;
        private decimal price;

        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        

        public decimal Bail
        {
            get { return bail; }
            set { bail = value; }
        }
        

        public string Product_Name
        {
            get { return product_name; }
            set { product_name = value; }
        }
        

        public int ID_Product
        {
            get { return ID_product; }
            set { ID_product = value; }
        }
        
        public Product(string product_name, decimal bail, decimal price)
        {
            this.ID_product = idnumber;
            idnumber++;
            this.product_name = product_name;
            this.bail = bail;
            this.price = price;
        }

        public decimal GetProductPrice()
        {
            decimal a = bail + price;
            return a;
        }
    }
}
