using Domain.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Application.Interfaces;

namespace BurgerDemoApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class SaleLineController : ControllerBase
    {
        private readonly ISaleLineService _saleLineService;

        public SaleLineController(ISaleLineService saleLineService)
        {
            _saleLineService = saleLineService;
        }

        [HttpGet("GetAllSaleLines")]
        [Authorize("Admin")] 
        
        public IActionResult GetAllSaleLines()
        {
            return Ok(_saleLineService.GetAllSaleLines());
        }
    }
}
