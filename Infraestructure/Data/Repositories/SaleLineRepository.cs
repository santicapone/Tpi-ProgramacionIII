using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Data.Repositories
{
    internal class SaleLineRepository : Repository , ISaleLineRepository
    {
        public SaleLineRepository(ApplicationContext context): base(context) { }

        public IEnumerable<SaleLine> GetAllSaleLines()
        {
            return _context.SaleLines;
        }

        public SaleLine GetSaleLineById(int SaleLineId)
        {
            return _context.SaleLines.Find(SaleLineId);
        } 

        public void CreateSaleLine(SaleLine saleLine)
        {
            _context.SaleLines.Add(saleLine);
            SaveChanges();
        }

        public void DeleteSaleLineById(SaleLine SaleLineId) 
        { 
            _context.SaleLines.Remove(SaleLineId);        
            SaveChanges();
        }

        public void UpdateSaleLine(SaleLine SaleLine)
        {
            _context.SaleLines.Update(SaleLine);
            SaveChanges();
        }
    }
}
