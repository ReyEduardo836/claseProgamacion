using Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Activo // SIZE = 540
    {
        public int Id { get; set; } // 4
        public String Nombre { get; set; } // 20 * 2 = 40 + 3 = 45
        public string Descripcion { get; set; } //200 * 2 = 400 + 3 = 405
        public double Valor { get; set; } // 8
        public int VidaUtil { get; set; } // 4
        public double ValorResidual { get; set; } //8       
        public string Codigo { get; set; } // 10 * 2 = 20 + 3 = 25 UVID System.git.new Guid
        public int Empleado { get; set; } // 4
        public string Estado { get; set; } // 15 * 2 = 30 + 3 = 35

    }
}
