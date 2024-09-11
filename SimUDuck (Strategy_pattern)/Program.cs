using DuckProject;

namespace SimUDuck__Strategy_pattern_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Duck mallar = new MallarDuck();
            // Вызов метода унаследованный классом; 
            // Метод делегирует выполнение операции по ссылке на QuackBehavior(то есть вызывает Quack()
            // через унаследованную переменную quackBehavior)
            mallar.PerformQuack();
            mallar.PerformFly();

            Duck model = new ModelDuck();
            // Первый метод PerformFly() передается реализации, заданной в конструкторе ModelDuck, то есть экземпляру FlyNoWay
            model.PerformFly();
            // Вызывается set-метод унаследованный классом ModelDuck, и ... утка приманкавзлетает на реактивном двигателе
            model.SetFlyBehavior(new FlyRocketPowered());
            // Способности утки приманки к полету переключается динамически!
            // Если бы реализация находилась в иерархии Duck, ТАКОЕ было бы невозможно.
            model.PerformFly();
        }
    }
}
