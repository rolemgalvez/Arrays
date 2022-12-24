//Welcome message
Console.WriteLine("Actual Medical Assistance");
Console.WriteLine("-------------------------");

bool runAgain;
int userInput;
string[] distribution = new string[3]
{
    "Monthly",
    "Semesterly",
    "Annually"
};
decimal[] assistance = new decimal[3]
{
    10000.00M / 12,
    10000.00M / 2,
    10000.00M
};
string choices = string.Empty;
int ctr = 0;
while (ctr < distribution.Length)
{
    string value = distribution[ctr++];
    int identifier = ctr;
    choices += $"[{identifier}] {value}\n";
}

do
{
    runAgain = false;
    Console.WriteLine();

    //Get user input
    Console.Write(choices);
    Console.Write("Enter the number representing your desired distribution of Actual Medical Assistance: ");
    bool validInput = int.TryParse(Console.ReadLine(), out userInput);
    bool acceptedInput = userInput > 0 && userInput < 4;
    runAgain = (validInput == false) || (acceptedInput == false);

    //Validate input
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }

} while (runAgain);

//Process result
int chosenDistribution = userInput - 1;
Console.WriteLine();
Console.WriteLine($"Php {assistance[chosenDistribution].ToString("N")} is the maximum amount that can be expected {distribution[chosenDistribution]}.");

//End of program
Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();