using System;

namespace CoinConverterVersionTwo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            /*
            You have three types of coins: Gold, Silver and Bronze. User must set these values themselves.

            This program will take in a value in cents and return a calculation of how many bronze, silver or gold coins are needed.

            */

            Console.WriteLine("Welcome to Coin Converter Version 2!");
            Console.WriteLine("Gold Coins are currently worth how many cents?: ");
            string goldUserSetValue = Console.ReadLine();
            double goldUserAsDouble = Convert.ToDouble(goldUserSetValue);
            Console.WriteLine("Silver Coins are currently worth how many cents?: ");
            string silverUserSetValue = Console.ReadLine();
            double silverUserAsDouble = Convert.ToDouble(silverUserSetValue);
            Console.WriteLine("Bronze Coins are currently worth how many cents?: ");
            string bronzeUserSetValue = Console.ReadLine();
            double bronzeUserAsDouble = Convert.ToDouble(bronzeUserSetValue);


            Console.WriteLine("Please give amount (in cents) to be converted to bronze, silver and/or gold goins: ");
            string amountAsString = Console.ReadLine();

            double amountAsDouble = Convert.ToDouble(amountAsString);

            Console.WriteLine($"{amountAsString} is equal to...");

            double goldCoinValue = goldUserAsDouble;
            double silverCoinValue = silverUserAsDouble;
            double bronzeCoinValue = bronzeUserAsDouble;

            // How many gold coins in the amount given
            double goldCoins = Math.Floor(amountAsDouble / goldCoinValue);

            // What is left over from this gold coin division
            double goldCoinsRemainder = amountAsDouble % goldCoinValue;

            // How many silver coins in the amount remaining after gold coins calculated

            double silverCoins = Math.Floor(goldCoinsRemainder / silverCoinValue);

            // What is left over from this silver coin division
            double silverCoinsRemainder = goldCoinsRemainder % silverCoinValue;

            // How many bronze coins in the amount remaining after gold coins calculated

            double bronzeCoins = Math.Floor(silverCoinsRemainder / bronzeCoinValue);

            // What is left over from this silver coin division
            double bronzeCoinsRemainder = silverCoinsRemainder % bronzeCoinValue;

            Console.WriteLine($"Gold Coins: {goldCoins}");
            Console.WriteLine($"Silver Coins: {silverCoins}");
            Console.WriteLine($"Bronze Coins: {bronzeCoins}");
            Console.WriteLine($"Remaining cents: {bronzeCoinsRemainder}");

        }
    }
}
