using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public partial class Advogado
    {
        private string _nome;

        public string Nome
        {
            get => $"Dr. {_nome}";
            set
            {
                this._nome = value;
            }
        }

        public string Endereco { get; set; }

        internal int Idade { get; set; }

        private string IdSistemaSTJ { get; set; }
    }
}
