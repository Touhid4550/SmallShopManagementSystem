using SSMS.BLL.BLL;
using SSMS.DatabaseContext.DatabaseContext;
using SSMS.Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SmallShopManagementSystem.Controllers
{
    public class SalesController : Controller
    {
        CustomerBll _customer = new CustomerBll();
        SSMSDbContext _db = new SSMSDbContext();
       
        //
        // GET: /Sales/

        public ActionResult Create()
        {

            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Sale sale)
        {

            if (ModelState.IsValid && sale.PurchaseDetailses != null && sale.PurchaseDetailses.Count > 0)
            {


                _db.Sales.Add(sale);
                var isAdded = _db.SaveChanges() > 0;
                if (isAdded)
                {
                    return View(sale);
                }
            }
            return View();

        }
    }
}