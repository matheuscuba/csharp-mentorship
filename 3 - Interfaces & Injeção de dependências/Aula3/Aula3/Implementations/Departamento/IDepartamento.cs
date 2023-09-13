namespace Aula3.Implementations.Departamento
{
    public interface IDepartamento
    {
        IDepartamento ConfigurarProximo(IDepartamento departamento);

        string Verificar(string request);
    }
}
