double numberA = double.Parse(Console.ReadLine());
double numberB = double.Parse(Console.ReadLine());
const double eps = 0.000001;
double difference = Math.Abs(numberA - numberB);
if (difference > eps) Console.WriteLine("False");
else Console.WriteLine("True");