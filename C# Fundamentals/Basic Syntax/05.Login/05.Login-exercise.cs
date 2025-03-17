string username = Console.ReadLine();
string password = "";
for (int i = username.Length - 1; i >= 0; i--)
{
    password += username[i];
}
int attempts = 4;
while (attempts > 0)
{
    attempts--;
    if (Console.ReadLine() == password)
    {
        Console.WriteLine($"User {username} logged in.");
        return;
    }
    else
    {
        if (attempts == 0)
        {
            Console.WriteLine($"User {username} blocked!");
            return;
        }
        else Console.WriteLine("Incorrect password. Try again.");
    }
}