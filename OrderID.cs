using System;

namespace TestProject
{
    public class OrderID
    {
        public static void GetOrderID()
        {
            string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";
            string[] OrderIDs = orderStream.Split(',');
            Array.Sort(OrderIDs);


            foreach (string orderid in OrderIDs)
            {
                if (orderid.Length == 4)
                {
                    Console.WriteLine(orderid);
                }
                else
                {
                    Console.WriteLine(orderid + "\t - Error");
                }

            }


        }
    }
}