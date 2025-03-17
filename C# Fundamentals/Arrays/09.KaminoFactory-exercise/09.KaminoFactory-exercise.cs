int stringsLength = int.Parse(Console.ReadLine());
string command;
int max = 0;
int index = int.MaxValue;
int maxSum = 0;
int sample = 1;
int bestSampleNumber = 0;
int[] bestDna = new int[stringsLength];
while ((command = Console.ReadLine()) != "Clone them!")
{
    int sum = 0;
    int[] dna = command.Split('!', StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToArray();
    for (int i = 0; i < dna.Length; i++)
    {
        sum += dna[i];
    }
    for (int i = 0; i < dna.Length; i++)
    {
        int count = 1;
        for (int j = i + 1; j < dna.Length; j++)
        {
            if (dna[i] == 1 && dna[i] == dna[j])
            {
                count++;
            }
            else
            {
                break;
            }
        }
        if (count > max || (count == max && i < index) || (count == max && i == index && sum > maxSum))
        {
            max = count;
            maxSum = sum;
            index = i;
            bestDna = dna;
            bestSampleNumber = sample;
        }
    }
    sample++;
}
Console.WriteLine($"Best DNA sample {bestSampleNumber} with sum: {maxSum}.");
Console.WriteLine(string.Join(" ", bestDna));