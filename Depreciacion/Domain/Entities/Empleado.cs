using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class Empleado //SIZE = 657
    {
        public int Id { get; set; } // 4
        public string Cedula { get; set; } //
        public string Nombre { get; set; } // 20*2 = 40 + 3 45
        public string Apellido { get; set; }// 20*3 = 40 + 3 = 45
        public string Direcciones { get; set; } //100 * 2 = 200+3 = 205
        public string Telefono { get; set; } // 10*2 = 20 +3 = 25
        public string Email { get; set; } // 50*2 = 100 + 3 = 105
        public int Estado { get; set; }// 4
    }
}
