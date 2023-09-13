namespace Aula3.Implementations.Departamento
{
    public class DepartamentoFinanceiro : DepartamentoAbstract
    {
        public override string Verificar(string request)
        {
            if (request.ToLower().Contains("nf"))
                return "O Departamento Financeiro está verificando o seu pedido";
            else 
                return base.Verificar(request);
        }
    }

    public class DepartamentoUrbano : DepartamentoAbstract
    {
        public override string Verificar(string request)
        {
            if (request.ToLower().Contains("rua"))
                return "O Departamento Urbano está verificando o seu pedido";
            else
                return base.Verificar(request);
        }
    }

    public class DepartamentoEleitoral : DepartamentoAbstract
    {
        public override string Verificar(string request)
        {
            if (request.ToLower().Contains("voto"))
                return "O Departamento Eleitoral está verificando o seu pedido";
            else
                return base.Verificar(request);
        }
    }
}
