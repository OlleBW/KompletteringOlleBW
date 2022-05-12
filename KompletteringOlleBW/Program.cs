using System;
using System.Collections.Generic;

int Lives = 3;
List<string> Choises = new List<string>();

bool Question1 = false;
bool Question2 = false;

Hello();
Console.ReadLine();
Console.Clear();


while (Lives > 0)
{
    while (Question1 == false)
    {
        Console.WriteLine("What is 2+2?");
        string Choise = Console.ReadLine();
        Choise = Choise.ToString();
        Choise = Choise.ToLower();

        if (Choise == "4" || Choise == "four")
        {
            Console.Clear();
            Correct();
            Question1 = true;
        }
        else
        {
            Lives = Lives - 1;
            Console.Clear();
            Console.WriteLine($"You now have {Lives} Lives left");
            False();
        }
        if (Lives == 0)
        {
            Console.Clear();
            Console.WriteLine("You died, Shame on you!");
            End();
        }
    }

    Choises.Add("73");
    Choises.Add("21");
    Choises.Add("10");

    while (Question2 == false)
    {
        Console.WriteLine("What is 7x3?");

        Console.WriteLine(Choises[0] + " A");
        Console.WriteLine(Choises[1] + " B");
        Console.WriteLine(Choises[2] + " C");

        string Choise2 = Console.ReadLine();
        Choise2 = Choise2.ToLower();

        if (Choise2 == "B")
        {
            Correct();

        }
    }
}


// Writes an introduction to the quiz
static void Hello()
{
    Console.WriteLine("Hello and welcome to my quiz!");
    Console.WriteLine("Press Enter to continue.");
}

// Writes out a specific messeage if player is correct
static void Correct()
{
    Console.WriteLine("That was Correct!");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
}

// Writes out specific messeage if player is incorrect
static void False()
{
    Console.WriteLine("That was Incorrect!");
    Console.WriteLine("Try Again!");
}

// Ends the game after pressing enter
static void End()
{
    Console.ReadLine();
    Question1 = true;
    Question2 = true;
}