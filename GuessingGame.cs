using System.ComponentModel.Design;

internal class Game
{
    static void Main(string[] args)
    {
        int depo = 1000;
        int wins = 0;
        int losses = 0;
        int guess = 0;
        bool retry = true;
        int tries = 0;
        bool work = true;
        Console.WriteLine("Hello user!");
        while (work)
        {
            Console.WriteLine(@"What do you want to do?
Play
Stats
Exit
");
        string cmd = Console.ReadLine();
        
            if (cmd.ToLower().Equals("play"))
            {
                Console.WriteLine("""
                Loading ....
                .
                .
                .
                .
                """);
                Console.WriteLine("""Game rules: You have 1000$ each tries cost 200$""");
                do
                {
                    Random rnd = new Random();
                    int right_num = rnd.Next(1, 100);
                    if (depo <=0)
                    {
                        Console.WriteLine(@"Not enough money!


Resetting
.
.
.
.

");
                        break;
                    }    
                    tries++;
                    for (int i = 0; i < 5; i++)
                    {
                        Console.Write("Your guess: ");
                        guess = int.Parse(Console.ReadLine());
                        if (guess == right_num)
                        {
                            Console.WriteLine("That's the right number" + "  " + "You've won!");
                            depo += 200;
                            wins++;
                            break;
                        }
                        else
                        {
                            if (i == 4)
                            {
                                Console.WriteLine("You've lost!");
                                losses++;
                                depo -= 200;
                                Console.WriteLine($"The right number is {right_num}");
                                break;
                            }
                            else if (guess > right_num)
                                Console.WriteLine("Your guess number is bigger than the right one! ");
                            else if (guess < right_num)
                                Console.WriteLine("Your guess number is less than the right one! ");
                        }

                    }
                    Console.Write("Do you wish to continue? Y/N ");
                    string ans = Console.ReadLine();
                    if (ans.ToLower().Equals("n"))
                    {
                        Console.WriteLine("\r\n");
                        retry = false;

                    }

                } while (retry);

            }
            else if (cmd.ToLower().Equals("stats"))
            {
                Console.WriteLine($"""
                Tries: {tries}
                Wins: {wins}
                Lose: {losses}
                Deposit: {depo}
                """);
            }
            else if (cmd.ToLower().Equals("exit"))
            {
                Console.WriteLine("See you again!");
                break;
            }
            else
            { Console.WriteLine("I don't understand that! "); }
        }
    }

}
 