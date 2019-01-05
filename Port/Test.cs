using System;
using Port.Model;

namespace Port
{
    public class Test
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
            var cargo1 = new Cargo(100000);
            var cargo2 = new Cargo(120000);
            var cargo3 = new Cargo(350000);
            var cargo4 = new Cargo(160000);
            var cargo5 = new Cargo(140000);
            var cargo6 = new Cargo(170000);
            var cargo7 = new Cargo(150000);
            var cargo8 = new Cargo(150000);

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
            worker.SetRoute(routeForWorker);
            Console.WriteLine("Отправляем Труженника по маршруту");
            try
            {
                worker.Send();
                Console.WriteLine("Проверяем какие корабли находятся в порту Усть-Луга");
                foreach (var s in ustluga.InPort)
                {
                    Console.WriteLine(s.Title);
                }
                Console.WriteLine("Выводим стоимости маршрутов корабля Труженник");
                foreach (var r in worker.Routes)
                {
                    Console.WriteLine($"{r.Departure.Title}-{r.Arrival.Title} стоимость {r.Costs}");
                    Console.WriteLine($"Стоимость грузов {r.Sums}");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("Создаём корабль Большой");
            var big = new Ship("Большой", ustluga);
            /*Console.WriteLine("Заправляем Большого");
            big.Fill(diesel);*/
            Console.WriteLine("Загружаем Большого");
            big.Load(cargo5);
            big.Load(cargo6);
            big.Load(cargo7);
            big.Load(cargo8);
            Console.WriteLine("Создаём маршрут для Большого");
            var routeForBig = new Route(novorossiysk);
            big.SetRoute(routeForBig);
            Console.WriteLine("Отправляем Большого по маршруту");            
            try
            {
                big.Send();
                Console.WriteLine("Проверяем какие корабли находятся в порту Новороссийск");
                foreach (var s in novorossiysk.InPort)
                {
                    Console.WriteLine(s.Title);
                }
                Console.WriteLine("Выводим стоимости маршрутов корабля Большой");
                foreach (var r in big.Routes)
                {
                    Console.WriteLine($"{r.Departure.Title}-{r.Arrival.Title} стоимость {r.Costs}");
                    Console.WriteLine($"Стоимость грузов {r.Sums}");
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }            
        }
    }
}
