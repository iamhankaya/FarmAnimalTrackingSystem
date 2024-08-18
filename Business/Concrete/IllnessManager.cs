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
    public class IllnessManager : IIllnessService
    {
        IIllnessDal _illnessDal;

        public IllnessManager(IIllnessDal illnessDal)
        {
            _illnessDal = illnessDal;
        }

        public Result Add(Illness entity)
        {
            _illnessDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Illness entity)
        {
            _illnessDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Illness>> GetAll()
        {
            return new SuccessDataResult<List<Illness>>(_illnessDal.GetAll());
        }

        public Result Update(Illness entity)
        {
            _illnessDal.Update(entity);
            return new SuccessResult();
        }
    }
}
