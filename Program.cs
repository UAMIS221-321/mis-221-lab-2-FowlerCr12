// an application to help Sherlenthia calculate how much she's charging her customers on National Sandwich Day.
// The application will collect the number of sandwiches, number of toppings, and any tips.
// - Each sandwich is $4.75, and each topping on the sandwich is priced at $0.55
// Sherlengthia provides a 10% discount on the entire order.
// Ask the user for the tip expressed as a decimal.

double COST_OF_TOPPING = 0.55;
double COST_OF_SANDWICH = 4.75;
double DISCOUNT_AMOUNT = 0.10;


double tip = CalculateTip();
double totalToppingCost = Number_Of_Topping() * COST_OF_TOPPING;
double totalSandwichCost = Number_Of_Sandwich() * COST_OF_SANDWICH;
double baseCost = totalSandwichCost + totalToppingCost;
double orderCost = tip + baseCost * (1-DISCOUNT_AMOUNT);
Console.WriteLine($"Your order cost is " + orderCost);

static double CalculateTip(){
    Console.WriteLine("Please enter your tip");
    return double.Parse(Console.ReadLine());
}

static double Number_Of_Topping(){
    Console.WriteLine("How many toppings do you want?");
    return double.Parse(Console.ReadLine());
}

static double Number_Of_Sandwich(){
    Console.WriteLine("How many sandwiches do you want?");
    return double.Parse(Console.ReadLine());
}