using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab.Northwind.WebApi.Models
{
    public class UpdateShipperViewModel
    {
        public int Id { get; set; }
        public string CompanyName { get; set; }
        public string Phone { get; set; }

    }
}