int userInt = 0;

Console.WriteLine("Hello, User. Please enter a whole number:");
string userInput = Console.ReadLine();
int.TryParse(userInput, out userInt);
for (int currInt = userInt; currInt >= 0; currInt--)
{
    Console.WriteLine(currInt);
}
Console.ReadLine();