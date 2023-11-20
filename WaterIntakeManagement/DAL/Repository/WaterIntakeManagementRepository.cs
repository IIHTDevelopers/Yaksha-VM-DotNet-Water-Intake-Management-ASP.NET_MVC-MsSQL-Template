using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace WaterIntakeManagement.DAL.Repository
{
    public class WaterIntakeManagementRepository : IWaterIntakeManagementRepository
    {
        private WaterIntakeManagementDbContext _context;
        public WaterIntakeManagementRepository(WaterIntakeManagementDbContext Context)
        {
            this._context = Context;
        }
        public IEnumerable<WaterIntake> GetWaterIntakes()
        {
            //write your code here
            throw new NotImplementedException();
        }
        public WaterIntake GetWaterIntakeByID(int id)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public WaterIntake InsertWaterIntake(WaterIntake workout)
        {
            return _context.WaterIntakes.Add(workout);
        }
        public int DeleteWaterIntake(int workoutID)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public bool UpdateWaterIntake(WaterIntake workout)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            //write your code here
            throw new NotImplementedException();
        }
        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
