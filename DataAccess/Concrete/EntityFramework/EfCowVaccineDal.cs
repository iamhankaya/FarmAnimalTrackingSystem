using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCowVaccineDal : EfEntityRepositoryBase<CowVaccine, FarmAnimalTrackingSystemContext>, ICowVaccineDal
    {

        public void AutoAdd(int cowId, int vaccineId, string vaccinationDate)
        {
            int id;
            List<CowVaccine> cowVaccineList = this.GetAll();
            if (cowVaccineList == null)
            {
                id = 1;
            }
            else
            {
                id = this.GetAll().Count + 1;
            }
            CowVaccine cowVaccine = new CowVaccine
            {
                Id = id,
                CowId = cowId,
                VaccineId = vaccineId,
                VaccinationDate = vaccinationDate
            };
            this.Add(cowVaccine);
        }

        public List<CowVaccineDetails> GetAllCowVaccine(Expression<Func<CowVaccineDetails, bool>> filter = null)
        {
            using (FarmAnimalTrackingSystemContext context = new FarmAnimalTrackingSystemContext())
            {
                var result = from cv in context.CowVaccines
                             join c in context.Cows
                             on cv.CowId equals c.CowId
                             join v in context.Vaccines
                             on cv.VaccineId equals v.VaccineId
                             select new CowVaccineDetails { VaccineId = v.VaccineId, CowId = c.CowId, CowName = c.CowName, VaccineDate = cv.VaccinationDate, VaccineName = v.VaccineName };
                return result.ToList();
            }
        }

        public List<CowVaccineDetails> GetCowVaccineByCowId(int id)
        {
            var result = this.GetAllCowVaccine(cv => cv.CowId==id);
            return result.ToList();
        }

        public List<CowVaccineDetails> GetCowVaccineByVaccineId(int id)
        {
            var result = this.GetAllCowVaccine(cv => cv.VaccineId==id);
            return result.ToList();
        }
    }
}
