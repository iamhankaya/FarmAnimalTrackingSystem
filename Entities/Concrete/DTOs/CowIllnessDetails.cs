using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CowIllnessDetails : IDto
    {
        public int CowId { get; set; }
        public int IllnessId { get; set; }
        public string CowName { get; set; }
        public string IllnessName { get; set; }
        public string IllnessDate { get; set; }

    }
}
