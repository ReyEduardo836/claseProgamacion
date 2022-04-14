using AppCore.IServices;
using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCore.Services
{
    public class EmpleadoServices : BaseServices<Empleado>, IEmpleadoServices //as IEmpleadoServices
    {
        IEmpleadoModel empleadoModel; // is BinaryEmpleadoRepository
        public EmpleadoServices (IEmpleadoModel model) : base(model)
        {
            this.empleadoModel = model;
        }

        public bool Delete(int id)
        {
            return empleadoModel.Delete(id);
        }

        public Empleado GetById(int id)
        {
            return empleadoModel.GetById(id);
        }

        public void Update(Empleado t)
        {
           empleadoModel.Update(t);
        }
    }
}
