int countOfTheWord = int.Parse(Console.ReadLine());
string output = "";
while (countOfTheWord > 0)
{
    string input = Console.ReadLine();
    if (input.Length == 1)
    {
        int number = int.Parse(input[0].ToString());
        if (number == 0) output += " ";
        else if (number == 2) output += "a";
        else if(number == 3) output += "d";
        else if(number == 4) output += "g";
        else if(number == 5) output += "j";
        else if(number == 6) output += "m";
        else if(number == 7) output += "p";
        else if(number == 8) output += "t";
        else if(number == 9) output += "w";
    }
    else if (input.Length == 2)
    {
        int number = int.Parse(input[0].ToString());
        if (number == 2) output += "b";
        else if(number == 3) output += "e";
        else if(number == 4) output += "h";
        else if(number == 5) output += "k";
        else if(number == 6) output += "n";
        else if(number == 7) output += "q";
        else if(number == 8) output += "u";
        else if(number == 9) output += "x";
    }
    else if (input.Length == 3) 
    {
        int number = int.Parse(input[0].ToString());
        if (number == 2) output += "c";
        else if (number == 3) output += "f";
        else if (number == 4) output += "i";
        else if (number == 5) output += "l";
        else if (number == 6) output += "o";
        else if (number == 7) output += "r";
        else if (number == 8) output += "v";
        else if (number == 9) output += "y";
    }
    else
    {
        int number = int.Parse(input[0].ToString());
        if (number == 7) output += "s";
        else if (number == 9) output += "z";
    }
    countOfTheWord--;
}
Console.WriteLine(output);