
using System.Collections.Specialized;
using System.ComponentModel;
using System.Security.Cryptography;

int validDiceSides = 0;

do
{
    Console.Write("Please enter the number of sides for a pair of dice: ");
    string diceSides = Console.ReadLine();
    validDiceSides = CheckValidInteger(diceSides);
    if (validDiceSides == -1)
    {
        Console.WriteLine("That is not a valid number, try again!");
    }
} while (validDiceSides == -1);

Console.WriteLine("Roll the dice!");

Random randomGenerator = new Random();

int randomDice1 = randomGenerator.Next(1, validDiceSides);
int randomDice2 = randomGenerator.Next(1, validDiceSides);
int sum = CalculateSum(randomDice1, randomDice2);
Console.WriteLine($"You rolled a {randomDice1} and a {randomDice2} for a total of {sum}!");





static int CheckValidInteger(string diceSides)
{
    int returnValue = 0;
    try
    {
        returnValue = int.Parse(diceSides);
    }
    catch (FormatException)
    {
        returnValue = -1;
    }
    return returnValue;
}

static int CalculateSum(int firstNumber, int secondNumber)
{
    int sum = firstNumber + secondNumber;
    return sum;
}



Console.ReadKey();



// output
// snake eyes: two 1s
// ace deuce: a 1 and 2 
// box cars: two 6s
// win: a total of 7 or 11 
// craps: a total of 2,3, or 12 (will also generate another message)
// extra: come up w/ winning combos for other dice sizes beside 5 

// prompt user to roll dice again y/n 


