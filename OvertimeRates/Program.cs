//Welcome message
Console.WriteLine("Overtime Rates");
Console.WriteLine("--------------");

bool runAgain;
int userChoice;
do
{
    runAgain = false;
    Console.WriteLine();
    string[] options = new string[11]
    {
        "Ordinary Work Day Overtime",
        "Rest Day Overtime",
        "Rest Day Overtime in excess of 8 hours",
        "Special Holiday Overtime",
        "Special Holiday Overtimein in excess of 8 hours",
        "Rest Day and Special Holiday Overtime",
        "Rest Day and Special Holiday Overtime in excess of 8 hours",
        "Regular Holiday Overtime",
        "Regular Holiday Overtime in excess of 8 hours",
        "Regular Holiday and Rest Day Overtime",
        "Double Holiday Overtime"
    };

    //Prepare options to display
    string optionsText = "";
    int ctr = 0;
    while (ctr < options.Length)
    {
        string value = options[ctr];
        int identifier = ++ctr;
        optionsText += $"[{identifier}] {value}\n";
    }

    // Get user input
    Console.Write(optionsText);
    Console.Write("Enter corresponding number for your chosen overtime type to see its rates: ");
    bool isValidInput = int.TryParse(Console.ReadLine(), out userChoice);

    //Check for invalid input
    bool withinChoices = userChoice > 0 && userChoice < 12;
    runAgain = (isValidInput && withinChoices) == false;
    if (runAgain)
    {
        Console.WriteLine();
        Console.WriteLine("Invalid input. Try again.");
    }
} while (runAgain);

//Process result
int chosenType = userChoice - 1;
int[] overtimeRatesA = new int[11] { 125, 130, 130, 130, 130, 150, 150, 200, 200,                                     200, 300 };
int[] overtimeRatesB = new int[11] { 0, 0, 130, 0, 130, 0, 130, 0, 130, 130, 0 };
int[] overtimeRatesC = new int[11] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 130, 0 };
string rateA, rateB, rateC;

if (overtimeRatesA[chosenType] != 0)
{
    rateA = $"x {overtimeRatesA[chosenType]}";
}

if (overtimeRatesB[chosenType] != 0)
{
    rateB = $"x {overtimeRatesB[chosenType]}";
}

if (overtimeRatesC[chosenType] != 0)
{
    rateC = $"x {overtimeRatesC[chosenType]}";
}

string message = $"()";

Console.WriteLine($"");