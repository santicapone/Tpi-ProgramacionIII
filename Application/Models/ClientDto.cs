using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Application.Models
{
    public class ClientDto
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public string Password { get; set; }
        public string LastName { get; set; }
        public string MailAdress { get; set; }
        
        //public static ClientDto Create(Client client) 
        //{
        //    var dto = new ClientDto();
        //    dto.Id = client.Id;
        //    dto.MailAdress = client.MailAdress;
        //    dto.Name = client.Name;
        //    dto.LastName = client.LastName;
          
                
        //    return dto;
        //}

    }
}
