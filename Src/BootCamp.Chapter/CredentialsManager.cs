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
                    string[] temp = credentials1.Password.Split(" ");
                    var bytes = new byte[temp.Length];
                    for(int i =0; i < bytes.Length -1; i++)
                    {
                       bytes[i] = Convert.ToByte(temp[i]);
                    }
                    credentials1.Password = Encoding.Unicode.GetString(bytes);
                    if (credentials1.Equals(credentials))
                        return true;
                }                         
            }
            return false;
        }

        // TODO: store credentials in credentials file.
        public void Register(Credentials credentials)
        {
            if (!File.Exists(_credentialsFile))
            {
                StreamWriter sw = File.AppendText(_credentialsFile);
                sw.Write(credentials.ToString());
                sw.Close();
                return;
            }
            bool isEmpty = CheckFileEmpty(_credentialsFile);
            string newUser = credentials.ToString();
            using (StreamWriter sw = File.AppendText(_credentialsFile))
            {
                if (isEmpty)
                    sw.Write(newUser);
                else                  
                    sw.Write(System.Environment.NewLine + newUser);
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
       private bool CheckFileEmpty(string path)
        {
            OpenFile(path);
            if (list.Count == 0)
                return true;
            return false;
        }

    }
}
