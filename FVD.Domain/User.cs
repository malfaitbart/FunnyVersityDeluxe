using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Domain
{
	public class User
	{
		public enum Roles { Admin, User, Secretary };

		public int ID { get; private set; }
		public string UserName { get; private set; }
		public string PassWord { get; private set; }
		public Roles Role { get; private set; }
		private static int countID;

		public User(string userName, string passWord, Roles role)
		{
			ID = countID;
			UserName = userName;
			PassWord = passWord;
			Role = role;
			countID++;
		}
	}
}
