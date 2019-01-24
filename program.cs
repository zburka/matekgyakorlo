using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Matekgyakorlo
{
    class Program
    {
        
    public static void Main(string[] args)

        {
            Console.ForegroundColor = ConsoleColor.White;
            Random numberGenerator = new Random();
            string nev;
            Int32 menuID;
            string UserInput;

            Console.WriteLine("Matekgyakorló program 1.0\n" +
                "Írta: Burka Zoltán\n\n");

            Console.WriteLine("Szia, hogy hívnak?");

            nev = Convert.ToString(Console.ReadLine());

            Console.WriteLine($"\n\nSzia {nev}!\n\n" +
                $"Válassz a listából, hogy mit szeretnél gyakorolni. Írd be a sorszámát.");

            Choose:
            Console.WriteLine(
                                    "1: Összeadás\n" +
                                    "2: Kivonás\n" +
                                    "3: Szorzás\n");

            menuID = Convert.ToInt32(Console.ReadLine());

            if (
                menuID.Equals(1)
                )
            {
                goto Menu1;
            }

            else if
                (
                menuID.Equals(2)
                )
            {
                goto Menu2;
            }
            else if
                (
                menuID.Equals(3)
                )
            {
                goto Menu3;
            }


        Menu1:;

            Console.WriteLine("\nÖsszeadás gyakorlása. Ha kezdhetjük, nyomj le egy gombot.");
            Console.ReadKey();
        
            Menu1Start:

            int num01 = numberGenerator.Next(1, 51);
            int num02 = numberGenerator.Next(1, 51);

        retry1:;
            Console.WriteLine($"Mennyi {num01} + {num02} ?");
        
            UserInput = Console.ReadLine();
            int TheNumber;

                if (
                    int.TryParse(UserInput, out TheNumber)
                    );

                    else {
                            Console.WriteLine("\nEz egy betű. Számot kell megadnod.\n");
                            Console.Beep();
                goto retry1;

            };

            if (TheNumber == num01 + num02)
            {
                Console.WriteLine("\nÜgyes vagy! Itt a következő: \n");
                goto Menu1Start;
            }

            else
            {
                Console.Beep();
                Console.WriteLine($"\nSajnos ez helytelen. Próbáld újra! \n");
                goto retry1;
            };
            

        /////////////// MENÜ 2 - KIVONÁS ///////////////
        
        Menu2:;

            Console.WriteLine("\nKivonás gyakorlása. Ha kezdhetjük, nyomj le egy gombot.");
            Console.ReadKey();

        Menu2Start:

            int num03 = numberGenerator.Next(1, 51);
            int num04 = numberGenerator.Next(1, 51);

        retry2:
            Console.WriteLine($"Mennyi {num03} - {num04} ?");
            UserInput = Console.ReadLine();
            int TheNumber2;
            if (
                int.TryParse(UserInput, out TheNumber2)

                );

            else
            {
                Console.WriteLine("\nEz egy betű. Számot kell megadnod.\n");
                Console.Beep();
                goto retry2;

            };

            if (TheNumber2 == num03 - num04)
            {
                Console.WriteLine("\nÜgyes vagy! Itt a következő: \n");
                goto Menu2Start;
            }

            else
            {
                Console.Beep();
                Console.WriteLine($"\nSajnos ez helytelen. Próbáld újra! \n");
                goto retry2;
            };

        /////////////// MENÜ 3 - Szorzás ///////////////

        Menu3:;

            Console.WriteLine("\nSzorzás gyakorlása. Ha kezdhetjük, nyomj le egy gombot.");
            Console.ReadKey();

        Menu3Start:

            int num05 = numberGenerator.Next(1, 51);
            int num06 = numberGenerator.Next(1, 51);

        retry3:
            Console.WriteLine($"Mennyi {num05} * {num06} ?");
            UserInput = Console.ReadLine();
            int TheNumber3;
            if (
                int.TryParse(UserInput, out TheNumber3)

                );

            else
            {
                Console.WriteLine("\nEz egy betű. Számot kell megadnod.\n");
                Console.Beep();
                goto retry3;

            };

            if (TheNumber3 == num05 * num06)
            {
                Console.WriteLine("\nÜgyes vagy! Itt a következő: \n");
                goto Menu3Start;
            }

            else
            {
                Console.Beep();
                Console.WriteLine($"\nSajnos ez helytelen. Próbáld újra! \n");
                goto retry3;
            };


        }
    
    }
}
