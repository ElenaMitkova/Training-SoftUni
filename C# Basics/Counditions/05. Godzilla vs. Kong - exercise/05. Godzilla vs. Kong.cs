double budget = double.Parse(Console.ReadLine());
int statists = int.Parse(Console.ReadLine());
double prizeForClothesForOneStatists = double.Parse(Console.ReadLine());
double decoration = budget * 0.1;
double prizeForStatists = statists * prizeForClothesForOneStatists;
if (statists > 150) prizeForStatists = prizeForStatists - (prizeForStatists * 0.1);
double summary = prizeForStatists + decoration;
if (summary <= budget)
{
    Console.WriteLine("Action!");
    Console.WriteLine($"Wingard starts filming with {budget-summary:f2} leva left.");
}
else
{
    Console.WriteLine("Not enough money!");
    Console.WriteLine($"Wingard needs {summary-budget:f2} leva more.");
}