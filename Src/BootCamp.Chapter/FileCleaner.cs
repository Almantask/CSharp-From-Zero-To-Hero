using System.IO;

namespace BootCamp.Chapter
{
    public static class FileCleaner
    {
        /// <summary>
        /// Cleans up dirtyFileName 
        /// </summary>
        /// <param name="dirtyFile">Dirty file with "_" placed in random places.</param>
        /// <param name="cleanedFile">Cleaned up file without any "_".</param>
        public static void Clean(string dirtyFile, string cleanedFile)
        {
            var fileContent = File.ReadAllText(dirtyFile);
            fileContent = fileContent.Replace("_", "");
            File.WriteAllText(cleanedFile, fileContent);
        }
    }
}
