int greenLightDuration = int.Parse(Console.ReadLine());
int freeWindowDuration = int.Parse(Console.ReadLine());
Queue<string> cars = new Queue<string>();
int totalCarsPassed = 0;
string command;
while ((command = Console.ReadLine()) != "END")
{
    if (command == "green")
    {
        int remainingGreenTime = greenLightDuration;
        while (remainingGreenTime > 0 && cars.Count > 0)
        {
            string currentCar = cars.Peek();
            if (currentCar.Length <= remainingGreenTime)
            {
                remainingGreenTime -= currentCar.Length;
                cars.Dequeue();
                totalCarsPassed++;
            }
            else
            {
                int remainingTime = remainingGreenTime + freeWindowDuration;
                if (currentCar.Length <= remainingTime)
                {
                    cars.Dequeue();
                    totalCarsPassed++;
                    break;
                }
                else
                {
                    Console.WriteLine("A crash happened!");
                    int crashPoint = remainingTime;
                    Console.WriteLine($"{currentCar} was hit at {currentCar[crashPoint]}.");
                    return;
                }
            }
        }
    }
    else
    {
        cars.Enqueue(command);
    }
}
Console.WriteLine("Everyone is safe.");
Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");