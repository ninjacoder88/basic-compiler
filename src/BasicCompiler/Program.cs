// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter file path");
string? filePath = Console.ReadLine();

if(string.IsNullOrEmpty(filePath))
{
    Console.WriteLine("invalid file");
    return;
}

if(!File.Exists(filePath))
{
    Console.WriteLine("invalid file path");
    return;
}

using(var streamReader = new StreamReader(filePath))
{
    while(!streamReader.EndOfStream)
    {
        string? fileLine = streamReader.ReadLine();

        if(string.IsNullOrEmpty(fileLine))
        {
            continue;
        }

        foreach(var character in fileLine)
        {
            
        }
    }
}