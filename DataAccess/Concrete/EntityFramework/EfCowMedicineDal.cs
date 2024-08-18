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
    public class EfCowMedicineDal : EfEntityRepositoryBase<CowMedicine, FarmAnimalTrackingSystemContext>, ICowMedicineDal
    {
        public void AutoAdd(int cowId,int medicineId,string usageStart,string usageEnd)
        {
            int id;
            List<CowMedicine> cowMedicines = this.GetAll();
            if (cowMedicines == null)
            {
                id = 1;
            }
            else
            {
                id = this.GetAll().Count + 1;
            }
            CowMedicine cowMedicine = new CowMedicine
            {
                Id = id,
                CowId = cowId,
                MedicineId = medicineId,
                MedicineUsageStart = usageStart,
                MedicineUsageEnd = usageEnd
                
            };
            this.Add(cowMedicine);
        }
        public List<CowMedicineDetails> GetAllCowMedicine(Expression<Func<CowMedicineDetails, bool>> filter = null)
        {
            using (FarmAnimalTrackingSystemContext context = new FarmAnimalTrackingSystemContext())
            {
                var result = from cm in context.CowMedicines
                             join c in context.Cows
                             on cm.CowId equals c.CowId
                             join m in context.Medicines
                             on cm.MedicineId equals m.MedicineId
                             select new CowMedicineDetails { MedicineId = m.MedicineId, CowId = c.CowId, CowName = c.CowName, MedicineUsageStart = cm.MedicineUsageStart, MedicineName = m.MedicineName,MedicineUsageEnd=cm.MedicineUsageEnd };
                return result.ToList();

            }
        }

        public List<CowMedicineDetails> GetCowMedicineByCowId(int id)
        {
            var result= this.GetAllCowMedicine(cm => cm.CowId == id);
            return result.ToList();
            
        }

        public List<CowMedicineDetails> GetCowMedicineByMedicineId(int id)
        {
            var result = this.GetAllCowMedicine(cm => cm.MedicineId == id);
            return result.ToList(); 
        }
    }
}
