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
    public class CowIllnessManager : ICowIllnessService
    {
        ICowIllnessDal _cowIllnessDal;

        public CowIllnessManager(ICowIllnessDal cowIllnessDal)
        {
            _cowIllnessDal = cowIllnessDal;
        }

        public Result AutoAdd(int cowId,int illnessId,string illnessDate)
        {
            _cowIllnessDal.AutoAdd(cowId,illnessId,illnessDate);
            return new SuccessResult();
        }

        public Result Delete(CowIllness entity)
        {
            _cowIllnessDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<CowIllness>> GetAll()
        {
            return new SuccessDataResult<List<CowIllness>>(_cowIllnessDal.GetAll()); 
        }

        public DataResult<List<CowIllnessDetails>> GetAllDetails()
        {
            return new SuccessDataResult<List<CowIllnessDetails>>(_cowIllnessDal.GetAllCowIllness());
        }

        public DataResult<List<CowIllnessDetails>> GetDetailsByCowId(int cowId)
        {
            return new SuccessDataResult<List<CowIllnessDetails>>(_cowIllnessDal.GetCowIllnessByCowId(cowId));
        }

        public DataResult<List<CowIllnessDetails>> GetDetailsByEntityId(int id)
        {
            return new SuccessDataResult<List<CowIllnessDetails>>(_cowIllnessDal.GetCowIllnessByIllnessId(id));
        }

        public Result Update(CowIllness entity)
        {
            _cowIllnessDal.Update(entity);
            return new SuccessResult();
        }
    }
}
