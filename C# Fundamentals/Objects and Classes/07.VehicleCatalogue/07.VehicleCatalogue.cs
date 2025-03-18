Catalogue catalogue = new Catalogue();
string command;
while ((command = Console.ReadLine()) != "end")
{
    string[] item = command.Split('/');
    if (item[0] == "Car")
    {
        Car car = new Car { Brand = item[1], Model = item[2], HorsePower = double.Parse(item[3]) };
        catalogue.Cars.Add(car);
    }
    else
    {
        Truck truck = new Truck { Brand = item[1], Model = item[2], Weight = double.Parse(item[3]) };
        catalogue.Trucks.Add(truck);
    }
}
if (catalogue.Cars.Count > 0)
{
    List <Car> newCars = catalogue.Cars.OrderBy(x => x.Brand).ToList();
    Console.WriteLine("Cars:");
    foreach (var item in newCars)
    {
        Console.WriteLine($"{item.Brand}: {item.Model} - {item.HorsePower}hp");
    }
}
if (catalogue.Trucks.Count > 0)
{
    List<Truck> newTrucks = catalogue.Trucks.OrderBy(x => x.Brand).ToList();
    Console.WriteLine("Trucks:");
    foreach (var item in newTrucks)
    {
        Console.WriteLine($"{item.Brand}: {item.Model} - {item.Weight}kg");
    }
}
class Truck
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double Weight { get; set; }
}
class Car
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public double HorsePower { get; set; }
}
class Catalogue
{
    public List<Truck> Trucks { get; set; }
    public List<Car> Cars { get; set; }
    public Catalogue()
    {
        Trucks = new List<Truck>();
        Cars = new List<Car>();
    }
}