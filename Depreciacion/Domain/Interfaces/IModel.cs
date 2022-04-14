using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IModel<T>
    {
        int Add(T t);
        void Delete(T t);
        List<T> Read();

    }
}
