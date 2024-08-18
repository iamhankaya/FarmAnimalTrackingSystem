using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class CowIllness : IEntity
    {
        public int Id { get; set; }
        public int CowId { get; set; }
        public int IllnessId { get; set; }
        public string IllnessDate { get; set; }

    }
}
