using System;
using System.IO;
public class FileIO
{
    public void LearnFileReading()
    {
        string filePath = @"G:\college\Semester 6\Dotnet\sangeer.negi\README.md";
        string fileWithInProject = "Generics.cs";
        if (File.Exists(fileWithInProject))
        {
            var fileContent = File.ReadAllText(fileWithInProject);
            Console.WriteLine(fileContent);
        }
    }

    public void LearnFileWriting()
    {
        string filePath = "Abc.txt";
        File.WriteAllText(filePath, "This is random file content");
    }
    public void LearnFileInfo()
    {
        string filePath = "Abc.txt";
        FileInfo fileInfo = new FileInfo(filePath);
        var size = fileInfo.Length;
        var createDate = fileInfo.CreationTime;
        Console.WriteLine(filePath);
        Console.WriteLine($"Size:{size} bytes");
        Console.WriteLine($"Created:{createDate}");
    }
    public void LearnDirectory()
    {
        string folderName="MBM";
        Directory.CreateDirectory(folderName);
        Console.WriteLine("Do you want to delete MBM folder?");
        string confirm=Console.ReadLine();
        if (confirm=="Y")
        {
            Directory.Delete(folderName);
        }
    }
}