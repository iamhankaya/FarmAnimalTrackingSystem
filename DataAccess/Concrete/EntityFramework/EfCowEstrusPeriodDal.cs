using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCowEstrusPeriodDal : EfEntityRepositoryBase<CowEstrusPeriod, FarmAnimalTrackingSystemContext>, ICowEstrusPeriodDal
    {
        public void AutoAdd(int cowId, string EstrusPeriodDate)
        {
            int id;
            List<CowEstrusPeriod> cowEstrusPeriods = this.GetAll();
            if (cowEstrusPeriods == null)
            {
                id = 1;
            }
            else
            {
                id = this.GetAll().Count+1;
            }
            CowEstrusPeriod cowEstrusPeriod = new CowEstrusPeriod
            {
                Id=id,
                CowId = cowId,
                EstrusPeriodDate = EstrusPeriodDate
            };
        }

        public List<CowEstrusPeriodDetails> GetAllDetails(Expression<Func<CowEstrusPeriodDetails, bool>> filter = null)
        {
            using (FarmAnimalTrackingSystemContext context = new FarmAnimalTrackingSystemContext())
            {
                var result = from cep in context.CowEstrusPeriods
                             join c in context.Cows
                             on cep.CowId equals c.CowId
                             select new CowEstrusPeriodDetails
                             {
                                 CowId = c.CowId,
                                 CowName = c.CowName,
                                 EstrusPeriodDate = cep.EstrusPeriodDate,
                             };
                return result.ToList();
            }
        }

        public List<CowEstrusPeriodDetails> GetDetailsByCowId(int cowId)
        {
            var result = this.GetAllDetails(c => c.CowId == cowId);
            return result.ToList();
        }

        public List<CowEstrusPeriodDetails> GetDetailsByEntityId(int id)
        {
            throw new NotImplementedException();
        }
    }
}
