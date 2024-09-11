using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public interface IFlyBehavior
    {
        // Интерфейс реализуется всеми классами.
        public void Fly();
    }
    public class FlyWithWings : IFlyBehavior
    {
        // Реализация поведения
        public void Fly()
        {
            Console.WriteLine("I'm flying!");
        }
    }
}
