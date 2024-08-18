using Core.Utilities.Results;
using Entities.Concrete;
using Entities.Concrete.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICowIllnessService : IEntityService<CowIllness> ,IDTOService<CowIllnessDetails>
    {
        Result AutoAdd(int cowId, int illnessId, string illnessDate);
    }
}
