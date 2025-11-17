// See https://aka.ms/new-console-template for more information
using static System.Net.Mime.MediaTypeNames;
using System.IO;
class Program
{
    public void ViewTextFile()
    {
        int testy;
        testy = 0;

        string TextFileNumber1 = @"C:\Users\Perephiriya\source\repos\BuildTest1\BuildTest1\InvertReader.txt";
        string text = File.ReadAllText(TextFileNumber1);

        Console.WriteLine(text);
        return;
    }
    static public void Main()
    {
        Program obj = new Program();
        obj.ViewTextFile();
    }
}