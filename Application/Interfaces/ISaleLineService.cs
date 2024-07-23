using Application.Models;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface ISaleLineService
    {
        IEnumerable<SaleLine> GetAllSaleLines();
        SaleLineDto GetSaleLineById(int SaleLineId);
        void CreateSaleline(int id, SaleLineDto saleLineDto);
        void UpdateSaleLine(int id, SaleLineDto saleLine);
        void DeleteSaleLineById(SaleLine SaleLineId);

    }
}
 