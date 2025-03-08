using BookHaven.Data.Models;
using System.Collections.Generic;

namespace BookHaven.Business.Interfaces
{
    internal interface IUserService
    {
        void AddUser(UserModel user);
        List<KeyValuePair<int, string>> GetUserRoles();

    }
}
