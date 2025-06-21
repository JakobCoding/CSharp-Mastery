// dotnet run in the terminal to see output
/*
Random dice = new Random();

int roll1 = dice.Next(1, 7);
int roll2 = dice.Next(1, 7);
int roll3 = dice.Next(1, 7);

// roll1 = 6;
// roll2 = 6;
// roll3 = 6;

int total = roll1 + roll2 + roll3;
Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples! +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles! +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

*/

using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Working with Numbers
        Console.WriteLine(Math.Abs(-40));
        // Math.Sqrt() provides square root of number
        Console.WriteLine(Math.Sqrt(36));
        Console.WriteLine(5 + 8);
        Console.WriteLine(5 - 8);
        Console.WriteLine(5 / 8);
        Console.WriteLine(5 % 6);
        int num = 6;
        num++;
        num = 7;
        num--;
        Console.WriteLine(num);


        //Working With Strings
        string phrase = "Jake's Academy";
        //check how many characters in a string variable
        Console.WriteLine(phrase.Length + " charachters in this string!");
        // Print out certain characters from a string
        Console.WriteLine(phrase[10]);
        // indexOf method shows the index where a words starts  
        Console.WriteLine(phrase.IndexOf("Academy"));// index 7 
                                                     // Substring method prints out a string from a certain index
        Console.WriteLine(phrase.Substring(7, 3));


        //string phrase = "Jake's Academy"; // This is a string
        //char grade = 'A'; // can only have one character
        //int jakesAge = 39; // showing how to assign an int
        //double gpa = 3.2; // doubles are decimals 
        //bool isMale = true; // booleans produce yes or no values 



        string characterName = "Jake";
        int characterAge = 39;


        Console.WriteLine($"There once was a man named {characterName},");
        Console.WriteLine($"He was {characterAge} years old,");
        characterName = "Mike";
        Console.WriteLine($"He really liked the name {characterName},");
        Console.WriteLine($"But he didn't like being {characterAge}.");




        Console.WriteLine("|     /|     /");
        Console.WriteLine("|    / |    /");
        Console.WriteLine("|   /  |   /");
        Console.WriteLine("|  /   |  /");
        Console.WriteLine("| /    | /");
        Console.WriteLine("|/_____|/");

        //keeps the program window open 
        Console.ReadLine();

        Random random = new Random();
        int daysUntilExpiration = random.Next(12);
        Console.WriteLine(daysUntilExpiration);
        int discountPercentage = 0;

        if (daysUntilExpiration == 0)
        {
            Console.WriteLine("Your subscription has expired");
        }
        else if (daysUntilExpiration == 1)
        {
            Console.WriteLine("Your subscription expires within a day!");
            discountPercentage = 20;
        }
        else if (daysUntilExpiration <= 5)
        {
            Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
            discountPercentage = 10;
        }
        else if (daysUntilExpiration <= 10)
        {
            Console.WriteLine("Your subsciption will expire soon. Renew now!");
        }
        if (discountPercentage > 0)
        {
            Console.WriteLine($"Renew now and save {discountPercentage}%.");
        }
    }
}