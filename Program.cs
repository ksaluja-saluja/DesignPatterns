using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Simple Factory
            IProduct product = SimpleFactory.GetProduct(1);
            Console.WriteLine("Product name is " + product.productName);
            product = SimpleFactory.GetProduct(2);
            Console.WriteLine("Product name is " + product.productName);
            

            //Factory Method
            IProductFMFactory factory = new FirstProductFactory();
            IFactoryMethodProduct prd = factory.GetProduct();
            Console.WriteLine("Product name is " + prd.productName);
            factory = new SecondProductFactory();
            prd = factory.GetProduct();
            Console.WriteLine("Product name is " + prd.productName);

            

            //Builder 
            var packageDirector = new PackageDirector(new NormalPackageBuilder());
            var pacakge = packageDirector.GetPackage();
            Console.WriteLine("Package " + pacakge.GetDetails()); ;

            packageDirector = new PackageDirector(new EcoPackageBuilder());
            pacakge = packageDirector.GetPackage();
            Console.WriteLine("Package " + pacakge.GetDetails()); ;

            packageDirector = new PackageDirector(new DeluxPackageBuilder());
            pacakge = packageDirector.GetPackage();
            Console.WriteLine("Package " + pacakge.GetDetails()); ;

            //Observer
            var pub = new ConsoleApplication3.Publisher();
            var sub1 = new ConsoleApplication3.Subscriber { name = "Subscriber 1" };
            var sub2 = new ConsoleApplication3.Subscriber { name = "Subscriber 2" };
            var sub3 = new ConsoleApplication3.Subscriber { name = "Subscriber 3" };
            pub.AddSubscriber(sub1);
            pub.AddSubscriber(sub2);
            pub.AddSubscriber(sub3);
            pub.Notify();
            pub.RemoveSubscriber(sub2);
            pub.Notify();

            //Template Method
            ConnectionManager cn = new SqlServerConnectionManager();
            cn.Connect();
            cn = new OracleConnectionManager();
            cn.Connect();

            //Strategy 
            var robot = new Robot(new CanTalkInEnglish());
            robot.DisplayFeatures();
            robot = new Robot(new CanTalkInFrench());
            robot.DisplayFeatures();
            robot = new Robot(new CanNotTalk());
            robot.DisplayFeatures();

            //Decorator

            IProp prop = new NormalProp();
            Decorator decorator = new PictureDecorator(prop);
            Console.WriteLine("Price is " + decorator.price());

            prop = new FancyProp();
            decorator = new PictureDecorator(prop);
            Console.WriteLine("Price is " + decorator.price());
            Console.ReadLine();

        }
    }
}
