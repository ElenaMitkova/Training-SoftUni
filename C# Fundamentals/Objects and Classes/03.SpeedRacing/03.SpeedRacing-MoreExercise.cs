List<Car> cars = new List<Car>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] arguments = Console.ReadLine().Split();
    cars.Add(new Car(arguments[0], int.Parse(arguments[1]), double.Parse(arguments[2])));
}
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] distance = input.Split();
    var thisCar = cars.Where(car => car.Model == distance[1]).First();
    if (thisCar.CanTravel(thisCar, double.Parse(distance[2])))
    {
        continue;
    }
    Console.WriteLine("Insufficient fuel for the drive");
}
foreach (Car car in cars)
{
    Console.WriteLine($"{car.Model} {car.FuelAmount:F2} {car.TravelledDistance}");
}
class Car
{
    public Car(string model, int fuelAmount, double fuelConsumption)
    {
        Model = model;
        FuelAmount = fuelAmount;
        FuelConsumption = fuelConsumption;
        TravelledDistance = 0;
    }
    public string Model { get; set; }
    public double FuelAmount { get; set; }
    public double FuelConsumption { get; set; }
    public double TravelledDistance { get; set; }
    public bool CanTravel(Car car, double distance)
    {
        if (distance * FuelConsumption <= FuelAmount)
        {
            FuelAmount -= distance * FuelConsumption;
            TravelledDistance += distance;
            return true;
        }
        return false;
    }
}