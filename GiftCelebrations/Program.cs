//Welcome message
Console.WriteLine("Gift Celebrations");
Console.WriteLine("-----------------");

//Prepare variables
bool runAgain;
int userInput;
decimal[] giftAmounts = new decimal[3]
{
    5000.00M / 12,
    5000.00M / 2,
    5000.00M
};
string[] distribution = new string[3]
{
    "Monthly",
    "Semesterly",
    "Anually"
};
string options = string.Empty;
int ctr = 0;
while (ctr < distribution.Length)
{
    string value = distribution[ctr];
    int identifier = ++ctr;
    options += $"[{identifier}] {value}\n";
}

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.Write(options);
    Console.Write("Enter the corresponding number of your chosen frequency in giving gifts: ");
    bool validInput = int.TryParse(Console.ReadLine(), out userInput);
    bool withinRange = (userInput > 0) && (userInput < 4);
    runAgain = (validInput == false) || (withinRange == false);

    //Check wrong input
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }

} while (runAgain);

//Process results
int chosenFrequency = --userInput;
string maximumAmount = giftAmounts[chosenFrequency].ToString("N");
string frequency = distribution[chosenFrequency].ToString();
Console.WriteLine();
Console.WriteLine($"Php {maximumAmount} is the maximum amount {frequency}.");

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();