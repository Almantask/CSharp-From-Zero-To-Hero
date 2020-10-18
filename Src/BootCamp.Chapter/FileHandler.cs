using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace BootCamp.Chapter
{
    public class FileHandler
    {
        private readonly string _fullFilePath;

        public FileHandler(string fullFilePath)
        {
            _fullFilePath = fullFilePath;
        }

        public List<string> ReadFromFile()
        {
            if (File.Exists(_fullFilePath))
            {
                try
                {
                    return File.ReadAllLines(_fullFilePath).ToList();
                }
                catch (Exception ex)
                {
                    throw new FileIOException($"Error reading file:{_fullFilePath}", ex);
                }
            }

            List<string> emptyList = new List<string>();
            return emptyList;
        }

        public void AppendToFile(string userData)
        {
            List<string> currentSavedUSers = ReadFromFile();
            currentSavedUSers.Add(userData);

            try
            {
                File.WriteAllLines(_fullFilePath, currentSavedUSers);
            }
            catch (Exception ex)
            {
                throw new FileIOException($"Error writing to file:{_fullFilePath}", ex);
            }

            Console.WriteLine("User sucessfully stored.");
        }
    }
}
