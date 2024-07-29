using System;
using System.Data.Common;
namespace TestProject
{
    public class Excercise3
    {
        public static void FraudFinder()
        {
            // string[] orderIds ={"B123","C234","A345","C15","B177","G3003","C235","B179"};
            // foreach (string orderid in orderIds)
            // {
            //     if(orderid.StartsWith("B"))
            //     {
            //         Console.WriteLine($"Suspicious order found: {orderid}");
            //     }
            // }
            string str ="The quick brown fox jumps over the lazy dog.";
            char[] charMessage = str.ToCharArray();
            Array.Reverse(charMessage);
            Console.WriteLine(charMessage); 
        }
    }
}