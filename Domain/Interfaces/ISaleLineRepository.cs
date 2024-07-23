using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ISaleLineRepository
    {
        IEnumerable<SaleLine> GetAllSaleLines();
        SaleLine GetSaleLineById(int salelineid);
        void CreateSaleLine(SaleLine saleline);
        void UpdateSaleLine(SaleLine saleline);
        void DeleteSaleLineById(SaleLine SaleLineId);
    }
}
