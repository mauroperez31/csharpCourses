// See https://aka.ms/new-console-template for more information
Console.WriteLine("Rock Paper Scissors!");

while (true)
{
    Console.WriteLine("Are you ready to play?");
    Console.WriteLine("Let's play!");
    var selectedChoice = SelectChoice();
    var yourChoice = char.Parse(selectedChoice);
    Console.WriteLine($"Your selection:  {yourChoice}");
    var opponentChoice = GetOpponentChoice();
    Console.WriteLine($" I chose {opponentChoice}");
    DecideWinner(opponentChoice, yourChoice);
    Console.WriteLine("Do you want to play again?");
    Console.WriteLine("Enter Yes to play again, or any other key to exit.");
    var playAgain = Console.ReadLine();
    if (playAgain?.ToLower() != "yes")
    {
        Console.WriteLine("Thanks for playing! Goodbye!");
        break;
    }
}


string SelectChoice()
{
    Console.WriteLine("Choose your weapon: rock (R), paper (P), or scissors (S).");
    var selectionChoice = Console.ReadLine();
    if (selectionChoice?.ToLower() != "r"
        && selectionChoice?.ToLower() != "p"
        && selectionChoice?.ToLower() != "s")
    {
        Console.WriteLine("Invalid choice. Please choose R, P, or S.");
    }
    return selectionChoice;
}

char GetOpponentChoice() {
    char[] options = new char[] { 'R', 'P', 'S' };
    Random random = new Random();
    int randomIndex = random.Next(0, options.Length);
    return options[randomIndex];
}

void DecideWinner(char opponentChoice, char yourChoice)
{
    if ( yourChoice == opponentChoice)
    {
        Console.WriteLine("It's a tie!");
        return;
    }

    switch(yourChoice)
    {
        case 'R':
        case 'r':
            if (opponentChoice == 'P')
                Console.WriteLine("Paper beats rock, I win!");
            else if (opponentChoice == 'S')
                Console.WriteLine("Rock beats scissors, you win!");
            break;
        case 'P':
        case 'p':
            if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats paper, you win!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Rock beats scissors, I win!");
            break;
        case 'S':
        case 's':
            if (opponentChoice == 'P')
                Console.WriteLine("Scissors beats paper, I win!");
            else if (opponentChoice == 'R')
                Console.WriteLine("Rock beats Scissors, you win!");
            break;
    };
}