

// Estimating of the cost carpet cleaning

int pricepersmallcarpet = 25;
int priceperlargecarpet = 35;
float taxrate = 0.06F;

Console.Write(" enter number of small carpets: ");
int smallcarpetsnumber = Convert.ToInt32(Console.ReadLine());
Console.Write("enter numer of large carpets:");
int largecarpetsnumber = Convert.ToInt32(Console.ReadLine());

float cost = (smallcarpetsnumber * pricepersmallcarpet) + (largecarpetsnumber * priceperlargecarpet);
float tax = taxrate * cost;
float totalestimate = tax + cost;
Console.WriteLine("Estimate for carpet cleaning service");
Console.WriteLine($"Number of small carpets: {smallcarpetsnumber}");
Console.WriteLine($"Number of large carpets:{largecarpetsnumber}");
Console.WriteLine($"Price per small room: {pricepersmallcarpet:C}");
Console.WriteLine($"Price per large room: {priceperlargecarpet:C}");
Console.WriteLine($"Cost :{cost:C}");
Console.WriteLine($"tax : {tax:C}");
Console.WriteLine($"Total estimate: {totalestimate:C}");
Console.WriteLine($"This estimate is valid for 30 days:");
Console.ReadLine(); 