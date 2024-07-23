using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class AdminDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string MailAdress { get; set; }

        //public static AdminDto Create (Admin admin)
        //{
        //    var dto = new AdminDto ();

        //    dto.Id = admin.Id;
        //    dto.Name = admin.Name;
        //    dto.MailAdress = admin.MailAdress;


        //    return dto;
        //}
    }
}
