using ArenaGame;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Hero p1; Hero p2;

            while (true)
            {
                Console.WriteLine("Player 1 - Pick a champion: ");
                Console.WriteLine("1. Knight");
                Console.WriteLine("2. Rogue");
                Console.WriteLine("3. Archer");
                Console.WriteLine("4. Hunter");

                Console.Write("Number(1-4): ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (choice == 1)
                {
                    p1 = new Knight(name); break;
                }
                else if (choice == 2)
                {
                    p1 = new Rogue(name); break;
                }
                else if (choice == 3)
                {
                    p1 = new Archer(name); break;
                }
                else if (choice == 4)
                {
                    p1 = new Hunter(name); break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            while (true)
            {
                Console.WriteLine("\nPlayer 2 - Pick a champion: ");
                Console.WriteLine("1. Knight");
                Console.WriteLine("2. Rogue");
                Console.WriteLine("3. Archer");
                Console.WriteLine("4. Hunter");

                Console.Write("Number(1-4): ");
                int choice = int.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();

                if (choice == 1)
                {
                    p2 = new Knight(name); break;
                }
                else if (choice == 2)
                {
                    p2 = new Rogue(name); break;
                }
                else if (choice == 3)
                {
                    p2 = new Archer(name); break;
                }
                else if (choice == 4)
                {
                    p2 = new Hunter(name); break;
                }
                else
                {
                    Console.WriteLine("Invalid number!");
                }
            }

            Console.Write("\nEnter number of battles: ");
            int rounds = int.Parse(Console.ReadLine());
            int oneWins = 0, twoWins = 0;

            for (int i = 0; i < rounds; i++)
            {
                Console.WriteLine($"Arena fight between: {p1.Name} and {p2.Name}");
                Arena arena = new Arena(p1, p2);
                Hero winner = arena.Battle();
                Console.WriteLine($"Winner is: {winner.Name}");
                if (winner == p1) oneWins++; else twoWins++;
            }
            Console.WriteLine();
            Console.WriteLine($"{p1.Name} has {oneWins} wins.");
            Console.WriteLine($"{p2.Name} has {twoWins} wins.");

            Console.ReadLine();

        }
    }
}
