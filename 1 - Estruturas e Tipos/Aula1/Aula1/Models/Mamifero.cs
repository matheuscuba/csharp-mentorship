using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1.Models
{
    public abstract class Mamifero
    {
        public void EsteAnimalBebeLeite()
        {
            Console.WriteLine("Sim, este animal toma leite");
        }

        public void EsteAnimalRespira()
        {
            Console.WriteLine("óbvio");
        }

        public abstract void NumeroDePatas();
    }

    public interface IMamifero
    {
        void EsteAnimalBebeLeite();
        void NumeroDePatas();
        void RespiraDentroAgua();
    }

    public class Elefante : Mamifero
    {
        public void EsteAnimalBebeLeite()
        {
            Console.WriteLine("Sim, este animal toma leite");
        }

        public override void NumeroDePatas()
        {
            Console.WriteLine("Este animal tem 4 patas");
        }

        public void RespiraDentroAgua()
        {
            Console.WriteLine("Não respira");
        }
    }

    public class Baleia : Mamifero
    {

        public override void NumeroDePatas()
        {
            Console.WriteLine("Este animal não tem patas, seu burro");
        }

        public void RespiraDentroAgua()
        {
            Console.WriteLine("Respira");
        }
    }
}
