using Aula3.Implementations.Prefeitura;
using Aula3.Interfaces;

namespace Aula3.Implementations
{
    public class PrefeituraFactory
    {
        public IPrefeitura CriarPrefeitura(int id)
        {
            switch (id)
            {
                case 1:
                    return new PrefeituraSaoPaulo();

                case 2:
                    return new PrefeituraFlorianopolis();

                default:
                    throw new NotImplementedException();
            }
        }
    }
}
