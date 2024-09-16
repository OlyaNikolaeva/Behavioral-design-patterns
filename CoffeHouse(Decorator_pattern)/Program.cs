using System.ComponentModel;

namespace CoffeHouse_Decorator_pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
    }
    public abstract class Beverage 
    {
        public string Description = "Unknow beverage";

        public string GetDscription()
        { 
            return Description; 
        }
        public abstract double Cost();
    }

    public abstract class CondimentDecorator : Beverage
    {
        Beverage? beverage;
        public abstract string GetDescription();
    }

    public class Espresso : Beverage
    {
        public Espresso()
        {
            Description = "Espresso";
        }
        public override double Cost()
        {
            return 1.99;
        }
    }
}
