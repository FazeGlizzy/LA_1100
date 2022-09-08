using System;
namespace Numberguessing
{
    class Generator
    {
        static void Main(string[] args)
        {

            int geschafft = 0;
            string gerateneZahl1;
            bool repeat = false;
            int i = 0;

            do
            {

                Console.WriteLine("Wollen wir beginnen? ");
                Console.WriteLine("True/False");

                Random random = new Random();
                int randomNumber = random.Next(1, 100);

                bool spielbereit = Convert.ToBoolean(Console.ReadLine());
                if (spielbereit == false)
                {
                    Console.Write(" ");
                }
                else
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
                Console.WriteLine("Wollen sie wiederholen? [true/false]");
                repeat = Convert.ToBoolean(Console.ReadLine());

            } while (repeat == true);
        }
    }
}