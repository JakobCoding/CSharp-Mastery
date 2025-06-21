using System.Formats.Asn1;

internal class Program
{
    private static void Main(string[] args)
    {
        // Working with Numbers
        Console.WriteLine(Math.Abs(-40));
        // Math.Sqrt() provides square root of number
        Console.WriteLine(Math.Sqrt(36));
        // Math.Pow() provides power of a number
        Console.WriteLine(Math.Pow(2, 3)); // 2^3 = 8
        // Math.Max() provides the maximum of two numbers
        Console.WriteLine(Math.Max(10, 20));
        // Math.Min() provides the minimum of two numbers
        Console.WriteLine(Math.Min(10, 20));
        // Math.Round() rounds a number to the nearest integer
        Console.WriteLine(Math.Round(3.7)); // rounds to 4
        Console.WriteLine(Math.Round(3.4)); // rounds to 3
        // Math.Ceiling() rounds a number up to the nearest integer
        Console.WriteLine(Math.Ceiling(3.1)); // rounds to 4
        // Math.Floor() rounds a number down to the nearest integer
        Console.WriteLine(Math.Floor(3.9)); // rounds to 3
        // Math.PI provides the value of pi
        Console.WriteLine(Math.PI); // approximately 3.14159
        // Math.E provides the value of e (Euler's number)
        Console.WriteLine(Math.E); // approximately 2.71828
        // Math.Log() provides the natural logarithm of a number
        Console.WriteLine(Math.Log(10)); // natural logarithm of 10

        // Working with Variables
        int myNum = 5; // integer variable
        double myDoubleNum = 5.99; // double variable
        char myLetter = 'D'; // character variable
        bool myBool = true; // boolean variable
        string myText = "Hello"; // string variable
        // Printing variables
        Console.WriteLine(myNum);
        Console.WriteLine(myDoubleNum);
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
        // Performing arithmetic operations
        Console.WriteLine(5 + 3); // addition
        Console.WriteLine(5 - 3); // subtraction
        Console.WriteLine(5 * 3); // multiplication
        Console.WriteLine(5 / 3); // division
        Console.WriteLine(5 % 3); // modulus (remainder)
        // Incrementing and decrementing a variable
        int x = 10;
        x++; // increment by 1
        Console.WriteLine(x); // prints 11
        x--; // decrement by 1
        Console.WriteLine(x); // prints 10
        Console.WriteLine(x);
        // Performing arithmetic operations with variables
        Console.WriteLine(myNum + myDoubleNum); // addition with different types
        Console.WriteLine(myNum - 2); // subtraction with integer
        Console.WriteLine(myDoubleNum * 2); // multiplication with double
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        // Performing arithmetic operations with literals
        Console.WriteLine(myText);
        Console.WriteLine(5 + 3); // addition with literals
        Console.WriteLine(5 - 3);
        Console.WriteLine(5 * 3); // multiplication with literals
        Console.WriteLine(5 / 3); // division with literals
        Console.WriteLine(5 % 3); // modulus with literals
        // Performing arithmetic operations with variables and literals
        Console.WriteLine(myNum + 2); // addition with variable and literal
        Console.WriteLine(myDoubleNum - 1.99); // subtraction with variable and literal
        Console.WriteLine(myNum * 2); // multiplication with variable and literal
        Console.WriteLine(myLetter);
        Console.WriteLine(myBool);
        Console.WriteLine(myText);
        // Performing arithmetic operations with variables and literals
        Console.WriteLine(5 + 8); // addition with literals
        Console.WriteLine(5 - 2); // subtraction with literals
        Console.WriteLine(5 * 3); // multiplication with literals
        Console.WriteLine(5 / 2); // division with literals
        Console.WriteLine(5 % 2); // modulus with literals
        // Working with Constants
        const double PI = 3.14159; // constant variable
        Console.WriteLine(PI); // prints the value of PI
        // Uncommenting the next line will cause an error because PI is a constant
        // PI = 3.14; // this will cause an error because PI is a constant
        // Working with User Input
        `   







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