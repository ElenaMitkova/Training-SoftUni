using System.Text;

List<Vehicle> vehicles = new List<Vehicle>();
string input;
while ((input = Console.ReadLine()) != "End")
{
    string[] commands = input.Split();
    vehicles.Add(new Vehicle(commands[0], commands[1], commands[2], decimal.Parse(commands[3])));
}
while ((input = Console.ReadLine()) != "Close the Catalogue")
{
    var newVehicles = vehicles.Where(vehicle => vehicle.Model == input).ToList();
    newVehicles.ForEach(vehicle => Console.WriteLine(vehicle));
}
var average = vehicles.Where(car => car.TypeOfVehicle == "car").Select(car => car.HP).DefaultIfEmpty().Average();
Console.WriteLine($"Cars have average horsepower of: {average:F2}.");
average = vehicles.Where(truck => truck.TypeOfVehicle == "truck").Select(truck => truck.HP).DefaultIfEmpty().Average();
Console.WriteLine($"Trucks have average horsepower of: {average:F2}.");
class Vehicle
{
    public Vehicle(string typeOfVehicle, string model, string color, decimal hP)
    {
        TypeOfVehicle = typeOfVehicle;
        Model = model;
        Color = color;
        HP = hP;
    }
    public string TypeOfVehicle { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }
    public decimal HP { get; set; }
    public override string ToString()
    {
        StringBuilder stringBuilder = new StringBuilder();
        string type = TypeOfVehicle == "car" ? "Car" : "Truck";
        stringBuilder.AppendLine($"Type: {type}");
        stringBuilder.AppendLine($"Model: {Model}");
        stringBuilder.AppendLine($"Color: {Color}");
        stringBuilder.Append($"Horsepower: {HP}");
        return stringBuilder.ToString();
    }
}