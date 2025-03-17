int n = int.Parse(Console.ReadLine());
int openCount = 0;
bool lastWasOpen = false;
for (int i = 0; i < n; i++)
{
    string line = Console.ReadLine();
    foreach (char ch in line)
    {
        if (ch == '(')
        {
            if (lastWasOpen)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            openCount++;
            lastWasOpen = true;
        }
        else if (ch == ')')
        {
            if (openCount == 0)
            {
                Console.WriteLine("UNBALANCED");
                return;
            }
            openCount--;
            lastWasOpen = false;
        }
        else lastWasOpen = false;
    }
}
if (openCount == 0) Console.WriteLine("BALANCED");
else Console.WriteLine("UNBALANCED");