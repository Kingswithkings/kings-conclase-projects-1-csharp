// See https://aka.ms/new-console-template for more information



int totalCost = 0;
Console.WriteLine("Welcome to Savy Communications.");
Console.WriteLine("Please select 1 for Nokia NK900 at N7900");
Console.WriteLine("Please select 2 for Samsung SG500 at N39000");
Console.WriteLine("Please select 3 for Tecno Phamtom at N23000");

string userInput = Console.ReadLine();
int num = Convert.ToInt32(userInput);
int nokiaPrice = 7900;
int samsungPrice = 39000;
int tecnoPrice = 23000;
if (num == 1)
{
    Console.WriteLine("You chose Nokia and your bill is N" + nokiaPrice);
}
else if (num == 2)
{
    Console.WriteLine("You chose Samsung and your bill is N" + samsungPrice);
}
else if (num == 3)
{
    Console.WriteLine("You chose Tecno and your bill is N" + tecnoPrice);
}
else
{
    Console.WriteLine("Invalid input");
}
    















