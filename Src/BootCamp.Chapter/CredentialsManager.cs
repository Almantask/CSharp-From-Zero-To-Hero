using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace BootCamp.Chapter
{
    public class CredentialsManager
    {
        private readonly string _credentialsFile;
        private List<string> list;

        public CredentialsManager(string credentialsFile)
        {
            CheckInput(credentialsFile);
            _credentialsFile = credentialsFile;          
        }

        // TODO: load credentials and check for equality.
        public bool Login(Credentials credentials)
        {
            OpenFile(_credentialsFile);
            foreach (var credit in list)
            {
                bool isCredit = Credentials.TryParse(credit ,out Credentials credentials1);
                if(isCredit)
                {
                    string[] temp = credentials1.Password.Trim().Split(" ");
                var bytes = new byte[temp.Length];
                for(int i =0; i < bytes.Length -1; i++)
                {
                    bytes[i] = Convert.ToByte(temp[i]);
                }
                credentials1.Password = Encoding.Unicode.GetString(bytes);
                }
                
                Console.WriteLine(credentials1.Password);
                if (credentials1.Equals(credentials))
                    return true;             
            }
            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            string newUser = credentials.ToString();
            using (StreamWriter sw = File.AppendText(_credentialsFile))
            {
                sw.WriteLine(newUser);
            }
        }
        private void CheckInput(string a)
        {
            if (string.IsNullOrEmpty(a))
            {
                throw new ArgumentException("Input is invalid.");
            }
        }
        private void OpenFile(string path)
        {
            var file = File.Open(path, FileMode.Open);
            list = new List<string>();
            using (var stream = new StreamReader(file))
            {
                while (!stream.EndOfStream)
                {
                    list.Add(stream.ReadLine());
                }
            }
        }
    }
}
