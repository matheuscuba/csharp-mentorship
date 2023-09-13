using Aula3.Models;
using System.Runtime.Remoting;

namespace Aula3.Implementations
{
    public abstract class Repositorio<T1> 
        where T1 : Entidade
    {
        protected List<T1> _values { get; set; } = new List<T1>();

        public void Adicionar(T1 valor)
        {
            _values.Add(valor);
        }

        public async Task<T1> BuscarPorId(string id)
        {
            await Task.Delay(3000);
            return _values.FirstOrDefault(x => x.Id == id);
        }
    }

    public class RepositorioCidade : Repositorio<Cidade>
    {
        public Cidade BuscarPeloNome(string nome)
        {
            return this._values.FirstOrDefault(x => x.Nome == nome);
        }
    }

    public class RepositorioEstado: Repositorio<Estado>
    {
    }
}
