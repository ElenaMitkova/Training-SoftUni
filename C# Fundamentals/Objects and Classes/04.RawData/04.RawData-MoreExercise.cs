List<Car> cars = new List<Car>();
int counter = int.Parse(Console.ReadLine());
for (int i = 0; i < counter; i++)
{
    string[] arguments = Console.ReadLine().Split();
    cars.Add(new Car(arguments[0], new Engine(int.Parse(arguments[1]), int.Parse(arguments[2])), new Cargo(int.Parse(arguments[3]), arguments[4])));
}
string type = Console.ReadLine();
var newCars = cars;
if (type == "fragile")
{
    newCars = cars.Where(cargo => cargo.Cargo.Type == type && cargo.Cargo.Weight < 1000).ToList();
}
else
{
    newCars = cars.Where(cargo => cargo.Cargo.Type == type && cargo.Engine.Power > 250).ToList();
}
foreach (Car car in newCars)
{
    Console.WriteLine(car.Model);
}
class Car
{
    public Car(string model, Engine engine, Cargo cargo)
    {
        Model = model;
        Engine = engine;
        Cargo = cargo;
    }
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public Cargo Cargo { get; set; }
}
class Engine
{
    public Engine(int speed, int power)
    {
        Speed = speed;
        Power = power;
    }
    public int Speed { get; set; }
    public int Power { get; set; }
}
class Cargo
{
    public Cargo(int weight, string type)
    {
        Weight = weight;
        Type = type;
    }
    public int Weight { get; set; }
    public string Type { get; set; }
}