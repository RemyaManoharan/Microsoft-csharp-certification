using System;

namespace TestProject
{
    public class TypeConverter
    {
        public static void SchoolData()
        {
            // int value = (int)1.5m; // casting truncates 1
            // Console.WriteLine(value);

            // int value2 = Convert.ToInt32(1.5m); // converting rounds up 2
            // Console.WriteLine(value2);
            // string[] values = { "12.3", "45", "ABC", "11", "DEF" };

            // decimal total = 0m;
            // string message = "";

            // foreach (var value in values)
            // {
            //     decimal number; // stores the TryParse "out" value
            //     if (decimal.TryParse(value, out number))
            //     {
            //         total += number;
            //     }
            //     else
            //     {
            //         message += value;
            //     }
            // }

            // Console.WriteLine($"Message: {message}");
            // Console.WriteLine($"Total: {total}");
            string[] pallets = { "B14", "A11", "B12", "A13" };

            Console.WriteLine("Sorted...");
            Array.Sort(pallets);
            foreach (var pallet in pallets)
            {
                Console.WriteLine($"-- {pallet}");
            }





        }
    }
}