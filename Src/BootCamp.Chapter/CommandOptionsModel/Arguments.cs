using System;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.Text;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter.CommandOptionsModel
{
    public class Arguments
    {
        private readonly Dictionary<string, string> Parameters = new Dictionary<string, string>();

        public Arguments(string[] args)
        {
            var splitter = new Regex(@"^-{1,2}|^/=|:", RegexOptions.IgnoreCase);
            var remover = new Regex(@"^['""]?(.*?)['""]?$", RegexOptions.IgnoreCase);

            var parameter = string.Empty;

            foreach (var argument in args)
            {
                var parts = splitter.Split(argument, 2);

                switch (parts.Length)
                {
                    case 1:
                        if (parameter.IsValid())
                        {
                            if (Parameters.ContainsKey(parameter))
                            {
                                parts[0] = remover.Replace(parts[0], "$1");
                                Parameters.Add(parameter, parts[0]);
                            }
                            parameter = string.Empty;
                        }
                        break;

                    case 2:
                        if (parameter.IsValid())
                        {
                            if (!Parameters.ContainsKey(parameter))
                            {
                                Parameters.Add(parameter, "true");
                            }
                        }
                        parameter = parts[1];
                        break;

                    case 3:
                        if (parameter.IsValid())
                        {
                            if (!Parameters.ContainsKey(parameter))
                            {
                                Parameters.Add(parameter, "true");
                            }
                        }
                        parameter = parts[1];
                        if (!Parameters.ContainsKey(parameter))
                        {
                            parts[2] = remover.Replace(parts[2], "$1");
                            Parameters.Add(parameter, parts[2]);
                        }
                        parameter = string.Empty;
                        break;

                    default:
                        if (!parameter.IsValid())
                        {
                            if (!Parameters.ContainsKey(parameter))
                            {
                                Parameters.Add(parameter, "true");
                            }
                        }
                        break;
                }
            }
        }

        public string this[string parameter]
        {
            get
            {
                return Parameters[parameter];
            }
        }
    }
}