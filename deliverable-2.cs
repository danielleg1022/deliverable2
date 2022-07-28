using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hi! Welcome to our flavorable buffet. All you can eat for 9.99!. We only charge extra for Pepsi. How many people are in your group? Please, parties of 6 or lower.");

        int num1 = int.Parse(Console.ReadLine());

        if (num1 > 6)
        {
            Console.WriteLine("Oh sorry, we can only seat parties up to 6. HAve a nice day."); return;


        }

        else if (num1 < 6)

        {
            Console.WriteLine("A table for " + (num1) + "!Please follow me and take a seat. Let's get everyone started with some drinks. We've got water or Pepsi.");

        }





        double drink = 3.00;
        double buffet = 9.99 * num1;
        double pepsi = 0;
        int water = 0;
        char symbol = '$';


        for (int i = 1; i <= num1; i++)

        {

            Console.WriteLine(" \n Alright, person number " + (i) + " water or Pepsi? \n");
            string response = (Console.ReadLine());





            {

            }

            if (response == "water")
            {
                Console.WriteLine("water, good choice! \n");
                water++;



            }



            else if (response == "pepsi")
            {
                Console.WriteLine("Pepsi, ok! \n", drink * num1);
                pepsi++;

            }

            else
            {
                Console.WriteLine("We dont have that. Nothing for you!");


            }







        }

        Console.WriteLine("Okay, so that's " + pepsi + " pepsi's and " + water + " waters, I'll be right back. Feel free to grab your food!");
        Console.WriteLine("Here's your bill! Total price:" + symbol + (double)(buffet + drink * num1));
        {

        }
    }
}
