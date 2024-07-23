using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ProductDto
    {
        public int Id { get; set; }
        public string ?ProductName { get; set; }
        public float? Price { get; set; }
        public float? Amount { get; set; }
        public List<ProductDto>? Product { get; set; }

        //public static ProductDto Create(Product product)
        //{
        //    var dto = new ProductDto();

        //    dto.Id = product.Id;
        //    dto.ProductName = product.ProductName;
        //    dto.Price = product.Price;
        //    dto.Amount = product.Amount;

        //    return dto;
        //}
        //public static List<ProductDto> CreateList(IEnumerable<Product> products)
        //{
        //    List<ProductDto> listDto = [];
        //    foreach (var q in products)
        //    {
        //        listDto.Add(Create(q));
        //    }
        //    return listDto;
        //}
        
    }
}
