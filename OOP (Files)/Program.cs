string filePath = @"C:\Users\alhan\Desktop\FileTask.txt";

FileStream readFrom = new FileStream(filePath, FileMode.Open);
using StreamReader readNow = new StreamReader(readFrom);
string pointer;
int charactersNumber = 0;

while ((pointer = readNow.ReadLine()) != null)
{
    var woredsInLine = pointer.Split("|");
    foreach (var wored in woredsInLine)
    {
        charactersNumber += wored.Length;
    }
    Console.WriteLine(pointer);
}
Console.WriteLine($"The number of characters in file ={charactersNumber}");

