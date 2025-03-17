string command = Console.ReadLine();
int firstNumber = int.Parse(Console.ReadLine());
int secondNumber = int.Parse(Console.ReadLine());
if (command == "add")
{
    Add(firstNumber, secondNumber);
}
else if (command == "multiply")
{
    Multiply(firstNumber, secondNumber);
}
else if(command == "subtract")
{
    Subtract(firstNumber, secondNumber);
}
else
{
    Divide(firstNumber, secondNumber);
}
static void Add(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber + secondNumber);
}
static void Multiply(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber * secondNumber);
}
static void Subtract(int firstNumber, int secondNumber)
{
    Console.WriteLine(Math.Abs(firstNumber-secondNumber));
}
static void Divide(int firstNumber, int secondNumber)
{
    Console.WriteLine(firstNumber / secondNumber);
}