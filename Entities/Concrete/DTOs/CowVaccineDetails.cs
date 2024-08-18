using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CowVaccineDetails : IDto
    {
        public int CowId { get; set; }
        public int VaccineId { get; set; }
        public string CowName { get; set; }
        public string VaccineName { get; set; }
        public string VaccineDate { get; set; }
    }
}
