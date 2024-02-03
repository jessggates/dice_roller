
using System.Collections.Specialized;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Runtime.Intrinsics.Arm;
using System.Security.Cryptography;

int validDiceSides = 0;
string playAgain = "";

do
{
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
    Console.WriteLine();

    Random randomGenerator = new Random();

    int randomDice1 = randomGenerator.Next(1, validDiceSides);
    int randomDice2 = randomGenerator.Next(1, validDiceSides);
    int sum = CalculateSum(randomDice1, randomDice2);
    Console.WriteLine($"You rolled a {randomDice1} and a {randomDice2} for a total of {sum}!");
    if (validDiceSides == 6)
    {
        Console.WriteLine(LuckyDice(randomDice1, randomDice2));
        Console.WriteLine(FinalResult(randomDice1, randomDice2));
    }

    Console.WriteLine("Would you like to play again? (yes/no)");
    playAgain = Console.ReadLine().ToLower().Trim();

} while (playAgain == "yes");
    Console.WriteLine("Thanks for playing!");

    int CheckValidInteger(string diceSides)
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

    int CalculateSum(int firstNumber, int secondNumber)
    {
        int sum = firstNumber + secondNumber;
        return sum;
    }

    string LuckyDice(int firstNumber, int secondNumber)
    {
        if (firstNumber == 1 && secondNumber == 1)
            return $"You got snake eyes!";
        if (firstNumber == 1 && secondNumber == 2 || firstNumber == 2 && secondNumber == 1)
            return $"You rolled Ace Deuce!";
        if (firstNumber == 6 && secondNumber == 6)
            return $"You rolled Box Cars!";
        else return "";
    }

    string FinalResult(int firstNumber, int secondNumber)
    {
        if (firstNumber + secondNumber == 7 || firstNumber + secondNumber == 11)
            return $"Win!";
        if (firstNumber + secondNumber == 2 || firstNumber + secondNumber == 3 || firstNumber + secondNumber == 12)
            return $"Craps!";
        else return "";
    }