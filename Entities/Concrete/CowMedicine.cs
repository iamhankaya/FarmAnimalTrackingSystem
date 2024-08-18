using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CowMedicine : IEntity
    {
        public int Id { get; set; }
        public int CowId { get; set; }
        public int MedicineId { get; set; }
        public string MedicineUsageStart { get; set; }
        public string MedicineUsageEnd { get; set; }
    }
}
