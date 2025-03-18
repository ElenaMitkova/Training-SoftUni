HashSet<string> cars = new HashSet<string>();
string command;
while ((command = Console.ReadLine()) != "END")
{
    string[] arguments = command.Split(", ");
    string direction = arguments[0];
    string car = arguments[1];
    if (direction == "IN")
    {
        cars.Add(car);
    }
    else
    {
        cars.Remove(car);
    }
}
if (cars.Count == 0)
{
    Console.WriteLine("Parking Lot is Empty");
    return;
}
foreach (string car in cars)
{
    Console.WriteLine(car);
}