using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CowEstrusPeriodDetails : IDto
    {
        public int CowId { get; set; }
        public string CowName { get; set; }
        public string EstrusPeriodDate { get; set; }
    }
}
