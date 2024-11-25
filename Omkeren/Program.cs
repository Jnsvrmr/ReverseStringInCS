
using System.Linq.Expressions;

/****************************************************************************************/
/* Program flow */
Console.WriteLine("Hello, World!");
/* ASK USER FOR A STRING */
Console.WriteLine("Enter a string you wish to reverse : ");
String stringToReverse = Console.ReadLine();
/* LOCAL VARIABLES */
String reversedString = "";
int counter = stringToReverse.Length - 1;
int choice;

/* ASK USER FOR REVERSE METHOD */
AskChoice();
ShowReversedString(stringToReverse,choice);


/* MENU METHODS */
void AskChoice()
{
    
    Console.WriteLine("These are the different reverse methods : ");
    Console.WriteLine("1: For-loop \n2: While-loop\n3: Do-While-loop\n4: Recursion");
    Console.WriteLine("Choose the wished method (enter the number) : ");
    int[] validChoices = { 1, 2, 3, 4 };
    while (true)
    {
        // validate if input is an integer
        if (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number from 1 to 4:");
            continue;
        }

        // check if the inputed number occurs in the array
        if (Array.Exists(validChoices, number => number == choice))
        {
            break; 
        }
        else
        {
            Console.WriteLine("The number you entered is not an option. Try Again:");
        }
    }

}

void ShowReversedString(String stringToReverse, int choice)
{
    switch (choice)
    {
        case 1:
            ReverseWithForLoop(stringToReverse);
            break;
        case 2:
            ReverseWithWhileLoop(stringToReverse);
            break;
        case 3:
            ReverseWithDoWhileLoop(stringToReverse);
            break;
        case 4:
            ReverseWithRecursion(stringToReverse);
            break;
    }

    Console.WriteLine(reversedString);
    

}

/* DIFFERENT METHODS TO REVERSE A STRING */
String ReverseWithForLoop(String stringToReverse) 
{
    for (int i = counter; i >= 0; i--)
    {
        reversedString += stringToReverse[i];
    }
    return reversedString;
}

String ReverseWithWhileLoop(String stringToReverse)
{
    while (counter >= 0)
    {
        reversedString += stringToReverse[counter];
        counter--;
    }
    return reversedString;
}

String ReverseWithDoWhileLoop(String stringToReverse)
{
    do
    {
        reversedString += stringToReverse[counter];
        counter--;
    }
    while (counter >= 0);

    return reversedString;
}

String ReverseWithRecursion(String stringToReverse)
{
    if(stringToReverse.Length <= 1)
    {
        reversedString = stringToReverse;
        return reversedString;
    }

    reversedString += stringToReverse[^1] + ReverseWithRecursion(stringToReverse.Substring(0, stringToReverse.Length - 1));

    return reversedString;
}

