using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public interface IFactoryMethodProduct
    {
        string productName { get; set; }
        string GetProductDetails();
    }

    public class FirstFactoryMethodProduct : IFactoryMethodProduct
    {
        public FirstFactoryMethodProduct()
        {
            this.productName = "First Product from Factory Method";
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

    public class SecondFactoryMethodProduct : IFactoryMethodProduct
    {
        public SecondFactoryMethodProduct()
        {
            this.productName = "Second Product from Factory Method";
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

    interface IProductFMFactory
    {
        IFactoryMethodProduct GetProduct();
    }

    public class FirstProductFactory : IProductFMFactory
    {
        public IFactoryMethodProduct GetProduct()
        {
            return new FirstFactoryMethodProduct();
        }
    }

    public class SecondProductFactory : IProductFMFactory
    {
        public IFactoryMethodProduct GetProduct()
        {
            return new SecondFactoryMethodProduct();
        }
    }
}
