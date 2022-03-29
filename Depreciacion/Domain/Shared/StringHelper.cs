using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Shared
{
    public class StringHelper
    {
        public static bool Wspaces(string[] campos)
        {
            var validacion = campos.Where(x => string.IsNullOrWhiteSpace(x));
            return !validacion.Contains("false");
        }
    }
}
