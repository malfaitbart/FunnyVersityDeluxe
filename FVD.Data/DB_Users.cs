using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace FVD.Data
{
	public class DB_Users
	{
		public static List<User> users = new List<User>()
		{
			new User("bart", "password", User.Roles.Admin),
			new User("kenny", "switch", User.Roles.User),
			new User("niels", "switch", User.Roles.Secretary)
		};
	}
}
