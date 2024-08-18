using Core.DataAccess;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface ICowMedicineDal : IEntityRepository<CowMedicine>
    {
        List<CowMedicineDetails> GetAllCowMedicine(Expression<Func<CowMedicineDetails, bool>> filter = null);
        List<CowMedicineDetails> GetCowMedicineByCowId (int id);
        List<CowMedicineDetails> GetCowMedicineByMedicineId (int id);
        void AutoAdd(int cowId, int medicineId, string usageStart, string usageEnd);
    }
}
