using System;

namespace Kolo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double promień;
            Console.WriteLine("Podaj promień :");
            var linia = Console.ReadLine();

            promień = Convert.ToDouble(linia);
            var pole = Math.PI * promień * promień;
            var obwód = Math.PI * 2.0 * promień;

            Console.WriteLine("Pole koła o promieniu " + promień + " wynosi " + pole);
            Console.WriteLine($"Obwód koła o promieniu {promień} wynosi {obwód}");
        }
    }
}
