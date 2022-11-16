var cont = true;
var activities = new List<string>()
    { "Movies", "Paintball", "Bowling", "Lazer Tag", "LAN Party", "Hiking", "Axe Throwing", "Wine Tasting" };

Random rng = new Random();

Console.Write("Hello, welcome to the random activity generator! \nWould you like to generate a random activity? yes/no: ");

var userInput = Console.ReadLine().ToLower();
cont = (userInput == "yes") ? true : false;
Console.WriteLine();

while (userInput != "no" && userInput != "yes")
{
    Console.Write("Invalid entry. Please enter \"yes\" or \"no\": ");
    userInput = Console.ReadLine().ToLower();
    cont = (userInput == "yes") ? true : false;
    Console.WriteLine();

}
if (cont)
{
    Console.Write("We are going to need your information first! What is your name? ");
    string userName = Console.ReadLine();
    Console.WriteLine();
    Console.Write("What is your age? ");
    bool userAgeParse = int.TryParse(Console.ReadLine(), out int userAge);
    Console.WriteLine();

    while (!userAgeParse)
    {
        Console.Write("Invalid entry. Please enter a valid age (using numbers): ");
        userAgeParse = int.TryParse(Console.ReadLine(), out userAge);
        Console.WriteLine();
    }

    Console.Write("Would you like to see the current list of activities or add any activities before we generate one? yes/no: ");

    var userInput1 = Console.ReadLine().ToLower();
    bool seeList = (userInput1 == "yes") ? true : false;

    while (userInput1 != "no" && userInput1 != "yes")
    {
        Console.Write("Invalid entry. Please enter \"yes\" or \"no\": ");
        userInput1 = Console.ReadLine().ToLower();
        seeList = (userInput1 == "yes") ? true : false;
    }

    if (seeList)
    {
        Console.WriteLine();
        foreach (string activity in activities)
        {
            Console.WriteLine($"{activity} ");
            Thread.Sleep(250);
        }
    }
    Console.WriteLine();
    Console.Write("Would you like to add any activities before we generate one? yes/no: ");

    var userInput2 = Console.ReadLine().ToLower();
    bool addToList = (userInput2 == "yes") ? true : false;

    while (userInput2 != "no" && userInput2 != "yes")
    {
        Console.WriteLine();
        Console.Write("Invalid entry. Please enter \"yes\" or \"no\": ");
        userInput = Console.ReadLine().ToLower();
        addToList = (userInput2 == "yes") ? true : false;

    }

    Console.WriteLine();
    while (addToList)
    {
        Console.Write("What would you like to add? ");
        string userAddition = Console.ReadLine();
        activities.Add(userAddition);
        Console.WriteLine();
        foreach (string activity in activities)
        {
            Console.WriteLine($"{activity} ");
            Thread.Sleep(250);
        }
        Console.WriteLine();
        Console.Write("Would you like to add more? yes/no: ");

        var userInput3 = Console.ReadLine().ToLower();
        addToList = (userInput3 == "yes") ? true : false;
        Console.WriteLine();

        while (userInput3 != "no" && userInput3 != "yes")
        {
            Console.Write("Invalid entry. Please enter \"yes\" or \"no\": ");
            userInput3 = Console.ReadLine().ToLower();
            addToList = (userInput3 == "yes") ? true : false;
            Console.WriteLine();
        }
    }

    while (cont)
    {
        Console.Write("Connecting to the database");
        for (int i = 0; i < 10; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
        Console.WriteLine();
        Console.Write("Choosing your random activity");
        for (int i = 0; i < 9; i++)
        {
            Console.Write(". ");
            Thread.Sleep(500);
        }
        Console.WriteLine();
        int randomNumber = rng.Next(activities.Count);
        string randomActivity = activities[randomNumber];
        if (userAge < 21 && randomActivity == "Wine Tasting")
        {
            Console.WriteLine($"Oh no! Looks like you are too young to do {randomActivity}");
            Console.WriteLine("Pick something else!");
            activities.Remove(randomActivity);
            randomNumber = rng.Next(activities.Count);
            randomActivity = activities[randomNumber];
        }
        Console.WriteLine();
        Console.Write($"Ah got it! {userName}, your random activity is: {randomActivity}! Is this ok or do you want to " +
            $"grab another activity? Keep/Redo: ");
        var userInput4 = Console.ReadLine().ToLower();
        cont = (userInput4 == "redo") ? true : false;

        Console.WriteLine();

        while (userInput4 != "redo" && userInput4 != "keep")
        {
            Console.WriteLine();
            Console.Write("Invalid entry. Please enter \"keep\" or \"redo\": ");
            userInput4 = Console.ReadLine().ToLower();
            cont = (userInput4 == "redo") ? true : false;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Okay, have a great day!");    