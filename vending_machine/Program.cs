
using System.Collections;

Console.WriteLine("=================== VENDING MACHINE =====================");

//======= CREATING THE TOOLS =======

Dictionary<int, int> moneyAvailable = new Dictionary<int, int>();

Dictionary<string, double> Items = new Dictionary<string, double>();

//int amountInput = 0;

string itemInput;

//======= FILLING THE VENDING MACHINE =======

moneyAvailable.Add(20, 15);

moneyAvailable.Add(10, 15);

moneyAvailable.Add(5, 15);

moneyAvailable.Add(2, 15);

moneyAvailable.Add(1, 15);


Items.Add("A", 1.0);

Items.Add("B", 2.0);

Items.Add("C", 1.5);

Items.Add("D", 3.5);

Items.Add("E", 2.0);

Items.Add("F", 3.0);

Items.Add("G", 5.5);

Items.Add("H", 10.0);

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


if (Items.ContainsKey(itemInput))
{
    if (itemInput == "CANCEL")
    {
        Console.WriteLine($"Operation cancelled, you can take your ${amountInput}.\nHave a great day!");
    }
    
    foreach(KeyValuePair <string, double> kvp in Items)
    {
        if (kvp.Key == itemInput)
        {
            if (kvp.Value < amountInput)
            {
                int returninMoney = amountInput - (int)kvp.Value;

                int fillingReturning;

                int updatingReturning;

                
                
                foreach(KeyValuePair<int, int> m in moneyAvailable)
                {
                    if (m.Key == returninMoney)
                    {
                        //Items.Add(m.Value[fillingReturning]);

                        Console.WriteLine($"Vending product {kvp.Key}, for ${kvp.Value}, returning ${m.Key}, thanks for your purchase!");
                    }
                    else if (m.Key < returninMoney)
                    {



                        Console.WriteLine($"Vending product {kvp.Key}, for ${kvp.Value}, returning ${m.Key}, thanks for your purchase!");

                    }


                 
               
                }


                
            }
            else if(kvp.Value == amountInput)
            {
                Console.WriteLine($"Vending product {kvp.Key}, for {kvp.Value}, no returning money, thanks for your purchase!");
            }
            else if(kvp.Value > amountInput)
            {
                Console.WriteLine("Not enough money, please enter $XX more");
                int moreMoneyInput = Int32.Parse(Console.ReadLine());
                amountInput += moreMoneyInput;
            }
        }
    }


}
else
{
    Console.WriteLine("Invalid input try again!");

    Console.WriteLine("Enter the name of the product you want to buy, or CANCEL to stop the operation");

    itemInput = Console.ReadLine().ToUpper();
}


