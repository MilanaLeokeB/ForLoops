using System;

namespace HEI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(" enter some text:");
            string userInput = Console.ReadLine();
            char searchCriteria = 'a';
            int counter = 0;
            for (int i = 0; i < userInput.Length; i++)
            {
                if (userInput.ToLower()[1] == searchCriteria)
                {
                    counter = counter + 1;
                }
               
            }

            if (counter > 0)
            {
                Console.WriteLine($"There are {counter} a's in your text");
            }
            else
            {
                Console.WriteLine($"There are no a´s in your text");
            }
        }
    }
}
