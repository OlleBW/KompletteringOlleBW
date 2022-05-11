using System;
int Lives = 3;
bool Correct = false;

while (Lives > 0)
{
    Hello();
    Console.ReadLine();

    Console.WriteLine("What is 2+2?");
    string Choise = Console.ReadLine();
    Choise = Choise.ToString();
    Choise = Choise.ToLower();
    if (Choise = "4" || Choise = "four")
    {
        True();
    }
}




static void Hello()
{
    Console.WriteLine("Hello and welcome to my quiz!");
    Console.WriteLine("Press Enter to continue.");
}
static void True()
{
    Console.WriteLine("That was Correct!");
    Console.WriteLine("Press Enter to continue.");
    Console.ReadLine();
}
static void False()
{
    Console.WriteLine("That was Incorrect!");
    Console.WriteLine("Press Enter to Try Again.");
    Console.ReadLine();
}