using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace BootCamp.Chapter
{
	public readonly struct Credentials
	{
		public readonly string Username;
		private readonly string Password;

		private Credentials(string username, string password, bool isEncoded) : this()
		{
			//Throw argument exception if username or password are null or blank
			if (username == null || username.Equals("") || password == null || password.Equals(""))
			{
				throw new ArgumentException();
			}

			Username = username;

			if (isEncoded)
			{
				Password = password;
			}
			else//Encode it
			{
				Password = EncodePassword(password);
			}
		}
		//Takes an uncoded username and password
		public Credentials(string username, string password) : this(username, password, isEncoded: false)//Encode the password
		{
		}

		public static bool TryParse(string input, out Credentials credentials)
		{
			//Input should only be 2 strings seperated by ,
			string[] inputs = input.Split(',');
			if (inputs.Length != 2)
			{
				credentials = default;
				return false;
			}

			//Create new credentials
			credentials = new Credentials(inputs[0], inputs[1], isEncoded: true);
			
			return true;
		}
		public override bool Equals(object obj)
		{
			//Return false if null or not Credentials
			if (obj == null || !obj.GetType().Equals(typeof(Credentials)))
			{
				return false;
			}

			//Return false if username or password don't match
			Credentials credObj = (Credentials)obj;
			if (!credObj.Username.Equals(Username) || !credObj.Password.Equals(Password))
			{
				return false;
			}
			
			return true;
		}

		public override string ToString()
		{
			return $"{Username},{Password}";
		}

		private string EncodePassword(string password)
		{
			byte[] passwordBytes = Encoding.Unicode.GetBytes(password, 0, password.Length);
			return string.Join(" ", passwordBytes);
		}
	}
}
