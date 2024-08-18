using Core.DataAccess.EntityFramework;
using Core.Entities;
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
    public class EfCowIllnessDal : EfEntityRepositoryBase<CowIllness, FarmAnimalTrackingSystemContext>, ICowIllnessDal
    {
        public void AutoAdd(int cowId, int illnessId, string illnessDate)
        {
            int id;
            List<CowIllness> cowIllnessList = this.GetAll();
            if (cowIllnessList==null)
            {
                id = 1;
            }
            else
            {
                id = this.GetAll().Count + 1;
            }
            CowIllness cowIllness = new CowIllness
            {
                CowId = cowId,
                IllnessId = illnessId,
                IllnessDate = illnessDate,
                Id = id

            };
            this.Add(cowIllness);
        }

        public List<CowIllnessDetails> GetAllCowIllness(Expression<Func<CowIllnessDetails, bool>> filter=null)
        {
            using (FarmAnimalTrackingSystemContext context = new FarmAnimalTrackingSystemContext())
            {
                var result = from ci in context.CowIllnesses
                             join c in context.Cows
                             on ci.CowId equals c.CowId
                             join i in context.Illnesses
                             on ci.IllnessId equals i.IllnessId
                             select new CowIllnessDetails { CowName = c.CowName, IllnessDate = ci.IllnessDate, IllnessName = i.IllnessName,CowId=c.CowId,IllnessId=i.IllnessId };
                return result.ToList();
                           
            }
        }

        public List<CowIllnessDetails> GetCowIllnessByCowId(int id)
        {
            var result = this.GetAllCowIllness(ci => ci.CowId == id);
            return result.ToList();
        }

        public List<CowIllnessDetails> GetCowIllnessByIllnessId(int id)
        {
            var result = this.GetAllCowIllness(ci => ci.IllnessId == id);
            return result.ToList();
        }
    }
}
