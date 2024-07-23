using Domain.Entities;
using Domain.Interfaces;
using Infraestructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Repositories
{

    public class UserRepository  : Repository, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context) 
        {
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _context.Users;

        }

        public User? GetUserById(int UserId) 
        {
            return _context.Users.Find(UserId);
        }

        public void AddUser(User user) 
        {
            _context.Users.Add(user);
            SaveChanges();
        }
        
        public User? GetUserByUserName(string? name)
        {
            return _context.Users.SingleOrDefault(x => name == name);
        }

        public void UpdateUser(User user) 
        {
            _context.Users.Update(user);
            SaveChanges();
        }

        public void CreateClient(User user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }

        public void DeleteUser(User user) 
        {
            _context.Users.Remove(user);
            SaveChanges();
        }

        public void CreateAdmin(User user)
        {
            _context.Users.Add(user);
            SaveChanges();
        }

    }
}
