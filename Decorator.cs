using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    public interface IProp
    {
        int price();
    }

    public class NormalProp : IProp
    {
        public int Price = 10;
        public int price()
        {
            return this.Price;
        }
    }

    public class FancyProp : IProp
    {
        public int Price = 50;
        public int price()
        {
            return this.Price;
        }
    }

    public abstract class Decorator : IProp
    {
        IProp prop = null;
        public Decorator(IProp prop)
        {
            this.prop = prop;
        }
        public abstract int DecoratorPrice();
        public int price()
        {
            return prop.price() + DecoratorPrice();
        }
    }

    public class PictureDecorator: Decorator
    {
        public PictureDecorator(IProp prop):base(prop)
        {

        }
        public override int DecoratorPrice()
        {
            return 100;
        }
    }

    public class ColoursDecorator : Decorator
    {

        public ColoursDecorator(IProp prop):base(prop)
        {
        }

        public override int DecoratorPrice()
        {
            return 200;
        }
    }
}
