using FVD.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace FVD.Services.Interfaces
{
	public interface IUserService
	{
		Task<User> Authenticate(string username, string password);
	}
}
