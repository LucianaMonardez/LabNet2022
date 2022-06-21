using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Northwind.Web.Api.Models.Response
{
    public class ShipperResponse
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}