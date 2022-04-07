using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    class DetallesAE // SIZE 25
    {
        public int Id { get; set; } // 4
        public int IdEmpleado { get; set; } //4
        public int IdActivo { get; set; } //4
        public long FechaInicio { get; set; } // 8
        public bool IsActivo { get; set; }// 1
    }
}
