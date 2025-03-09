using Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class UserService : IUserService
    {
        public bool AuthenticateUser(string username, string password)
        {
            return _users.ContainsKey(username) && _users[username] == password;
        }
        private static readonly Dictionary<string, string> _users = new Dictionary<string, string>
        {
            { "testuser", "password123" }
        };

    }
}
