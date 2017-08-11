using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public interface IProduct
    {
        string productName { get; set; }
        string GetProductDetails();
    }

    public class FirstProduct : IProduct
    {
        public FirstProduct()
        {
            this.productName = "First Product";
        }
        public string productName
        {
            get;set;
        }

        public string GetProductDetails()
        {
            return this.productName;
        }
    }

    public class SecondProduct : IProduct
    {
        public SecondProduct()
        {
            this.productName = "Second product";
        }
        public string productName
        {
            get; set;
        }

        public string GetProductDetails()
        {
            return this.productName;
        }
    }


    public class SimpleFactory
    {
        public static IProduct GetProduct(int type)
        {
            IProduct product = null;
            switch(type)
            {
                case 1:
                    product = new FirstProduct();
                    break;
                case 2:
                    product = new SecondProduct();
                    break;

            }
            return product;
        }
    }
}
