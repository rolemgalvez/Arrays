//Welcome message
Console.WriteLine("Laundy Allowance");
Console.WriteLine("----------------");

//Initialize variables
bool runAgain;
string[] frequencies = new string[3]
{
    "Weekly",
    "Semi-Montly",
    "Monthly"
};
decimal[] allowances = new decimal[3]
{
    300 / 4,
    300 / 2,
    300
};

//Prepare options
string options = string.Empty;
int ctr = 0;
while (ctr < frequencies.Length)
{
    string value = frequencies[ctr];
    int identifier = ++ctr;
    options += $"[{identifier}] {value}\n";
}
int userInput;

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.Write(options);
    Console.Write("Enter the number corresponding to your chosen frequency: ");
    bool isValidInput = int.TryParse(Console.ReadLine(), out userInput);
    bool acceptedInput = userInput > 0 && userInput < 4;
    runAgain = (isValidInput == false) || (acceptedInput == false);

    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }

} while (runAgain);

//Prepare values
int chosenFrequency = userInput - 1;

Console.WriteLine();
Console.WriteLine($"Php {allowances[chosenFrequency].ToString("N")} is the maximum amount you can expect {frequencies[chosenFrequency]}.");

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();