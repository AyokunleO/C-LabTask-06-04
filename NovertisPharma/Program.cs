using System;

namespace NovertisPharma
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            Date date = new Date (7,4,2025);

            Medicine medicine = new Medicine(5406, "Chloroquin", "Pfizer", 1000, 40, new Date(7,4,2021), date, 234);
            Sales sales = new Sales(5455566, 20, 40, 20, "Lagos");

            Console.WriteLine($"{medicine.Print()}");
            Console.WriteLine($"{medicine.Print(5406)}");
            Console.WriteLine($"{medicine.Print(5405, "Chloroquin")}\n");
            Console.WriteLine($"The Stock Quantity is{medicine.IncreaseStock(50)}");


            Console.WriteLine($"{sales.Display()}");
            Console.WriteLine($"{sales.Display(5455556)}\n");

        }
    }
}
