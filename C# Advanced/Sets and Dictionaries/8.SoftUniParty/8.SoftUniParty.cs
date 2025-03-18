HashSet<string> VIPGuests = new HashSet<string>();
HashSet<string> normalGuests = new HashSet<string>();
string command;
while ((command = Console.ReadLine()) != "PARTY")
{
    string guestName = command;
    if (char.IsDigit(guestName[0]))
    {
        VIPGuests.Add(guestName);
    }
    else
    {
        normalGuests.Add(guestName);
    }
}
while ((command = Console.ReadLine()) != "END")
{
    string guestName = command;
    if (VIPGuests.Contains(guestName))
    {
        VIPGuests.Remove(guestName);
    }
    else
    {
        normalGuests.Remove(guestName);
    }
}
Console.WriteLine(VIPGuests.Count + normalGuests.Count);
foreach (string guest in VIPGuests)
{
    Console.WriteLine(guest);
}
foreach (string guest in normalGuests)
{
    Console.WriteLine(guest);
}