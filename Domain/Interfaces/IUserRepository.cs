using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserRepository : IRepository
    {
        IEnumerable<User> GetAllUsers();
        User? GetUserById(int UserId);
        User? GetUserByUserName(string name);
        void DeleteUserById(User userId);
        void UpdateUser(User user);
        void CreateAdmin(User user);
        void CreateClient(User user);
    }
}
