double[] money = { 500, 200, 100, 50, 20, 10, 5, 2, 1, 0.5, 0.2, 0.1 }; //value of currency
double[] change = { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 }; //the number of each bill or coin given

Console.WriteLine("Price of object");
double price = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("How much will the customer give");
double given = Convert.ToDouble(Console.ReadLine());
double remainder = given - price;
if (given >= price && remainder > 0)
{
    Console.WriteLine("*** Total change: " + remainder + " ***");
    // two conditions have to meet to avoid an infinint loop first is the remainder is positive and making sure the client will receive change
    for (int i = 0; money.Length > i; i++)
    {
        //divides remainder and money to know how many bills or coins to give and then saves the residual as the new remainder
        change[i] = (int)(remainder / money[i]);
        remainder = remainder % money[i];
    }
    // since the change is calculated from largest bill to least this is to print the amount received from smallest monetary value to largest
    for (int i = change.Length - 1; i >= 0; i--)
    {
        if (change[i] != 0)
        {
            Console.WriteLine(money[i] + " : " + change[i]);
        }
    }
}
else if (remainder == 0)
{ // condition to see if change should not be given
    Console.WriteLine("No change");
}
else
{ // if no condition is meet the client cant afford the object
    Console.WriteLine("Can't afford");
}
