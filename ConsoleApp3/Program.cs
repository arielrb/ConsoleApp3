using System;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesayunoAsync
{
    // These classes are intentionally empty for the purpose of this example. They are simply marker classes for the purpose of demonstration, contain no properties, and serve no other purpose.
    internal class Bacon { }
    internal class Mate { }
    internal class Huevos { }
    internal class Juguito { }
    internal class Tostada { }

    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();
            sw.Start();
            Mate mate = CebarMate();
            Console.WriteLine("Mates cebados");

            Huevos huevos = SaltearHuevos(2);
            Console.WriteLine("huevos listos");

            Bacon bacon = FreirBacon(3);
            Console.WriteLine("bacon is Listorti");

            Tostada Tostada= TostarPan(2);
            Mantecar(Tostada);
            PonerDulce(Tostada);
            Console.WriteLine("Listorti las tostadas");

            Juguito jugo= ServirJugo();
            Console.WriteLine("Juguito Listo!");
            Console.WriteLine("Desayuno Listorti!");
            sw.Stop();
            Console.WriteLine($"El desayuno demoró {sw.Elapsed.TotalSeconds}");
            Console.WriteLine("A comer!");
        }

        private static Juguito ServirJugo()
        {
            Console.WriteLine("Sirviendo jugo de manzana..");
            return new Juguito();
        }

        private static void PonerDulce(Tostada toast) =>
            Console.WriteLine("Poniendole dulce a la tostaruli");

        private static void Mantecar(Tostada toast) =>
            Console.WriteLine("Mantecando la tostada");

        private static Tostada TostarPan(int rebanadas)
        {
            for (int cacho = 0; cacho < rebanadas; cacho++)
            {
                Console.WriteLine("Poner a tostar pancitos");
            }
            Console.WriteLine("Tostando...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Sacar pan de la tostadora");

            return new Tostada();
        }

        private static Bacon FreirBacon(int cachos)
        {
            Console.WriteLine($"Poniendo {cachos} slices of bacon in the pan");
            Console.WriteLine("Cocinando el cacho...");
            Task.Delay(3000).Wait();
            for (int cachito = 0; cachito < cachos; cachito++)
            {
                Console.WriteLine("TSSSSSSSS... ");
            }
            Console.WriteLine("Cocinando el otro lado...");
            Task.Delay(3000).Wait();
            Console.WriteLine("Poner Bacon en el plato");

            return new Bacon();
        }

        private static Huevos SaltearHuevos(int cantidad)
        {
            Console.WriteLine("Calentando sarten...");
            Task.Delay(3000).Wait();
            Console.WriteLine($"rompiendo {cantidad} huevos");
            Console.WriteLine("Cocinando huevos ...");
            Task.Delay(3000).Wait();
            Console.WriteLine("servir huevos");

            return new Huevos();
        }

        private static Mate CebarMate()
        {
            Console.WriteLine("Cebando unos Leo Mattioli");
            return new Mate();
        }
    }
}