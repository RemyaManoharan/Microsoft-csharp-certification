using System;
namespace TestProject
{
    public class InventoryArray
    {
        public static void LearnArray()
        {
            //     int[] inventory = { 200, 450, 700, 175, 250 };
            //     int sum = 0;
            //     int bin = 0;
            //  foreach(int items in inventory)
            //  {
            //     sum += items;
            //     bin ++;
            //     Console.WriteLine($"Bin {bin} We have {items} items in inventory.");
            //  }

            //     Console.WriteLine($" We have {sum} items in inventory.");

            // string value = "abc123";
            // char[] valueArray = value.ToCharArray();
            // Array.Reverse(valueArray);
            // // string result = new string(valueArray);
            // string result = String.Join(",", valueArray);
            // Console.WriteLine(result);

            // string[] items = result.Split(',');
            // foreach (string item in items)
            // {
            //     Console.WriteLine(item);
            // }

            string pangram = "The quick brown fox jumps over the lazy dog";

            string[] message = pangram.Split(' ');
            //This line splits the pangram string into individual words based on spaces (' '). The Split method returns an array of strings where each element is a word from the original sentence.
            //Example output of message would be: ["The", "quick", "brown", "fox", "jumps", "over", "the", "lazy", "dog"].
             
             // Step 3 This creates a new array of strings called newMessage, with the same length as the message array. This array will hold the reversed words.
            string[] newMessage = new string[message.Length];
            
           //This is the beginning of a loop that will iterate over each word in the message array. The loop will run from i = 0 to i = message.Length - 1.
            for (int i = 0; i < message.Length; i++)
            {
                char[] letters = message[i].ToCharArray(); // Inside the loop, this line converts the current word (message[i]) into a character array. For example, if message[i] is "The", letters will be ['T', 'h', 'e'].
                Array.Reverse(letters); //This line reverses the order of the characters in the letters array. For example, if letters was ['T', 'h', 'e'], after this operation it would become ['e', 'h', 'T'].
                newMessage[i] = new string(letters);
            }
            //After the loop finishes, this line joins all the reversed words in the newMessage array into a single string, with a space (" ") between each word. 
            //The String.Join method combines the array elements into one string.
            string result = String.Join(" ", newMessage);
            Console.WriteLine(result);

        }
    }
}