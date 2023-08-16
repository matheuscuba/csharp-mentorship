using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Utils
{
    public static class Utils
    {
        public static bool NomeVazio(string nome)
        {
            return String.IsNullOrEmpty(nome);
        }
    }
}
