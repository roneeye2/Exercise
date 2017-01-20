using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GloboMart.Framwork.Interface.Data
{
    public interface ICRUD<T> : IDisposable
    {
        T Create(T obj);
        IEnumerable<T> Read();
        T Read(int id);
        T Update(T obj);
        bool Delete(T obj);
    }
}
