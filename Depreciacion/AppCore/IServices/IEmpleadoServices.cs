using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.IServices
{
    public interface IEmpleadoServices : IServices<Empleado>
    {
        Activo GetById(int id);
        bool Delete(int id);
        void Update(Activo t);
    }
}
