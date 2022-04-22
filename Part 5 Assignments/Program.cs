using System;

namespace Part_5_Assignments
{
    class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            stages();
            hurricane();
            dice();
        }


        public static void stages()
        {

            int age;

            Console.WriteLine("Please enter age");
            age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
                Console.WriteLine("Adult");
            else if (age <= 5)
                Console.WriteLine("Toddler");
            else if (age <= 10)
                Console.WriteLine("Child");
            else if (age <= 12)
                Console.WriteLine("Preteen");
            else if (age > 12)
                Console.WriteLine("Teen");
        }

        public static void hurricane()
        {





            Console.WriteLine("Please enter a stage of hurricane from 1 to 5");
            int category = Convert.ToInt32(Console.ReadLine());
            switch (category)
            {
                case 1:
                    Console.WriteLine("Hurricane stage is 1. The wind speeds are about 74-95mph, 64-82kt, or 119-153km/h.");
                    break;
                case 2:
                    Console.WriteLine("Hurricane stage is 2. The wind speeds are about 96-110mph, 83-95kt, or 154-177km/h.");
                    break;
                case 3:
                    Console.WriteLine("Hurricane stage is 3. The wind speeds are about 111-130mph, 96-113kt, or 178-209km/h.");
                    break;
                case 4:
                    Console.WriteLine("Hurricane stage is 4. The wind speeds are about 131-155mph, 114-135kt, or 210-249km/h.");
                    break;
                case 5:
                    Console.WriteLine("Hurricane stage is 5. The wind speeds are greater than 155mph, 135kt, or 250km/h.");
                    break;
                default:
                    Console.WriteLine("Hurricane stage is not between 1 and 5.");
                    break;


            }
        }

        public static void dice()
        {
            Random generator = new Random();
            int dice1 = generator.Next(1, 7);
            int dice2 = generator.Next(1, 7);
            int money = 100;
            double bet;
            bool done = false;

            Console.WriteLine("Welcome to the dice game, where you can bet your money on 4 outcomes, Double, Not Double, Even Sum and Odd Sum.");
            Console.WriteLine(" Roll           Returns");
            Console.WriteLine(" Doubles        2x");
            Console.WriteLine(" Not Double     1.5x");
            Console.WriteLine(" Odd Sum        Your Bet");
            Console.WriteLine(" Even Sum       Your Bet");
            Console.WriteLine($"Your balance is: {money}$");
            Console.WriteLine("Enter your bet:");
            do
            {
                if (!Double.TryParse(Console.ReadLine(), out bet))
                {
                    Console.WriteLine("Not a valid input");
                }
                else if (bet < 0)
                    Console.WriteLine("No negatives");
                else if (bet > money)
                    Console.WriteLine("not enough money");
                else
                    done = true;
            } while (!done);
            Console.WriteLine("Please enter a valid bet");

            Console.WriteLine("Excellent, now enter what type of bet you would like to place:");
            Console.WriteLine("Enter a 1 for a Double bet");
            Console.WriteLine("Enter a 2 for a Not Double bet");
            Console.WriteLine("Enter a 3 for a Odd Sum bet");
            Console.WriteLine("Enter a 4 for a Even Sum bet");

            int outcome = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Nice, you rolled a {dice1} and a {dice2}");
            switch (outcome)
            {
                case 1:
                    if (dice1 == dice2)
                        Console.WriteLine($"Nice, your new account balance is {money + (bet * 2)}");
                    else
                        Console.WriteLine($"ahh shoot, your new account balance is {money - bet}");
                    break;
                case 2:
                    if (dice1 != dice2)
                        Console.WriteLine($"You have won your bet, your new account balance is {money + (bet * 1.5)}");
                    else
                        Console.WriteLine($"lost your bet. Your new account balance is {money - bet}. ");
                    break;
                case 3:
                    if (dice1 + dice2 == 3 || dice1 + dice2 == 5 || dice1 + dice2 == 7 || dice1 + dice2 == 9 || dice1 + dice2 == 11 || dice1 + dice2 == 1)
                        Console.WriteLine($"Nice, Your new account balance is {money + bet}.");
                    else
                        Console.WriteLine($"Too bad, your new account balance is {money - bet}.");
                    break;
                case 4:
                    if (dice1 + dice2 == 2 || dice1 + dice2 == 4 || dice1 + dice2 == 6 || dice1 + dice2 == 8 || dice1 + dice2 == 10 || dice1 + dice2 == 12)
                        Console.WriteLine($"Nice, Your new account balance is {money + bet}.");
                    else
                        Console.WriteLine($"You lost, your new account balance is {money - bet}.");
                    break;







            }
        }
    }
}    