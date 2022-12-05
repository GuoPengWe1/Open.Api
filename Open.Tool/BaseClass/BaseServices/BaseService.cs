using Open.Tool.BaseClass.BaseRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.Tool.BaseClass.BaseServices
{
    public abstract class BaseService<T> : IService<T>
    {

        protected IRepository<T> repository;
        protected BaseService(IRepository<T> iRepository)
        {
            repository = iRepository;
        }
    }
}
