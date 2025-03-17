string password = Console.ReadLine();
Validator(password);
static void Validator(string password)
{
    int digitCount = 0;
    bool isCharacter = true;
    if (password.Length >= 6 && password.Length <= 10)
    {
        for (int i = 0; i < password.Length; i++)
        {
            if (char.IsDigit(password[i]))
            {
                digitCount++;
            }
            if ((password[i] >= 32 && password[i] <= 42) || (password[i] >= 58 && password[i] <= 64) || (password[i] >= 91 && password[i] <= 96) || (password[i] >= 123 && password[i] <= 127))
            {
                isCharacter = false;
                Console.WriteLine("Password must consist only of letters and digits");
                break;

            }
        }
    }
    else
    {
        Console.WriteLine("Password must be between 6 and 10 characters");
    }
    if (digitCount < 2)
    {
        Console.WriteLine("Password must have at least 2 digits");
    }
    if (password.Length >= 6 && password.Length <= 10 && digitCount >= 2 && isCharacter == true) 
    {
        Console.WriteLine("Password is valid");
    }
}