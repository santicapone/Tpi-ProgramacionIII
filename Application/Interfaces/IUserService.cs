using Application.Common;
using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public  interface IUserService
    {
        IEnumerable<User> GetAllUsers();
        OperationResult CreateClient(ClientDto clientDto);
        OperationResult UpdateClient(int clintId ,ClientDto clientDto);  
        OperationResult CreateAdmin(AdminDto adminDto);
        bool DeleteUserById(int clintId);
        User GetUserByName(string name);

    }
}
