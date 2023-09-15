using System;
namespace Uppgift2_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //frågar efter bok
            Console.WriteLine("Vad har du för favoritbok?");
            string book = Console.ReadLine();

            //Skriver ut boken
            Console.WriteLine($"Din favoritbok heter {book}.");
          
            Console.ReadKey();
        }
    }
}
