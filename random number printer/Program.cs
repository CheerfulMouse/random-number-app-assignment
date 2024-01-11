using System.Runtime.CompilerServices;

Random rnd = new Random();
string? readResult;
string entry = "";
bool validEntry = false;

Console.WriteLine("press enter to generate 20 Yes or No's");
readResult = Console.ReadLine();
if (readResult != "")
{
    validEntry = true;
}
do
{
    for (int i = 0; i < 20; i++)
    {
        int result = rnd.Next();
        int answer = (result % 2);
        if (answer == 0)
        {
            Console.WriteLine((i + 1) + ": Yes");
        }
        else
        {
            Console.WriteLine((i + 1) + ": No");
        }

    }
    Console.WriteLine("Would you like to continue? Press Y to generate another list, or press N to finish");
    readResult = Console.ReadLine();
    if (readResult != "")
    {
        entry = readResult.ToLower();
        if (entry == "y")
        {
            validEntry = true;
        }
        else if (entry == "n")
        {
            validEntry = false;
        }
    }
} while (validEntry == true);



if (validEntry == false)
{
    Console.WriteLine("Thank you for using this App. press Enter to Close");
}