using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NätKärlek
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.BackgroundColor = ConsoleColor.White;
                Console.WriteLine("Vad heter du vännen?");
                string namn = Console.ReadLine();
                string[] m = new string[10];
                m[0] = "Du är älskad, " + namn;
                m[1] = "Du är fantastisk, " + namn;
                m[2] = "Du är vacker, " + namn;
                m[3] = "Idag är du bäst, " + namn;
                m[4] = "Du förtjänar en kram, " + namn;
                m[5] = "Jag älskar dig, " + namn;
                m[6] = "Ingen är lika bra som du, " + namn;
                m[7] = "Du är otroligt smart, " + namn;
                m[8] = "Iley gillar dig, " + namn;
                m[9] = "Du är perfekt som du är, " + namn;
                int i = rnd.Next(0, 10);
                if (true)
                {
                    Console.WriteLine(m[i]);
                }
                char o = 'o';
                Console.WriteLine("  " + o + o + o + "   " + o + o + o);
                Console.WriteLine(" " + o + "   " + o + " " + o + "   " + o);
                Console.WriteLine(o + "     " + o + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(o + "     " + " " + "     " + o);
                Console.WriteLine(" " + o + "    " + "     " + o);
                Console.WriteLine("  " + o + "   " + "    " + o);
                Console.WriteLine("   " + o + "  " + "   " + o);
                Console.WriteLine("    " + o + "  " + " " + o);
                Console.WriteLine("     " + o + " " + o);
                Console.WriteLine("      " + o);
                Console.WriteLine("");
                Console.WriteLine("Tänk på att sprida kärlek när du är på nätet!");
                System.Threading.Thread.Sleep(6000);
                Console.Clear();
                Console.WriteLine("Hej, tryck på valfri knapp");
                //Tryck på escape tre gånger för att exita programmet, efter meddelande har skickats:)
                if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                {
                    if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                    {
                        if (Console.ReadKey(true).Key == ConsoleKey.Escape)
                        {
                            break;
                        }
                    }
                }

            }
        }
    }
}
