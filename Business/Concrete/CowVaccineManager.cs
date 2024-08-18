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
    public class CowVaccineManager : ICowVaccineService
    {
        ICowVaccineDal _cowVaccineDal;

        public CowVaccineManager(ICowVaccineDal cowVaccineDal)
        {
            _cowVaccineDal = cowVaccineDal;
        }

        public Result AutoAdd(int cowId, int vaccineId, string vaccinationDate)
        {
            _cowVaccineDal.AutoAdd(cowId, vaccineId, vaccinationDate);
            return new SuccessResult();
        }

        public Result Delete(CowVaccine entity)
        {
            _cowVaccineDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<CowVaccine>> GetAll()
        {
            return new SuccessDataResult<List<CowVaccine>>(_cowVaccineDal.GetAll()); 
        }

        public DataResult<List<CowVaccineDetails>> GetAllDetails()
        {
            return new SuccessDataResult<List<CowVaccineDetails>>(_cowVaccineDal.GetAllCowVaccine());
        }

        public DataResult<List<CowVaccineDetails>> GetDetailsByCowId(int cowId)
        {
            return new SuccessDataResult<List<CowVaccineDetails>>(_cowVaccineDal.GetCowVaccineByCowId(cowId));
        }

        public DataResult<List<CowVaccineDetails>> GetDetailsByEntityId(int id)
        {
            return new SuccessDataResult<List<CowVaccineDetails>>(_cowVaccineDal.GetCowVaccineByVaccineId(id));
        }

        public Result Update(CowVaccine entity)
        {
            _cowVaccineDal.Update(entity);
            return new SuccessResult();
        }
    }
}
