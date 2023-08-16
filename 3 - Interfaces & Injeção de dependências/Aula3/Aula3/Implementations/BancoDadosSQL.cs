using Aula3.Interfaces;

namespace Aula3.Implementations
{
    public class BancoDadosSQL : IBancoDados
    {
        public string BuscarCidade(int id)
        {
            switch (id)
            {
                case 1:
                    return "São Paulo";
                case 2:
                    return "Caxias do Sul";
                case 3:
                    return "Florianópolis";
                default:
                    return String.Empty;
            }
        }
    }
}
