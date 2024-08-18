using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Illness : IEntity
    {
        public int IllnessId { get; set; }
        public string IllnessName { get; set; }
    }
}
