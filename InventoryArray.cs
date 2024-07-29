using System;
namespace TestProject
{
    public class InventoryArray
    {
        public static void LearnArray()
        {
            int[] inventory = { 200, 450, 700, 175, 250 };
            int sum = 0;
            int bin = 0;
         foreach(int items in inventory)
         {
            sum += items;
            bin ++;
            Console.WriteLine($"Bin {bin} We have {items} items in inventory.");
         }

            Console.WriteLine($" We have {sum} items in inventory.");
        }
    }
}