using System;
using System.IO;
public class CreateDirectoryWithSub
{
    static void Main()
    {
        CreateDirectoryWithSub dir = new CreateDirectoryWithSub();
        dir.directory();
    }
    public void directory()
    {
        string folderName = @"G:\college\Semester 6\Dotnet\Nepal";
        Directory.CreateDirectory(folderName);
        string folderPath = @"G:\college\Semester 6\Dotnet\Nepal\";
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter the name of the sub folder");
            string[] fileName = new string[10];
            fileName[i] = Console.ReadLine();
            var Path = $"{folderPath}{fileName[i]}";
            Directory.CreateDirectory(Path);
            StreamWriter File = new StreamWriter($"{Path}\\test.txt");
            File.WriteLine(fileName[i]);
            File.Close();
        }
    }
}