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
    public class MedicineManager : IMedicineService
    {
        IMedicineDal _medicineDal;

        public MedicineManager(IMedicineDal medicineDal)
        {
            _medicineDal = medicineDal;
        }

        public Result Add(Medicine entity)
        {
            _medicineDal.Add(entity);
            return new SuccessResult();
        }

        public Result Delete(Medicine entity)
        {
            _medicineDal.Delete(entity);
            return new SuccessResult();
        }

        public DataResult<List<Medicine>> GetAll()
        {
            return new SuccessDataResult<List<Medicine>>(_medicineDal.GetAll());
        }

        public Result Update(Medicine entity)
        {
            _medicineDal.Update(entity);
            return new SuccessResult();
        }
    }
}
