using Lab.Northwind.WebApi.Models;
using Northwind.EF.Entities;
using Northwind.EF.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Lab.Northwind.WebApi.Controllers
{
    public class ShippersController : ApiController
    {
        ShippersLogic shippersLogic = new ShippersLogic();
        // GET: api/Shippers
        public IHttpActionResult GetAll()
        {
            List<Shippers> shippers = shippersLogic.GetAll();
            if (shippers.Count != 0)
            {
                return Ok(shippers);
            }
            else
            {
                return NotFound();
            }
        }

        // GET: api/Shippers/5
        public IHttpActionResult GetById(int id)
        {
            Shippers shipper = shippersLogic.GetById(id)
;
            if (shipper != null)
            {
                ShippersViewModel shippersViewModel = new ShippersViewModel
                {
                    Id = shipper.ShipperID,
                    CompanyName = shipper.CompanyName,
                    Phone = shipper.Phone,
                };
                return Ok(shippersViewModel);
            }
            else
            {
                return NotFound();
            }
        }

        // POST: api/Shippers
        public IHttpActionResult Post([FromBody] AddShipperViewModel shippersViewModel)
        {
            Shippers shipper = new Shippers()
            {
               CompanyName = shippersViewModel.CompanyName, 
               Phone = shippersViewModel.Phone,
            };
            shippersLogic.Add(shipper);
            return Ok("Shipper creado exitosamente"); 
        }

        // PUT: api/Shippers/5
        public IHttpActionResult Put([FromBody] UpdateShipperViewModel shippersViewModel)
        {
            if (ModelState.IsValid)
            {
                Shippers shipper = new Shippers()
                {
                    ShipperID  = shippersViewModel.Id,
                    CompanyName = shippersViewModel.CompanyName,
                    Phone = shippersViewModel.Phone,
                };
                shippersLogic.Update(shipper);
                return Ok("Shipper modificado exitosamente");
            }
            else
            {
                return BadRequest();
            }
        }

        // DELETE: api/Shippers/5
        public IHttpActionResult Delete(int id)
        {

            if (id == 0)
            {
                return BadRequest("El id ingresado no es valido");
            }
            shippersLogic.Delete(id);
            return Ok("El shipper fue eliminado exitosamente");
        }
    }
}
