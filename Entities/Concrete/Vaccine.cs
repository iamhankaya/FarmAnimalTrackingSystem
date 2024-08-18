using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Vaccine : IEntity
    {
        public int VaccineId { get; set; }
        public string VaccineName { get; set; }
        //After which month of pregnancy is it dangerous to do it?
        public int PregnancysDangerMonth { get; set; }

    }
}
