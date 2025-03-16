double budget = double.Parse(Console.ReadLine());
int videoCardsCount = int.Parse(Console.ReadLine());
int processorsCount = int.Parse(Console.ReadLine());
int ramMemoryCount = int.Parse(Console.ReadLine());

int videoCardsPrizePerOne = 250;
double processorsPrizePerOne = (videoCardsCount * 250) * 0.35;
double ramMemoryPrizePerOne = (videoCardsCount * 250) * 0.1;

int videoCardsPrize = videoCardsCount * videoCardsPrizePerOne;
double processorsPrize = processorsCount * processorsPrizePerOne;
double ramMemoryPrize = ramMemoryCount * ramMemoryPrizePerOne;

double total = videoCardsPrize + processorsPrize + ramMemoryPrize;

if (videoCardsCount > processorsCount) total = total - (total * 0.15);

if (total <= budget) Console.WriteLine($"You have {budget - total:f2} leva left!");
else Console.WriteLine($"Not enough money! You need {total - budget:f2} leva more!");