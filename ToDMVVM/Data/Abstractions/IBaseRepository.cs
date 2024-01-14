using Newtonsoft.Json.Bson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDMVVM.Data.Abstractions
{
    public interface IBaseRepository<T> : IDisposable where T : TableData, new()
    {
        //Create/Update

        void SaveEntity (T entity);

        //ReadOne / ReadMany
        T? GetEntity(int id);

        //Delete -- Delete Entity 
        void DeleteEntity(T entity);

        //Create/Updae -- Cascade
        void SaveEntityWithChildren(T entity, bool recursive = false);

        //ReadOne / Read Many -- Cascade
        List<T> GetEntitiesWithChildren();
    }
}
