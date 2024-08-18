using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCowDal : EfEntityRepositoryBase<Cow, FarmAnimalTrackingSystemContext>, ICowDal
    {
        public List<Cow> GetCowsChildren(int id)
        {
            var result = this.GetAll(c => c.MomId == id);
            return result.ToList();
        }
    }
}
