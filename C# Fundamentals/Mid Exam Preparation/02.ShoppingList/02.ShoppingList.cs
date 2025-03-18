List<string> shoppingList = Console.ReadLine().Split('!').ToList();
string command;
while ((command = Console.ReadLine()) != "Go Shopping!")
{
    string[] commands = command.Split();
    switch (commands[0])
    {
        case "Urgent":
            string item = commands[1];
            if (!shoppingList.Contains(item))
            {
                shoppingList.Insert(0, item);
            }
            break;
        case "Unnecessary":
            string unItem = commands[1];
            if (shoppingList.Contains(unItem))
            {
                shoppingList.Remove(unItem);
            }
            break;
        case "Correct":
            string oldName = commands[1];
            string newName = commands[2];
            if (shoppingList.Contains(oldName))
            {
                int index = shoppingList.IndexOf(oldName);
                shoppingList.RemoveAt(index);
                shoppingList.Insert(index, newName);
            }
            break;
        case "Rearrange":
            string reItem = commands[1];
            if (shoppingList.Contains(reItem))
            {
                shoppingList.Remove(reItem);
                shoppingList.Add(reItem);
            }
            break;
    }
}
Console.WriteLine(string.Join(", ", shoppingList));