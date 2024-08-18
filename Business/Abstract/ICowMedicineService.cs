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
    public interface ICowMedicineService : IEntityService<CowMedicine> , IDTOService<CowMedicineDetails>
    {
        Result AutoAdd(int cowId,int medicineId,string usageStart,string usageEnd);
    }
}
