using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class VaccineManager : IVaccineService
    {
        IVaccineDal _vaccineDal;

        public VaccineManager(IVaccineDal vaccineDal)
        {
            _vaccineDal = vaccineDal;
        }

        public Result Add(Vaccine entity)
        {
            _vaccineDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Vaccine entity)
        {
            _vaccineDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Vaccine>> GetAll()
        {
            return new SuccessDataResult<List<Vaccine>>(_vaccineDal.GetAll());
        }

        public Result Update(Vaccine entity)
        {
            _vaccineDal.Update(entity);
            return new SuccessResult();
        }
    }
}
