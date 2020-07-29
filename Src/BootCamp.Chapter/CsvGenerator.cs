using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Text;
using BootCamp.Chapter.Commands;

namespace BootCamp.Chapter
{
    class CsvGenerator : ICsvGenerator where T : Command
    {
        private enum Commands
        {
            CityCommand,
            DailyCommand,
            TimeCommand,
            FullCommand
        }
        /*
        private void ExecuteCsvGeneration()
        {
            Enum.TryParse(typeof(T).ToString(), out Commands command);
            switch (command)
            {
                case Commands.CityCommand:
                    currentCommand = command;
                    GenerateCsvCity();
                    break;

                case Commands.DailyCommand:
                    currentCommand = command;
                    GenerateCsvDaily();
                    break;

                case Commands.FullCommand:
                    currentCommand = command;
                    GenerateCsvFull();
                    break;

                case Commands.TimeCommand:
                    currentCommand = command;
                    GenerateCsvTime();
                    break;

                default:
                    throw new ArgumentException("Csv Generation can only be executed on ICommand components");
            }

        }
        */

        // change name
        public void GenericCsvGeneration<T>(T dictionary, string outputFileName, string fileHeading, string outputDestination) where T : IDictionary<object, object>
        {
            try
            {
                int count = 0;
                // ToDO: Make the file name generic (or at least the implementation) 

                using (StreamWriter writer = new StreamWriter(File.Create($@"{outputDestination}//{outputFileName}.csv")))
                {
                    while (true)
                    {
                        if (count == 0)
                        {
                            // Writes Heading

                            // ToDO: Generic Heading Creation
                            writer.WriteLine(fileHeading);
                            count++;
                        }
                        else
                        {
                            // Writes the other lines
                            // ToDo: Make the for-loop generic
                            foreach (var pair in dictionary)
                            {
                                writer.WriteLine($"{pair.Key},{pair.Value}");
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
        }

        private void CommandSpecificExecution()
        {

        }

        private void CityForLoop(StreamWriter writer)
        {
            foreach (var pair in ResultsOfCommand)
            {
                writer.WriteLine($"{pair.Key},{pair.Value}");
            }
        }

        private void TimeForLoop(StreamWriter writer)
        {
            foreach (var hour in ResultsOfCommand)
            {
                if (hour.Key == highestHour)
                {
                    writer.WriteLine($"{hour.Key},{hour.Value[0]},{hour.Value[1]},RushHour");
                }
                else
                {
                    writer.WriteLine($"{hour.Key},{hour.Value[0]},{hour.Value[1]}");
                }
            }
        }

        private void FullForLoop(StreamWriter writer, IDictionary<Transaction, object> ResultsOfCommand)
        {
            foreach (var transaction in ResultsOfCommand)
            {
                writer.WriteLine($"{transaction.Location}, {transaction.StreetName}, {transaction.ItemName}, {transaction.TimePurchased}, {transaction.Price.ToString().Replace('.', ',')} €");
            }
        }

        private void DailyForLoop(StreamWriter writer)
        {
            foreach (var keyValue in ResultsOfCommand)
            {
                writer.WriteLine($"{keyValue.Key},{keyValue.Value.Sum()}");
            }

            writer.WriteLine($"Total:,{ResultsOfCommand.Sum(x => x.Value.Sum())}");
        }
    }
}
