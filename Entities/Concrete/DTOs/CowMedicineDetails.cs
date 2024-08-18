using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CowMedicineDetails : IDto
    {
        public int CowId { get; set; }
        public int MedicineId { get; set; }
        public string CowName { get; set; }
        public string MedicineName { get; set; }
        public string MedicineUsageStart { get; set; }
        public string MedicineUsageEnd { get; set; }
    }
}
