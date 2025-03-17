string input = Console.ReadLine();
while (input != "END")
{
    int number = int.Parse(input);
    if (IsPalindrome(number))
    {
        Console.WriteLine("true");
    }
    else
    {
        Console.WriteLine("false");
    }
    input = Console.ReadLine();
}
static bool IsPalindrome(int number)
{
    string palindrome = "";
    int numberCopy = number;
    while (number > 0)
    {
        palindrome += number % 10;
        number /= 10;
    }
    return int.Parse(palindrome) == numberCopy;
}