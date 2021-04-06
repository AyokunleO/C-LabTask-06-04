using System;

namespace NovertisPharma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");

            Medicine medicine = new Medicine(5406, "Chloroquin", "Pfizer", 1000, 40, "23/04/1999", "23/04/2002", 234);
            Sales sales = new Sales(5455566, 20, 40, 20, "Lagos");

            Console.WriteLine($"{medicine.Print()}");
            Console.WriteLine($"{medicine.Print(5406)}");
            Console.WriteLine($"{medicine.Print(5405, "Chloroquin")}\n");


            Console.WriteLine($"{sales.Display()}");
            Console.WriteLine($"{sales.Display(5455556)}\n");

        }
    }
}
