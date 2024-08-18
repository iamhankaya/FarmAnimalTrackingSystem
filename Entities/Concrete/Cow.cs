using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Cow : IEntity
    {
        public int CowId { get; set; }
        public string CowName { get; set; }
        public int MomId { get; set; }
        public string BirthDate { get; set; }
        public string DeathDate { get; set; }
        

    }
}
