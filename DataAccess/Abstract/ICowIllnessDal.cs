using Core.DataAccess;
using Core.Entities;
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
    public interface ICowIllnessDal : IEntityRepository<CowIllness>
    {
        List<CowIllnessDetails> GetAllCowIllness(Expression<Func<CowIllnessDetails, bool>> filter=null);
        List<CowIllnessDetails> GetCowIllnessByCowId(int id);
        List<CowIllnessDetails> GetCowIllnessByIllnessId(int id);

        void AutoAdd(int cowId, int illnessId, string illnessDate);
    }
}
