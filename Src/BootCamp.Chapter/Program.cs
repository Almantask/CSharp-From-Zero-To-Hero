using System;
using System.Data;
using System.IO;
using System.Net.Http;
using System.Text;

namespace BootCamp.Chapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //DemoFinally();
            //DemoExplicitCatch()
            //DemoValidationAndCustomExceptions()
            //DemoHighLevelFile();
            //DemoFileStream();
            //DemoNoUsingForStream();
            DemoModifyFileMeta();
        }

        private static void DemoModifyFileMeta()
        {
            const string directory = @"C:\Lesson\cool";
            Console.WriteLine(Directory.CreateDirectory(directory));
            var files = Directory.GetFiles(@"C:\Lesson\");
            foreach (var file in files)
            {
                Console.WriteLine(file);
                var newFile = Path.GetFileName(Path.ChangeExtension(file, "")[..^1]);
                var newFileName = $@"C:\Lesson\backup\{newFile}";
                Console.WriteLine(newFileName);
                var backupFile = Path.GetFileName(newFileName + ".backup");
                var backupName = $@"C:\Lesson\backup\{backupFile}";
                if (file.Contains(".backup")) continue;

                File.Replace(file, newFileName, backupName);
            }

            File.WriteAllText(@"C:\Lesson\testing.txt", "");
            File.Move(@"C:\Lesson\testing.txt", @"C:\Lesson\testing.Kaisinel");
        }

        private static void DemoNoUsingForStream()
        {
            const string messageProcessingHandler = "Hello world!";
            const string file = @"C:\Lesson\8.txt";
            StreamWriter writer = new StreamWriter(file, true);
            writer.Write(messageProcessingHandler);

            // Throws, unless we close it
            writer.Dispose();
            StreamReader reader = new StreamReader(file);
            var contents = reader.ReadToEnd();
            writer.Dispose();
            Console.WriteLine(contents);
        }

        private static void DemoFileStream()
        {
            const string messageProcessingHandler = "Hello world!";
            const string file = @"C:\Lesson\8.txt";
            using (StreamWriter writer = new StreamWriter(file, true))
            {
                writer.Write(messageProcessingHandler);
            }

            using (StreamReader reader = new StreamReader(file))
            {
                var contents = reader.ReadToEnd();
                Console.WriteLine(contents);
            }
        }

        private static void DemoHighLevelFile()
        {
            const string messageProcessingHandler = "Hello world!";
            const string file = @"C:\Lesson\8.txt";
            var insideAFile = File.ReadAllText(file);
            Console.WriteLine($"Before write: {insideAFile}");
            File.AppendAllText(file, messageProcessingHandler);
            insideAFile = File.ReadAllText(file);
            Console.WriteLine($"After write:  {insideAFile}");
        }

        private static void DemoValidationAndCustomExceptions()
        {
            const string age = "a";

            try
            {
                ValidatePerson("Tom", age);
            }
            catch
            {
                Console.WriteLine("Failed in main...");
                throw;
            }

            Console.WriteLine(age + " is a valid age.");
        }

        private static void ValidatePerson(string name, string age)
        {
            if (name == null) throw new NoNullAllowedException($"{nameof(name)} cannot be null.");
            if (age == null) throw new NoNullAllowedException($"{nameof(age)} cannot be null");

            var isNumber = int.TryParse(age, out var ageInt);
            if (!isNumber) throw new InvalidAgeException(age, $"{age} is not a number");

            if (ageInt > 200 || ageInt < 0) throw new InvalidAgeException(age, $"{age} needs to be less than 200 and more than 0.");
        }

        private static void DemoExplicitCatch()
        {
            try
            {
                ((object)null).ToString();
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Oops. Argument out of range"); // won't be hit.
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("Oops. Null reference"); // will be hit.
            }
        }

        private static void DemoFinally()
        {
            try
            {
                ((object)null).ToString();
            }
            finally
            {
                Console.WriteLine("Oh well. Life goes on.");
            }

            Console.WriteLine("Or does it?"); // doesn't get printed


            try
            {
                ((object)null).ToString();
            }
            catch (Exception ex)
            {

            }
            finally
            {
                Console.WriteLine("Oh well. Life goes on.");
            }

            Console.WriteLine("Or does it?"); // gets printed.
        }
    }
}
