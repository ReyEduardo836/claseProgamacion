using Domain.Entities;
using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Repository
{
    public class BinaryEmpleadoRepository : IEmpleadoModel
    {
        private RAFContext raf;
        private const int SIZE = 660;
        public BinaryEmpleadoRepository()
        {
            raf = new RAFContext("empleado", SIZE);
        }

        public void Add(Empleado t)
        {
            try
            {
                raf.Create<Empleado>(t);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void Delete(Empleado t)
        {
            throw new NotImplementedException();
        }

        public Activo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public List<Empleado> Read()
        {
            try
            {
                return raf.GetAll<Empleado>();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void Update(Activo t)
        {
            throw new NotImplementedException();
        }
    }
}
