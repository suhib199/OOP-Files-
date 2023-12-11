string filePath = @"C:\Users\alhan\Desktop\FileTask.txt";
string content = "|Name                |Specialization              |Age       |LifeDescription     |WorkField\n|Suhib Alhanafi      |Electrical Engineering      |24        |None                |Electrical Designing";
File.WriteAllText(filePath, content);

FileStream readFrom = new FileStream(filePath, FileMode.Open);
using StreamReader readNow = new StreamReader(readFrom);
string pointer;
int charactersNumber = 0;
int wordsNumber = 0;

while ((pointer = readNow.ReadLine()) != null)
{
    var wordsInLine = pointer.Split("|");
    foreach (var word in wordsInLine)
    {
        charactersNumber += word.Replace(" ","").Length;
    }
    for (int i=0;i<wordsInLine.Length ;i++)
    {
        if (wordsInLine[i].Trim().Contains(" "))
        {
            int wordsAfterRemoveSpaces = 0;
            var arrayOfWords = wordsInLine[i].Trim().Split(" ");
            wordsAfterRemoveSpaces= arrayOfWords.Length;
            wordsNumber += wordsAfterRemoveSpaces;
        }
        else
            wordsNumber++;
    }

    Console.WriteLine(pointer);
    wordsNumber--;
}
Console.WriteLine($"\nThe number of characters without spaces in file = {charactersNumber}");
Console.WriteLine($"The number of words without spaces in file = {wordsNumber}");

