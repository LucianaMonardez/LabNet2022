using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Northwind.Web.Api.Models.Request
{
    public class ShipperRequest
    {
        public string CompanyName { get; set; }
        public string Phone { get; set; }
    }
}