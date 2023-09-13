using System.Reflection.Metadata;

namespace Aula3.Implementations.Departamento
{
    public abstract class DepartamentoAbstract : IDepartamento
    {
        private IDepartamento _proximoDepartamento;

        public IDepartamento ConfigurarProximo(IDepartamento departamento)
        {
            this._proximoDepartamento = departamento;
            return departamento;
        }

        public virtual string Verificar(string request)
        {
            if (this._proximoDepartamento != null)
                return this._proximoDepartamento.Verificar(request);
            else
                return String.Empty;
        }
    }
}
