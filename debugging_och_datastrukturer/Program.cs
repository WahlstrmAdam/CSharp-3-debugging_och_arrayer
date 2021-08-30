using System;
using KataSolutions;

namespace ConsoleApp
{
    class Program
    {
        // TODO övning i att separera logik (kod och data) från UI (konsollappen)

        // Skriv om Main så att den kallar på ShapePainter.MakeSquare() som bygger en färdig figur
        // Console klassen ska bara användas i Main. Inget Console användande ska behövas i ShapePainter.MakeSquare()

        // Utgå från koden nedan (Tack Kim!) eller använd tidigare egen kata-lösning
        static void Main(string[] args)
        {
            bool programRun = true;
            while (programRun)
            {
                Console.Write("Type a whole number: ");
                int num = int.Parse(Console.ReadLine());

                for (int y = 0; y < num; y++)
                {
                    for (int x = 0; x < num; x++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }

                Console.WriteLine("Press Enter to continue or Escape to exit program");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                {
                    programRun = false;
                }
                Console.Clear();
            }
        }
    }
}
