using Aula3.Models;
using System.Runtime.Remoting;

namespace Aula3.Implementations
{
    public abstract class Repositorio<T1, T2> 
        where T1 : Entidade
    {
        protected List<T1> _values { get; set; } = new List<T1>();

        public void Adicionar(T1 valor)
        {
            _values.Add(valor);
        }

        public T1 BuscarPorId(string id)
        {
            return _values.FirstOrDefault(x => x.Id == id);
        }
    }

    public class RepositorioCidade : Repositorio<Cidade, Estado>
    {
        public Cidade BuscarPeloNome(string nome)
        {
            return this._values.FirstOrDefault(x => x.Nome == nome);
        }
    }


    public static class Utils {
    
        public static string ReturnPropriedade(object obj, string nome)
        {
            return (string)obj.GetType().GetProperty(nome).GetValue(obj, null);
        }
    }
}
