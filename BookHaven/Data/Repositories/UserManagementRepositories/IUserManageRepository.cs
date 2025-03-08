using BookHaven.Data.Models;
using System.Collections.Generic;

namespace BookHaven.Data.Repositories
{
    internal interface IUserManageRepository
    {
        void AddUser(UserModel user);
        List<KeyValuePair<int, string>> GetUserRoles();

    }
}
