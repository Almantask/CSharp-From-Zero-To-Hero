using System;
using System.IO;

namespace BootCamp.Chapter
{
	class Program
	{
		const string FILE_PATH = @"HW.txt";

		static void Main(string[] args)
		{
			//Create or overwrite example file
			File.WriteAllText(FILE_PATH, "");

			//Have user register credentials
			UserInputsCredentials();

			//Login
			UserLogsIn();
		}

		public static void UserInputsCredentials()
		{
			CredentialsManager credentialsManager = new CredentialsManager(FILE_PATH);
			Console.WriteLine("Register login:");

			bool isRepeating = false;

			do
			{
				//Register credentials
				credentialsManager.Register(GetUserCredentials());

				Console.Write("Would you like to register another login? (y/n): ");
				isRepeating = Console.ReadLine().ToLower().Equals("y");
			} while (isRepeating);
		}

		public static void UserLogsIn()
		{
			CredentialsManager credentialsManager = new CredentialsManager(FILE_PATH);

			//Login
			Console.WriteLine("Login:");

			bool isRepeating = false;

			do
			{
				if (credentialsManager.Login(GetUserCredentials()))
				{
					Console.WriteLine("Logged in");
				}
				else
				{
					Console.WriteLine("Log in failed");
				}

				Console.Write("Would you like to try logging in again? (y/n): ");
				isRepeating = Console.ReadLine().ToLower().Equals("y");
			} while (isRepeating);
		}

		public static Credentials GetUserCredentials()
		{
			//Get name and password
			Console.Write("Name: ");
			string name = Console.ReadLine();
			Console.Write("Password: ");
			string password = Console.ReadLine();

			return new Credentials(name, password);
		}
	}
}
