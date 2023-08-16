using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula1
{
    public class EstruturaDados
    {
        public EstruturaDados() {

            // Class Types

            object obj = "Matheus Cuba";
            dynamic dyn = 123;

            string nome = "Matheus Cuba";
            char inicial = 'M';

            Console.WriteLine($"Meu nome é {nome}");
            Console.WriteLine($"Meu estado civil é {EEstadoCivil.Casado}");

            Console.WriteLine($"Max short {short.MaxValue}");
            Console.WriteLine($"Max ushort {ushort.MaxValue}");
            Console.WriteLine($"Max int {int.MaxValue}");
            Console.WriteLine($"Max uint {uint.MaxValue}");
            Console.WriteLine($"Max long {long.MaxValue}");
            Console.WriteLine($"Max ulong {ulong.MaxValue}");

            Console.WriteLine($"Max float {float.MaxValue}");
            Console.WriteLine($"Max double {double.MaxValue}");
            Console.WriteLine($"Max decimal {decimal.MaxValue}");

            short numero16 = 1;
            int numero32 = 11;
            long numeroGrande = 123123123;

            float salario = 999.12F;
            double temperatura = 24.5;
            decimal salarioD = 12223.12m;

            // Value Types
            bool verdadeiro = false;
            EEstadoCivil status = EEstadoCivil.Casado;

            var meuNomeCompleto = "Matheus Cuba";


            }

        public enum EEstadoCivil
        {
            Solteiro = 100, //100
            Casado, //101
            Divorciado, //102
            Enrolado //103
        }
    }
}
