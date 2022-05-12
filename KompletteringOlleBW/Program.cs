using System;
using System.Collections.Generic;

int Lives = 3;

bool Alive = true;
bool Question1 = false;
bool Question2 = false;

Hello();
Console.ReadLine();
Console.Clear();


while (Alive == true)
{
    // Code runs until you get Question 1 right
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
        // Each time you answer incorrectly you will lose 1 life
        else
        {
            Lives = Lives - 1;
            Console.Clear();
            Console.WriteLine($"You now have {Lives} Lives left");
            False();
        }
        // Ends quiz if you run out of lives
        if (Lives == 0)
        {
            Console.Clear();
            Console.WriteLine("You died, Shame on you!");
            Console.ReadLine();
            Alive = false;
            Question1 = true;
            Question2 = true;
        }
    }

    List<string> Choises = new List<string>();
    Choises.Add("73");
    Choises.Add("21");
    Choises.Add("10");

    // Code runs until you get Question 2 right
    while (Question2 == false)
    {
        Console.WriteLine("What is 7x3?");

        Console.WriteLine(Choises[0] + " A");
        Console.WriteLine(Choises[1] + " B");
        Console.WriteLine(Choises[2] + " C");

        string Choise2 = Console.ReadLine();
        Choise2 = Choise2.ToLower();

        if (Choise2 == "b")
        {
            Console.Clear();
            Correct();
            Victory();
            Question2 = true;
            Alive = false;
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
            Console.ReadLine();
            Alive = false;
            Question2 = true;
        }
    }
}

// Writes an introduction to the quiz
static void Hello()
{
    Console.WriteLine("Hello and welcome to my quiz!");
    Console.WriteLine("Press Enter to continue.");
}

// Writes out a specific message if player is correct
static void Correct()
{
    Console.WriteLine("That was Correct!");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
    Console.Clear();
}

// Writes out specific message if player is incorrect
static void False()
{
    Console.WriteLine("That was Incorrect!");
    Console.WriteLine("Try Again!");
}

static void Victory()
{
    Console.WriteLine("Congratulations! You Won!");
    Console.WriteLine("Press ENTER to quit.");
    Console.ReadLine();
}