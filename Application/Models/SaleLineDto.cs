using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class SaleLineDto
    {
        public int? Id { get; set; }
        public int? SaleLineId { get; set; }
        public float? Quantity { get; set; }
        public float? TotalPrice { get; set; }

        

        
    }
}
