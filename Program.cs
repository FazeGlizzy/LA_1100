using System;
namespace Numberguessing
{
    class Generator
    {
        static void Main(string[] args)
        {

            int geschafft = 0;
            bool repeat = false;
            int i = 0;
            char[] letters = { ' ', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', };

            do
            {

                Random random = new Random();
                int b = random.Next(1, 26);

                Random Random = new Random();
                int randomNumber = Random.Next(1, 100);

                Console.WriteLine("Willst du Zahlen oder Buchstaben erraten? ");
                Console.WriteLine("[z/b]");
                char auswahl = Convert.ToChar(Console.ReadLine());

                if (auswahl == 'b')
                {


                    do
                    {


                        Console.WriteLine(letters[b]);

                        Console.WriteLine("Geben sie einen buchstaben ein ");
                        Char abc = Convert.ToChar(Console.ReadLine());

                        try
                        {

                            switch (abc)
                            {
                                case char n when (abc == letters[b]):
                                    i++;
                                    Console.WriteLine("Super sie haben den richtigen Buchstaben geraten!!");
                                    Console.WriteLine("Du hast " + i + " versuche gebraucht");

                                    geschafft = 1;
                                    break;
                                case char n when (b > 1):

                                    if (abc > letters[b])
                                    {
                                        Console.WriteLine("der Buchstabe ist zu gross");
                                        i++;
                                    }
                                    else if (abc < letters[b])
                                    {
                                        Console.WriteLine("Der Buchstabe ist zu klein");
                                        i++;
                                    }


                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }

                    } while (geschafft == 0);

                }
                else if (auswahl == 'z')
                {


                    do
                    {


                        Console.WriteLine(randomNumber);
                        Console.WriteLine("Geben sie bitte eine Zahl zwischen 1-100 ein: ");
                        int gerateneZahl = Convert.ToInt32(Console.ReadLine());

                        try
                        {

                            switch (gerateneZahl)
                            {
                                case int n when (n < 1):
                                case int m when (m > 100):
                                    Console.WriteLine("Ungültige Eingabe: Ihre Zahl befindet sich nicht zwischen 1-100!");
                                    i++;
                                    break;
                                case int n when (gerateneZahl == randomNumber):
                                    i++;
                                    Console.WriteLine("Super sie haben die richtige Nummer geraten!!");
                                    Console.WriteLine("Du hast " + i + " versuche gebraucht");

                                    geschafft = 1;
                                    break;
                                case int n when (gerateneZahl < 101 && gerateneZahl > 0):

                                    if (gerateneZahl > randomNumber)
                                    {
                                        Console.WriteLine("Die Zahl ist zu gross");
                                        i++;
                                    }
                                    else if (gerateneZahl < randomNumber)
                                    {
                                        Console.WriteLine("Die Zahl ist zu klein");
                                        i++;
                                    }


                                    break;
                            }

                        }
                        catch (Exception e)
                        {
                            Console.WriteLine(e.ToString());
                        }

                    } while (geschafft == 0);

                }
                geschafft = 0;
                Console.WriteLine("Wollen sie wiederholen? [true/false]");
                repeat = Convert.ToBoolean(Console.ReadLine());

            } while (repeat == true);
        }
    }
}
