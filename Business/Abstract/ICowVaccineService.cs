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
    public interface ICowVaccineService : IEntityService<CowVaccine> ,IDTOService<CowVaccineDetails>
    {
        Result AutoAdd(int cowId,int vaccineId,string vaccinationDate);
    }
}
