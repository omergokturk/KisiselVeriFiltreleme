using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KisiselVeriler.DAL
{
    public interface IRepositories<TEntity,Tvalue>
        where TEntity : class
    {
        TEntity Get(Tvalue id);
        List<TEntity> Get();
        bool delete(TEntity entity);
        bool delete(Tvalue id);
        //bool delete(TEntity entity);
        //bool delete(TEntity entity);

    }
}
