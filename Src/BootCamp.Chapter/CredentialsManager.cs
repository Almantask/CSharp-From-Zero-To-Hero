using System;
using System.Collections.Generic;
using System.IO;

namespace BootCamp.Chapter
{
	public class CredentialsManager
	{
		private string CredentialsFile { get; }

		public CredentialsManager(string credentialsFile)
		{
			//Throw argument exception if string is null or empty
			if (credentialsFile == null || credentialsFile.Equals(""))
			{
				throw new ArgumentException();
			}

			CredentialsFile = credentialsFile;
		}

		public bool Login(Credentials credentials)
		{
			return ValidateLogin(CredentialsFile, credentials);
		}

		public void Register(Credentials credentials)
		{
			StoreCredentials(CredentialsFile, credentials);
		}

		private bool ValidateLogin(string filePath, Credentials credential)
		{
			//Get list of credentials from file
			List<Credentials> credentials;
			if (!TryGetCredentials(filePath, out credentials))
			{
				//Conversion failed
				return false;
			}

			//Return if this instance is in the file
			return credentials.Contains(credential);
		}

		private bool TryGetCredentials(string filePath, out List<Credentials> credentials)
		{
			//Read the file
			string fileText;
			using (StreamReader sr = new StreamReader(filePath))
			{
				fileText = sr.ReadToEnd();
			}

			//Parse lines
			string[] entries = fileText.Split(Environment.NewLine);

			//Fill the list
			credentials = new List<Credentials>();
			foreach (string entry in entries)
			{
				//Convert to Credentials and return false if any fail
				Credentials credential;
				if (!Credentials.TryParse(entry, out credential))
				{
					return false;
				}

				credentials.Add(credential);
			}

			return true;
		}

		private void StoreCredentials(string filePath, Credentials credentials)
		{
			//Check if file has any existing entries or not
			bool hasEntries = File.ReadAllText(filePath).Length > 0;

			//Open the file to write
			using (StreamWriter sw = new StreamWriter(filePath, append: true))
			{
				//If there's already entries then add a newline before adding the next entry
				if (hasEntries)
				{
					sw.Write(Environment.NewLine);
				}
				sw.Write(credentials.ToString());
			}
		}
	}
}
