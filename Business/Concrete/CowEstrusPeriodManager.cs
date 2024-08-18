using Business.Abstract;
using Core.Utilities;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CowEstrusPeriodManager : ICowEstrusPeriodService
    {
        ICowEstrusPeriodDal _cowEstrusPeriodDal;
        public Result AutoAdd(int cowId, string EstrusPeriodDate)
        {
            _cowEstrusPeriodDal.AutoAdd(cowId, EstrusPeriodDate);
            return new SuccessResult();
        }

        public Result Delete(CowEstrusPeriod entity)
        {
            _cowEstrusPeriodDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<CowEstrusPeriod>> GetAll()
        {
            return new SuccessDataResult<List<CowEstrusPeriod>>(_cowEstrusPeriodDal.GetAll());
        }

        public DataResult<List<CowEstrusPeriodDetails>> GetAllDetails()
        {
            return new SuccessDataResult<List<CowEstrusPeriodDetails>>(_cowEstrusPeriodDal.GetAllDetails());
        }

        public DataResult<List<CowEstrusPeriodDetails>> GetDetailsByCowId(int cowId)
        {
            return new SuccessDataResult<List<CowEstrusPeriodDetails>>(_cowEstrusPeriodDal.GetDetailsByCowId(cowId));
        }

        public DataResult<List<CowEstrusPeriodDetails>> GetDetailsByEntityId(int id)
        {
            throw new NotImplementedException();
        }

        public Result Update(CowEstrusPeriod entity)
        {
            _cowEstrusPeriodDal.Update(entity);
            return new SuccessResult();
        }
    }
}
