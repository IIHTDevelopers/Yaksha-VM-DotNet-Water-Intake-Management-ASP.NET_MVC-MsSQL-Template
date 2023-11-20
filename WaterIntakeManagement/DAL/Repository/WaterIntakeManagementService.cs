using WaterIntakeManagement.DAL.Interface;
using WaterIntakeManagement.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace WaterIntakeManagement.DAL.Repository
{
    public class WaterIntakeManagementService : IWaterIntakeManagementInterface
    {
        private IWaterIntakeManagementRepository _repo;
        public WaterIntakeManagementService(IWaterIntakeManagementRepository repo)
        {
            this._repo = repo;
        }

        public int DeleteWaterIntake(int workoutId)
        {
            //write your code here
            throw new NotImplementedException();
        }

        public WaterIntake GetWaterIntakeByID(int workoutId)
        {
            //write your code here
            throw new NotImplementedException();
        }
        public void Save()
        {
            _repo.Save();
        }


        IEnumerable<WaterIntake> IWaterIntakeManagementInterface.GetWaterIntakes()
        {
            //write your code here
            throw new NotImplementedException();
        }

        WaterIntake IWaterIntakeManagementInterface.InsertWaterIntake(WaterIntake workout)
        {
            //write your code here
            throw new NotImplementedException();
        }

        bool IWaterIntakeManagementInterface.UpdateWaterIntake(WaterIntake workout)
        {
            //write your code here
            throw new NotImplementedException();
        }
    }
}