using HousesForSale.Interface;
using HousesForSale.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace HousesForSale.Services
{
    public class pastSales : IpastSales
    {
        static WebClient client = new WebClient();
        public List<pastSaleModel> getpastSales()
        {
            List<pastSaleModel> sale = new List<pastSaleModel>();
            sale.Add(new pastSaleModel
            {
                Property = "images/property/home5.jpg",
                Details ="<span class='c-content__homes-address'>3247 Greystone Dr • Jamul, CA 91935</span>" +
        "<span class='c-content__homes-info'>7 bed, 4 bath, 6,150 sqft</span>" +
        "<span class='c-content__homes-date'>Sold date: 09/12/2017</span>",
                Represented = "Seller",
                Price = "$900,000"
            });


            sale.Add(new pastSaleModel
            {
                Property = "images/property/home4.jpg",
                Details = "<span class='c-content__homes-address'>9951 Watergum Trl • Santee, CA 92071</span>" +
                    "<span class='c-content__homes-info'>6 bed, 5.5 bath, 5,505 sqft</span>" +
                   " <span class='c-content__homes-date'>Sold date: 07/21/2017</span>",
                Represented = "Buyer",
                Price = "$490,000"
            });


            sale.Add(new pastSaleModel
            {
                Property = "images/property/home12.jpg",
                Details = "<span class='c - content__homes - location'>Santee, CA</span>" +
                    "<span class='c-content__homes-address'>627 Hawthorne Ave • El Cajon, CA 92020</span>" +
                    "<span class='c-content__homes-info'>6 bed, 5.5 bath, 5,505 sqft</span>" +
                    "<span class='c-content__homes-date'>Sold date: 09/11/2017</span>",
                Represented = "Buyer",
                Price = "$529,000"
            });

            sale.Add(new pastSaleModel
            {
                Property = "images/property/home6.jpg",
                Details = "<span class='c-content__homes-location'>La Mesa, CA</span>" +
                    "<span class='c-content__homes-address'>9565 Janfred Way • La Mesa, CA 91942</span>" +
                    "<span class='c-content__homes-info'>6 bed, 5.5 bath, 5,505 sqft</span>" +
                    "<span class='c-content__homes-date'>Sold date: 07/11/2017</span>",
                Represented = "Buyer",
                Price = "$555,000"
            });

            sale.Add(new pastSaleModel
            {
                Property = "images/property/home7.jpg",
                Details = "<span class='c-content__homes-location'>La Mesa, CA</span>" +
                    "<span class='c-content__homes-address'>5160 Alzeda Dr • La Mesa, CA 91941</span>" +
                    "<span class='c-content__homes-info'>6 bed, 5.5 bath, 5,505 sqft</span>" +
                    "<span class='c-content__homes-date'>Sold date: 07/07/2017</span>",
                Represented = "Seller",
                Price = "$1,265,000"
            });

            return sale;
        }

        public async Task<List<pastSaleModel>> saleList(string apiUrl)
        {
            try
            {
                ApiCall uitylity = new ApiCall(apiUrl);
                var result = await uitylity.Get(apiUrl);
                List<pastSaleModel> sale = JsonConvert.DeserializeObject<List<pastSaleModel>>(result.ToString());
                //Log.WriteLog(": " + result.ToString());
                return sale;

            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
