using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Text.RegularExpressions;

namespace BootCamp.Chapter
{
    public class ImportTransactionsData
    {
        public List<Transactions> Data { get; private set; } = new List<Transactions>();

        public void AddTransaction(Transactions items)
        {
            Data.Add(items);
        }
        public void ImportTransactionsDataT(string inputFile)
        {
            ///<summary>
            ///     load transaction list
            ///</summary>
            try
            {
                StreamReader reader = new StreamReader(inputFile);

                using (reader)
                {
                    int lineNumber = 0;
                    // Read first line from the text file
                    string line = reader.ReadLine();

                    // Throw an exception because of empty file
                    if (line == null) throw new Exception();

                    // Read the other lines from the text file
                    while (line != null)
                    {
                        lineNumber++;
                        //Console.WriteLine("Line {0}: {1}", lineNumber, line);
                        line = reader.ReadLine();
                        bool ok = string.IsNullOrEmpty(line);

                        if (!ok)
                        {
                            //Microsoft.VisualBasic.FileIO.TextFieldParser parser = new Microsoft.VisualBasic.FileIO.TextFieldParser(new StringReader(line));
                            //parser.SetDelimiters(",");
                            //parser.HasFieldsEnclosedInQuotes = true;
                            //string[] values = parser.ReadFields();

                            string pattern = "(?:,|\n|^)(\"(?:(?:\"\")*[^\"]*)*\"|[^\",\n]*|(?:\n|$))";
                            Regex rg = new Regex(pattern);
                            List<string> inputDataList = new List<string>();
                            string[] regexData = rg.Split(line);

                            // remove empty string imported from regex

                            for (int i=0; i<regexData.Length; i++)
                            {
                                if (regexData[i] != "" && regexData[i] != " ") inputDataList.Add(regexData[i]);
                            }
                            string[] inputData = inputDataList.ToArray();

                            // remove " and € from price
                            string price = inputData[5];
                            string removeOne = price.Replace("\"", "");
                            price = removeOne.Replace("€", "");
                            inputData[5] = price;

                            AddTransaction(new Transactions(inputData[0], inputData[1], inputData[2], inputData[3], inputData[4], inputData[5]));
                        }
                    }
                }
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new FileNotFoundException();
            }
            catch (FileNotFoundException ex)
            {
                throw new NoTransactionsFoundException();
            }
            catch (Exception ex)
            {
                throw new NoTransactionsFoundException();
            }
            
        }


    }
}
