using System;

namespace ConversorTemperaturas
{
    class Program
    {
        static void Main(string[] args)
        {
            double tempC, tempF, tempK;

            Console.WriteLine("\t### Conversor de Temperaturas ###\n");

            Console.Write(" Temperatura em °C: ");
            tempC = Convert.ToDouble(Console.ReadLine());

            //C to F:
            tempF = (tempC * 9 / 5) + 32;

            //C to K:
            tempK = tempC + 273.15;

            Console.WriteLine("\n " + tempC + "°C = " + tempF + "°F");
            Console.WriteLine(" " + tempC + "°C = " + tempK + "°K");

            Console.ReadKey();
        }
    }
}
