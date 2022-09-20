using System.IO;

string path = @"C:\Users\hello\OneDrive\Desktop\Sample.txt";
string secondLineText = "End of File";

//verbatim string literal
//verbatim: not interpreted

FileInfo newFile = new FileInfo(path);

using(StreamWriter writer = newFile.CreateText())
{
    writer.WriteLine(secondLineText);
    writer.WriteLine("Hello World!");
}

string line = "initial";

using(StreamReader reader = newFile.OpenText())
{
    line = reader.ReadLine();
    while(String.IsNullOrWhiteSpace(line))
    {
        
        string[] words = line.Split(' ');
        foreach(string word in words)
        {
            Console.WriteLine(word);
        }
        line = reader.ReadLine();
    }
}