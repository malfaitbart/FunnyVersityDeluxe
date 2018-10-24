using FVD.Data;
using FVD.Domain;
using FVD.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FVD.Services
{
	public class UserService : IUserService
	{
		public async Task<User> Authenticate(string username, string password)
		{
			var user = await Task.Run(() => DB_Users.users.SingleOrDefault(x => x.UserName== username && x.PassWord== password));

			if (user == null)
			{
				return null;
			}
			return user;
		}
	}
}
