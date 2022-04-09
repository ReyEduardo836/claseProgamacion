using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IEmpleadoModel : IModel<Empleado>
    {
        Activo GetById(int id);
        bool Delete(int id);
        void Update(Activo t);
    }
}
