using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CowMedicineManager : ICowMedicineService
    {
        ICowMedicineDal _cowMedicineDal;

        public CowMedicineManager(ICowMedicineDal cowMedicineDal)
        {
            _cowMedicineDal = cowMedicineDal;
        }

        

        public Result AutoAdd(int cowId, int medicineId, string usageStart, string usageEnd)
        {
            _cowMedicineDal.AutoAdd(cowId, medicineId, usageStart, usageEnd);
            return new SuccessResult();
        }

        public Result Delete(CowMedicine entity)
        {
            
            _cowMedicineDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<CowMedicine>> GetAll()
        {
            return new SuccessDataResult<List<CowMedicine>>(_cowMedicineDal.GetAll());
        }

        public DataResult<List<CowMedicineDetails>> GetAllDetails()
        {
            return new SuccessDataResult<List<CowMedicineDetails>>(_cowMedicineDal.GetAllCowMedicine());
        }

        public DataResult<List<CowMedicineDetails>> GetDetailsByCowId(int cowId)
        {
            return new SuccessDataResult<List<CowMedicineDetails>>(_cowMedicineDal.GetCowMedicineByCowId(cowId));
        }

        public DataResult<List<CowMedicineDetails>> GetDetailsByEntityId(int id)
        {
            return new SuccessDataResult<List<CowMedicineDetails>>(_cowMedicineDal.GetCowMedicineByMedicineId(id));
        }

        public Result Update(CowMedicine entity)
        {
            _cowMedicineDal.Update(entity);
            return new SuccessResult();
        }
    }
}
