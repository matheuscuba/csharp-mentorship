using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }

        public int Idade { get; set; }

        public virtual void Caminhar()
        {
            Console.WriteLine("Esta pessoa caminha com os pés");
        }
    }

    public class Acrobata : Pessoa
    {
        public override void Caminhar()
        {
            Console.WriteLine("Esta pessoa caminha plantando bananeira");
        }
    }

    public sealed class Logger 
    { 
        public void LogInfo()
        {

        }

        public void LogError()
        {

        }
    }
}
