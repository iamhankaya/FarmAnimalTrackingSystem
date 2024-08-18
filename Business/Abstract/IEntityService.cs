using Core.Entities;
using Core.Utilities.Results;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IEntityService<T> 
        where T: class,IEntity,new()
        
    {
        
        public Result Delete(T entity);
        public Result Update (T entity);
        public DataResult<List<T>> GetAll();
        
    }
}
