using Aula3.Interfaces;

namespace Aula3.Implementations
{
    public class BancoDadosAzure : IBancoDados
    {
        public string BuscarCidade(int id)
        {
            switch (id)
            {
                case 1:
                    return "São Paulo";
                default:
                    return String.Empty;
            }
        }
    }
}
