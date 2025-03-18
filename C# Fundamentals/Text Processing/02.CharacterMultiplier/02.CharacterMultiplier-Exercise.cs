string[] strings = Console.ReadLine().Split(' ');
string firstString = strings[0];
string secondString = strings[1];
int maxLength = Math.Max(firstString.Length, secondString.Length);
long sum = 0;
for (int i = 0; i < maxLength; i++)
{
	if (i < firstString.Length && i < secondString.Length)
	{
		sum += firstString[i] * secondString[i];
	}
	else if (i < firstString.Length)
	{

		sum += firstString[i];
	}
	else if (i < secondString.Length)
	{
		sum += secondString[i];
	}
}
Console.WriteLine(sum);