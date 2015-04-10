﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ICT4Events
{
    //teun van der wijst
    public class Borrow
    {
        private int ID_borrow;
        private DateTime hire_date;
        private DateTime return_date;
        private DateTime returned_date;
        private List<Product> products = new List<Product>();

        public List<Product> Products
        {
            get { return products; }
            set { products = value; }
        }

        public DateTime Returned_Date
        {
            get { return returned_date; }
            set { returned_date = value; }
        }
        

        public DateTime Return_Date
        {
            get { return return_date; }
            set { return_date = value; }
        }
        

        public DateTime Hire_Date
        {
            get { return hire_date; }
            set { hire_date = value; }
        }
        
        public int ID_Borrow
        {
            get { return ID_borrow; }
            set { ID_borrow = value; }
        }
        
        public Borrow(DateTime hire_date, DateTime return_date)
        {
            ID_borrow += 1;
            this.hire_date = hire_date;
            this.return_date = return_date;
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }

        public void RemoveProduct(Product product)
        {
            products.Remove(product);
        }

        public decimal GetTotalPrice()
        {
            decimal a = 0;

            foreach(Product product in products)
            {
                a += product.Price;
                a += product.Bail;
            }

            return a;
        }
    }
}
