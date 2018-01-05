using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousesForSale.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HousesForSale.Controllers
{
    [Produces("application/json")]
    [Route("api/Demo")]
    public class DemoController : Controller
    {
        private IpastSales _pastSales;
        public DemoController(IpastSales pastmanager)
        {
      
            _pastSales = pastmanager;
        }

        [Route("GetSales")]
        [HttpGet]
        public IActionResult GetUsers()
        {
            return Ok(_pastSales.getpastSales());
        }
    }
}