using HousesForSale.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HousesForSale.Interface
{
    public interface IpastSales
    {
        List<pastSaleModel> getpastSales();
        Task<List<pastSaleModel>> saleList(string apiUrl);

    }
}
