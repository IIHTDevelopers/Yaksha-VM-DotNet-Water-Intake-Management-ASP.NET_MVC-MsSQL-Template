using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.DAL.Repository;
using WaterIntakeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace WaterIntakeManagement.Controllers
{
    public class WaterIntakeManagementController : Controller
    {
        private readonly IWaterIntakeManagementInterface _Repository;
        public WaterIntakeManagementController(IWaterIntakeManagementInterface service)
        {
            _Repository = service;
        }
        public WaterIntakeManagementController()
        {
            // Constructor logic, if needed
        }
        // GET: WaterIntakeManagement
        public ActionResult Index()
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ViewResult Details(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Create()
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost]
        public ActionResult Create(WaterIntake workout)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult EditAsync(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        [HttpPost]
        public ActionResult Edit(WaterIntake workout)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public ActionResult Delete(int id, bool? saveChangesError)
        {
            //write your code here
            throw new NotImplementedException();
        }

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}