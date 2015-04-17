using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Oracle.ManagedDataAccess.Client;
using Oracle.ManagedDataAccess.Types;

namespace ICT4Events
{
    //Mario Schipper
    public class Product
    {
        //private static int idnumber = 0;
        private int iD_product;
        private string product_name;
        private decimal bail;
        private decimal price;

        private List<Product> productList;

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
            get { return iD_product; }
            set { iD_product = value; }
        }
        
        public Product(int iD_product, string product_name, decimal bail, decimal price)
        {
           // this.ID_product = idnumber;
           // idnumber++;
            this.iD_product = iD_product;
            this.product_name = product_name;
            this.bail = bail;
            this.price = price;
        }

        public decimal GetProductPrice()
        {
            decimal a = bail + price;
            return a;
        }

        
           public Product()
        {
            productList = new List<Product>();
        }

         public List<Product> RequestProducts()
         {
             DatabaseConnection con = new DatabaseConnection();
             string Querry = "SELECT ID_PRODUCT, PRODUCTNAME, BAIL, PRICE FROM ICT4_PRODUCT";
             

             OracleDataReader reader = con.SelectFromDatabase(Querry);
             Product product;
             while (reader.Read())
             {
                 product = new Product(reader.GetInt32(0), reader.GetString(1), reader.GetDecimal(2), reader.GetDecimal(3));
                 productList.Add(product);
             }

             reader.Dispose();

          return productList;
         }

         public override string ToString()
         {
             return iD_product + " " + product_name + " " + bail + " " + price; 
         }
    }
}
