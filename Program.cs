using System;

namespace ElizaIsSilly
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Doctor.Intro());

            var userInput = "";
            while (!userInput.Equals("quit", StringComparison.OrdinalIgnoreCase))
            {
                userInput = Console.ReadLine();
                string response = Doctor.response(userInput);
                Console.WriteLine(response);
            }
        }
    }
}