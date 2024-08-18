using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CowVaccine : IEntity
    {
        public int Id { get; set; }
        public int CowId { get; set; }
        public int VaccineId { get; set; }
        public string VaccinationDate { get; set; }
    }
}
