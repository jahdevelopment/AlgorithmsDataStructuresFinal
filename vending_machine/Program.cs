
Console.WriteLine("=================== VENDING MACHINE =====================");

//======= CREATING THE TOOLS =======

Dictionary<int, int> moneyAvailable = new Dictionary<int, int>();

Dictionary<string, double> Items = new Dictionary<string, double>();

//int amountInput = 0;

string itemInput;

//======= FILLING THE VENDING MACHINE =======

moneyAvailable.Add(1, 15);

moneyAvailable.Add(2, 15);

moneyAvailable.Add(5, 15);

moneyAvailable.Add(10, 15);

moneyAvailable.Add(20, 15);

Items.Add("A", 1.0);

Items.Add("B", 2.0);

Items.Add("C", 1.5);

Items.Add("D", 3.5);

Items.Add("E", 2.0);

Items.Add("F", 3.0);

Items.Add("G", 5.5);

Items.Add("H", 4.5);

Items.Add("I", 4.0);

Items.Add("J", 3.0);


//======= CREATING THE LOGIC OF THE OPERATION =======

Console.WriteLine("\nEnter the amount of money you are filling:");

int amountInput = Int32.Parse(Console.ReadLine());

while (amountInput <= 0)
{
    Console.WriteLine("\nPlease enter a valid value, try again!\nEnter the amount of money you are filling:");

    amountInput = Int32.Parse(Console.ReadLine());
}

Console.WriteLine("Enter the name of the product you want to buy, or CANCEL to stop the operation");

itemInput = Console.ReadLine().ToUpper();

if (itemInput == "CANCEL")
{
    Console.WriteLine($"Operation cancelled, you can take your ${amountInput}.\nHave a great day!");


}
else if (!Items.ContainsKey(itemInput))
{
    Console.WriteLine("Invalid input try again!");

    Console.WriteLine("Enter the name of the product you want to buy, or CANCEL to stop the operation");

    itemInput = Console.ReadLine().ToUpper();
}

foreach (KeyValuePair<string, double> pair in Items)
{

}

