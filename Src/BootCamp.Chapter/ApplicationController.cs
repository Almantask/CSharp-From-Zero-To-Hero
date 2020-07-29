using System;
using System.Text;
using BootCamp.Chapter.Commands;

namespace BootCamp.Chapter
{
    class ApplicationController
    {
        private string[] _inputArguments;
        private string _inputPath;
        private string _cmd;
        private string _outputPath;
        private TransactionDataParser _transactionDataParser;

        public ApplicationController(string[] initInputArguments)
        {

            if (!ArgumentsParser.TryParse(initInputArguments, out string [] inputArguments)) throw new ArgumentException("Input Arguments are not valid");
            _inputArguments = inputArguments;
            _inputPath = _inputArguments[0];
            _cmd = _inputArguments[1];
            _outputPath = _inputArguments[2];
            _transactionDataParser = new TransactionDataParser(_inputPath);
        }

        public void Run()
        {
            string[] cmd = _cmd.Split(' ');

            Enum.TryParse(cmd[0].ToLower(), out Command command);

            switch (command)
            {
                case Command.city:
                    CityCommand cityCommand = new CityCommand(_cmd, _outputPath);
                    cityCommand.ExecuteCommand(_transactionDataParser);
                    break;

                case Command.daily:
                    DailyCommand dailyCommand = new DailyCommand(_cmd, _outputPath, _transactionDataParser);
                    dailyCommand.ExecuteCommand(_transactionDataParser);
                    break;

                case Command.full:
                    FullCommand fullCommand = new FullCommand(_inputPath, _outputPath, _transactionDataParser);
                    fullCommand.ExecuteCommand(_transactionDataParser);
                    break;

                case Command.time:
                    TimeCommand timeCommand = new TimeCommand(_inputPath, _outputPath);
                    timeCommand.ExecuteCommand(_transactionDataParser);
                    break;

                default:
                    Console.WriteLine("Error: No command executed");
                    break;
            }
        }
    }
}
