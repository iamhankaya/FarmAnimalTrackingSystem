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
    public interface ICowVaccineDal : IEntityRepository<CowVaccine>
    {
        List<CowVaccineDetails> GetAllCowVaccine(Expression<Func<CowVaccineDetails, bool>> filter = null);
        List<CowVaccineDetails> GetCowVaccineByCowId(int id);
        List<CowVaccineDetails> GetCowVaccineByVaccineId (int id);
        void AutoAdd(int cowId, int vaccineId, string vaccinationDate);
    }
}
