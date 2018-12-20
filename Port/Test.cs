using System;
using Port.Interfaces;
using Port.Model;

namespace Port
{
    class Test
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Создаём порт Новороссийск");
            var novorossiysk = new Model.Port("Новороссийск", 1000);
            Console.WriteLine("Создаём порт Усть-Луга");
            var ustluga = new Model.Port("Усть-Луга", 2000);

            Console.WriteLine("Создаём дизельное топливо");
            var diesel = new Fuel(50);

            Console.WriteLine("Создаём грузы");
            var cargo1 = new Cargo(10000);
            var cargo2 = new Cargo(12000);
            var cargo3 = new Cargo(35000);
            var cargo4 = new Cargo(16000);
            var cargo5 = new Cargo(14000);
            var cargo6 = new Cargo(17000);
            var cargo7 = new Cargo(15000);
            var cargo8 = new Cargo(15000);

            Console.WriteLine("Создаём корабль Труженник");
            var worker = new Ship("Труженник", novorossiysk);
            Console.WriteLine("Заправляем Труженника");
            worker.Fill(diesel);
            Console.WriteLine("Загружаем Труженника");
            worker.Load(cargo1);
            worker.Load(cargo2);
            worker.Load(cargo3);
            worker.Load(cargo4);
            Console.WriteLine("Создаём маршрут для Труженника");
            var routeForWorker = new Route(ustluga);
            worker.AddRoute(routeForWorker);
            Console.WriteLine("Отправляем Труженника по маршруту");
            worker.Send();
            Console.WriteLine("Проверяем какие корабли находятся в порту Усть-Луга");
            Console.WriteLine(ustluga.InPort.ToString());

            Console.WriteLine("Создаём корабль Большой");
            var big = new Ship("Большой", ustluga);
            Console.WriteLine("Заправляем Большого");
            big.Fill(diesel);
            Console.WriteLine("Загружаем Большого");
            big.Load(cargo5);
            big.Load(cargo6);
            big.Load(cargo7);
            big.Load(cargo8);
            Console.WriteLine("Создаём маршрут для Большого");
            var routeForBig = new Route(novorossiysk);
            big.AddRoute(routeForBig);
            Console.WriteLine("Отправляем Большого по маршруту");
            big.Send();
            Console.WriteLine("Проверяем какие корабли находятся в порту Новороссийск");
            Console.WriteLine(novorossiysk.InPort.ToString());
        }
    }
}
