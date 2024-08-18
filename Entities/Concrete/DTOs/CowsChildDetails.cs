using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CowsChildDetails : IDto
    {
        public string CowName { get; set; }
        public string CalfName { get; set; }
        public string BirthDate { get; set; }
    }
}
