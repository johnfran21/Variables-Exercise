namespace VariablesExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            string drinkName = "Arnold Palmer";
            int drinkAge = 1965;
            char initial = 'A';
            bool isGreat = true;
            double avgPrice = 0.99;
            decimal storePrice = 2.99m;

            Console.WriteLine($"There is a drink called {drinkName} and it was made back around {drinkAge}. \n" +
                $"It has a Grade {initial} resume for being the best drink in the world, in my hubmle opinion. \n" +
                $"It is {isGreat} that it was created by a man named {drinkName} and the original cost was {avgPrice}. \n" +
                $"But in more recent years corner stores and big chains will upcharge it to {storePrice}. \n" +
                $"Hopefully one day it will be {avgPrice} everywhere again but one can hope.");
        }
    }
}
