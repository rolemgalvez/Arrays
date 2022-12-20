//Welcome message
Console.WriteLine("Parental Leaves");
Console.WriteLine("---------------");

//Get user input
string parentalLeavesText = "Maternity Leave,Paternity Leave,Solo Parent Leave";
string[] parentalLeaves = parentalLeavesText.Split(',');
int pickedLeave;
bool canProcess;
do
{
    Console.WriteLine();

	Console.WriteLine($"[1] {parentalLeaves[0]}\n" +
					  $"[2] {parentalLeaves[1]}\n" +
					  $"[3] {parentalLeaves[2]}");
	Console.Write("Enter the corresponding number of a leave you want to know the number of entitlements: ");
	bool validInput = int.TryParse(Console.ReadLine(), out pickedLeave);
	bool withinChoices = pickedLeave > 0 && pickedLeave < 4;
	canProcess = validInput && withinChoices;

    if (canProcess == false)
    {
		Console.WriteLine();
		Console.WriteLine("Invalid input. Try again.");
    }

} while (canProcess == false);

//Process input
int[] paidEntitlements = new int[] { 105, 7, 3 };
int[] extentionEntitlements = new int[] { 30, 7, 15 };

Console.WriteLine();
switch (pickedLeave - 1)
{
	case 0:
		Console.WriteLine($"{parentalLeaves[0]} has 105 days paid leave for mothers.");
		Console.WriteLine("Can also have additional 30 days unpaid leave.");
		break;
	case 1:
		Console.WriteLine($"{parentalLeaves[1]} has 7 days paid leave for married fathers.");
		Console.WriteLine("7 days of maternity leave from his wife can be transferred to him to have a total of 14 days paid leave.");
		break;
	case 2:
		Console.WriteLine($"{parentalLeaves[2]} has 7 days paid leave for every year of service for solo fathers/mothers.");
		Console.WriteLine("For mothers, can extend to 15 days paid leave.");
		break;
	default:
		break;
}

Console.WriteLine();
Console.WriteLine("End of program.");
Console.ReadLine();
