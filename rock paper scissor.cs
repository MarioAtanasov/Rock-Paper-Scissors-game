Console.WriteLine("Welcome to Rock-Paper-Scissors!");
Console.WriteLine("You will be playing against the computer. Good luck!");

while (true)
{
    Console.WriteLine();
    Console.Write("Enter your choice (rock, paper, or scissors): ");
    string input = Console.ReadLine().ToLower();

    if (input != "rock" && input != "paper" && input != "scissors")
    {
        Console.WriteLine("Invalid input. Please try again.");
        continue;
    }

    Random random = new Random();
    string[] options = { "rock", "paper", "scissors" };
    string computerChoice = options[random.Next(options.Length)];

    Console.WriteLine("The computer chose: " + computerChoice);

    if (input == computerChoice)
    {
        Console.WriteLine("It's a draw!");
    }
    else if (input == "rock" && computerChoice == "scissors" ||
             input == "paper" && computerChoice == "rock" ||
             input == "scissors" && computerChoice == "paper")
    {
        Console.WriteLine("You win!");
    }
    else
    {
        Console.WriteLine("The computer wins!");
    }

    Console.WriteLine("Press any key to play again, or press Esc to exit.");
    if (Console.ReadKey().Key == ConsoleKey.Escape)
    {
        break;
    }
}