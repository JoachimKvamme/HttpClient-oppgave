using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HttpClient_oppgave
{
    public class FileMethod
    {
        public void WriteToFile(string path, string content)
        {
        if (string.IsNullOrWhiteSpace(path) && string.IsNullOrWhiteSpace(content))
        {
            Console.WriteLine("Could not open the filestream!");
        }
        else if (!File.Exists(path))
        {
            File.Create(path);
        }

        try
        {
            File.WriteAllText(path, content);
        }
        catch (Exception exception)
        {
            Console.WriteLine($"Error occurend when opening the filestream: {exception.Message}");
        }
        }
    }
}