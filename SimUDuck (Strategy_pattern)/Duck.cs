using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DuckProject
{
    public abstract class Duck
    {
        // Две ссылочные переменные с типами интерфейсов поведения.
        // Переменные наследуются всеми субклассами Duck.
        public IFlyBehavior? flyBehavior;
        public IQuackBehavior? quackBehavior;

        public Duck()
        { }

        public abstract void Display();
        public void PerformFly()
        {
            // Делегирование операции классам поведения
            flyBehavior?.Fly();
        }
        public void PerformQuack()
        {
            // Делегирование операции классам поведения
            quackBehavior?.Quack();
        }

        public void Swim()
        {
            Console.WriteLine("All ducks float, even decoys");
        }

        public void SetFlyBehavior(IFlyBehavior fb)
        {
            flyBehavior = fb;
        }

        public void SetQuackBehavior(IQuackBehavior qb)
        {
            quackBehavior = qb;
        }
    }
}
