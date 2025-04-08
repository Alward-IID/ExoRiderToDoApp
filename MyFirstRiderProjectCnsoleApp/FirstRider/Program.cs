using System;
using System.Runtime.InteropServices.JavaScript;

namespace FirstRider;

internal class Program
{
    static void Main(string[] args)
    {
        StickGame();
        
        /* begin exo 2
        float price = 0.2f;
        int[] coins = {200, 100, 50, 20, 10, 5, 2, 1};
        int[] numCoins = {0, 0, 0, 0, 0, 0, 0, 0};

        Console.WriteLine("Entre un nombre en euro");
        String input = Console.ReadLine();
        float.TryParse(input, out price);
        price = MathF.Round(price, 2) * 100;

        for (int i = 0; i < coins.Length; i++)
        {
            numCoins[i] = (int)price / coins[i];
            price = price - numCoins[i]*coins[i];
        }

        for (int i = 0; i < coins.Length; i++)
        {
            Console.WriteLine($"{coins[i]} centimes : {numCoins[i]}");
        }
         end exo 2 */
        /*
        float price = 0.2f;
        int euro = 0;
        int centime = 0;
        int amount2E = 0;
        int amount1E = 0;
        int amount50c = 0;
        int amount20c = 0;
        int amount10c = 0;
        int amount5c = 0;
        int amount2c = 0;
        int amount1c = 0;

        Console.WriteLine("Entre un prix en euros");
        string input = Console.ReadLine();
        float.TryParse(input, out price);
        if (price >= 2)
        {
            amount2E = (int)price / 2;
            price = price - (amount2E * 2);
        }

        if (price >= 1)
        {
            amount1E = (int)price / 1;
            price = price - (amount1E * 1);
        }

            Console.WriteLine(price);
            //transform cent x 100;
            price = MathF.Round(price,2) * 100;
            Console.WriteLine(price);

        if (price >=50)
        {
                amount50c = (int)price / 50;
                price -= amount50c * 50;
        }

        if (price >= 20)
        {
            amount20c = (int)price / 20;
            price -= amount20c * 20;
        }

        if (price >= 10)
        {
            amount10c = (int)price / 10;
            price -= amount10c * 10;
        }
        if(price>=5)
        {
            amount5c = (int)price / 5;
            price -= amount5c * 5;
        }
        if(price>=2)
        {
            amount2c = (int)price / 2;
            price -= amount2c * 2;
        }
        if (price >= 1)
        {
            amount1c = 1;
        }

        Console.WriteLine($"2euros :  {"\x1b[91m"}{amount2E}{"\x1b[39m"} 1euro : {"\x1b[91m"}{amount1E}{"\x1b[39m"} " +
                          $"50cent :  {"\x1b[91m"}{amount50c}{"\x1b[39m"} 20cent : {"\x1b[91m"}{amount20c}{"\x1b[39m"} " +
                          $"10cent :  {"\x1b[91m"}{amount10c}{"\x1b[39m"} 5cent : {"\x1b[91m"}{amount5c}{"\x1b[39m"} " +
                          $"2cent :  {"\x1b[91m"}{amount2c}{"\x1b[39m"} 1cent : {"\x1b[91m"}{amount1c}{"\x1b[39m"} ");
        }
       */

        /*int choiceByComputer = 50;
        int min = 1;
        int max = 100;
        int choiceNumber = initialNumber();

        while (choiceNumber != choiceByComputer)
        {
            if (choiceNumber < choiceByComputer)
            {
                Console.WriteLine("IA said : " + choiceByComputer);
                Console.WriteLine("Number too low");
                max = choiceByComputer;
                choiceByComputer = (min + max) / 2;
            }
            else
            {
                Console.WriteLine("IA said : " + choiceByComputer);
                Console.WriteLine("Number too high");
                min = choiceByComputer;
                choiceByComputer = (min + max) / 2;
            }

            if(choiceNumber == choiceByComputer)
                Console.WriteLine("Congratz you found the number it was : " + choiceByComputer);
        }
    }

    public static int initialNumber()
    {
        int min = 1;
        int max = 100;
        int num;
        string input;
        do
        {
            Console.WriteLine("Entre un nombre entre 1-100");
            input = Console.ReadLine();
            if (!Int32.TryParse(input, out num))
            {
                Console.WriteLine("thiz iz not a number");
            }
        } while (num < min || num > max );
        return num;
        */
        static char StickGame()
        {
            string seeStick = "IIIIIIIIIIIIIIIIIIII";
            string input;
            int retrieveStick;
            int retrieveByComputer = 0;
            Random rnd = new Random();

            Console.WriteLine($"{"\x1b[91m"}{seeStick}{"\x1b[39m"}"); 
            do
            {
                Console.WriteLine("take 1-3 sticks");
                input = Console.ReadLine();
                retrieveStick = int.Parse(input);
                seeStick = seeStick.Remove(seeStick.Length - retrieveStick, retrieveStick);
                Console.WriteLine($"{"\x1b[91m"}{seeStick}{"\x1b[39m"}"); 
                if (seeStick.Length == 1)
                {
                    Console.WriteLine("Player won");
                    Console.WriteLine("Do you want to retry ? : y/n");
                    if (Console.ReadLine() == "y")
                        StickGame();
                    break;
                }
                if (seeStick.Length >= 4)
                    retrieveByComputer = rnd.Next(1,4);
                if (seeStick.Length <= 3)
                    retrieveByComputer = rnd.Next(1,3);
                if (seeStick.Length == 2)
                    retrieveByComputer = rnd.Next(1,2);
                Console.WriteLine("Computer choose : "+ retrieveByComputer);
                seeStick = seeStick.Remove(seeStick.Length - retrieveByComputer, retrieveByComputer);
                Console.WriteLine($"{"\x1b[91m"}{seeStick}{"\x1b[39m"}");
                if (seeStick.Length == 1)
                {
                    Console.WriteLine("Computer won");
                    Console.WriteLine("Do you want to retry ? : y/n");
                    if (Console.ReadLine() == "y")
                        StickGame();
                    break;
                }
            } while (seeStick.Length != 1);
            return 'n';
        }
    }
}