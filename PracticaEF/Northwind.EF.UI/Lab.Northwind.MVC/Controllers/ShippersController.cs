using Northwind.EF.Logic;
using Northwind.EF.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab.Northwind.MVC.Models;

namespace Lab.Northwind.MVC.Controllers
{
    public class ShippersController : Controller
    {
        ShippersLogic logic = new ShippersLogic();
        // GET: Shippers
        public ActionResult Index()
        {

            List<Shippers> shippers = logic.GetAll();

            List<ShipperView> shippersView = shippers.Select(x => new ShipperView
            {
                Id = x.ShipperID,
                CompanyName = x.CompanyName,
                Phone = x.Phone,
            }).ToList();
            return View(shippersView);
        }

        public ActionResult Insert()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Insert(ShipperView shippersView)
        {
            try
            {
                var shipperEntity = new Shippers { CompanyName = shippersView.CompanyName, Phone = shippersView.Phone, ShipperID = shippersView.Id };
                logic.Add(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
        }

        public ActionResult Delete(int id)
        {
            logic.Delete(id);
            return RedirectToAction("Index");
        }
        public ActionResult Update(int id)
        {
            var shipper = logic.GetById(id);
            return View(new ShipperView { Id = shipper.ShipperID, CompanyName = shipper.CompanyName, Phone = shipper.Phone});
        }

        [HttpPost]
        public ActionResult Update(ShipperView shippersView)
        {
            try
            {
                var shipperEntity = new Shippers { CompanyName = shippersView.CompanyName, Phone = shippersView.Phone, ShipperID = shippersView.Id };
                logic.Update(shipperEntity);

                return RedirectToAction("Index");
            }
            catch (Exception)
            {

                return RedirectToAction("Index", "Error");
            }
        }
    }
}