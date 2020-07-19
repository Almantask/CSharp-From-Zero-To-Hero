using System;

namespace BootCamp.Chapter
{
    public class TimeCommand : ICommand, ICsvBrowser
    {
        private TimeSpan[] _timeSpans;
        private string _inputCommand;

        public TimeCommand(string inputCommand)
        {
            _timeSpans = default;
            _inputCommand = inputCommand;
        }

        public void BrowseCsv(string inputCsvPath)
        {
            throw new NotImplementedException();
        }

        public bool VerifyCommand(string inputCommand)
        {
            string[] splitCommand = inputCommand.Split(' ');

            if (splitCommand.Length != 1)
            {
                string[] splitTimeFilter = splitCommand[1].Split('-');

                bool time1Check = TimeSpan.TryParse(splitTimeFilter[0], out TimeSpan time1)
                    ? true
                    : throw new ArgumentException(
                        $"Time Frame given is not legitimate {splitTimeFilter[0]}. It should be [HH:mm-HH:mm]");
                bool time2Check = TimeSpan.TryParse(splitTimeFilter[1], out TimeSpan time2)
                    ? true
                    : throw new ArgumentException(
                        $"Time Frame given is not legitimate {splitTimeFilter[1]}. It should be [HH:mm-HH:mm]");

                _timeSpans = new TimeSpan[2]{time1, time2};

                return true;

            }

            return true;
        }
    }
}