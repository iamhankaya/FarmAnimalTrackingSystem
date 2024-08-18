using Core.DataAccess;
using Core.Utilities.Results;
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
    public interface ICowEstrusPeriodDal : IEntityRepository<CowEstrusPeriod>
    {
        void AutoAdd(int cowId, string EstrusPeriodDate);
        public List<CowEstrusPeriodDetails> GetAllDetails(Expression<Func<CowEstrusPeriodDetails, bool>> filter = null);
        public List<CowEstrusPeriodDetails> GetDetailsByCowId(int cowId);
        public List<CowEstrusPeriodDetails> GetDetailsByEntityId(int id);
    }
}
