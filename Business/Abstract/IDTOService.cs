using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public  interface IDTOService<D> where D : class,IDto,new()
    {
        
        public DataResult<List<D>> GetAllDetails();
        public DataResult<List<D>> GetDetailsByCowId(int cowId);
        public DataResult<List<D>> GetDetailsByEntityId(int id);


    }
}
