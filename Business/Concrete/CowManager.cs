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
    public class CowManager : ICowService
    {
        ICowDal _cowDal;

        public CowManager(ICowDal cowDal)
        {
            _cowDal = cowDal;
        }

        public Result Add(Cow entity)
        {
            _cowDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Cow entity)
        {
            _cowDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Cow>> GetAll()
        {
            return new SuccessDataResult<List<Cow>>(_cowDal.GetAll());
        }

        public DataResult<List<Cow>> GetCowsChildren(int id)
        {
            return new SuccessDataResult<List<Cow>>(_cowDal.GetCowsChildren(id));
        }

        public Result Update(Cow entity)
        {
            _cowDal.Update(entity);
            return new SuccessResult();
        }
    }
}
