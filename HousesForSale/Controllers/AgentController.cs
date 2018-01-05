using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HousesForSale.Interface;
using Microsoft.AspNetCore.Mvc;

namespace HousesForSale.Controllers
{

    public class AgentController : Controller
    {
        private IpastSales _pastSales;
        public AgentController(IpastSales pastmanager)
        {
            _pastSales = pastmanager;
        }
        public async Task<IActionResult> Index()
            {
            ViewBag.saleTest= await _pastSales.saleList("http://localhost:63692/api/Demo/GetSales");
            return View();
        }
    }
}