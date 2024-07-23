using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class SaleLine
    {
        public int id { get; set; }
        public int SaleLineId { get; set; }
        public float? quantity { get; set; }
        public float? totalprice { get; set; }
    }
}
