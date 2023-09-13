using Aula3.Clients;
using Aula3.Implementations;
using Aula3.Implementations.Departamento;
using Aula3.Interfaces;
using Aula3.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aula3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBancoDados _banco;
        private readonly RepositorioCidade _repoCidade;
        private readonly RepositorioEstado _repoEstado;
        private readonly IViaCep _viaCepClient;

        private readonly DepartamentoFinanceiro _departamentoFinanceiro;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBancoDados banco, IViaCep viaCepClient)
        {
            _logger = logger;
            _banco = banco;

            _repoCidade = new RepositorioCidade();
            _repoEstado = new RepositorioEstado();

            _repoCidade.Adicionar(new Cidade()
            {
                Nome = "Caxias do Sul",
                Id = "1"
            });

            _repoCidade.Adicionar(new Cidade()
            {
                Nome = "São Paulo",
                Id = "2"
            });

            _repoCidade.Adicionar(new Cidade()
            {
                Nome = "Rio de Janeiro",
                Id = "3"
            });

            _repoEstado.Adicionar(new Estado()
            {
                Id = "1",
                Nome = "Rio Grande do Sul"
            });

            _viaCepClient = viaCepClient;

            _departamentoFinanceiro = new DepartamentoFinanceiro();

            _departamentoFinanceiro
                .ConfigurarProximo(new DepartamentoEleitoral())
                .ConfigurarProximo(new DepartamentoUrbano());
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<object> Get(int id, int idEstado)
        {
            var cidade = _repoCidade.BuscarPorId(id.ToString());
            var estado = _repoEstado.BuscarPorId(idEstado.ToString());

            Task.WaitAll(cidade, estado);

            return new { cidade = cidade.Result, estado = estado.Result };
        }

        [HttpGet("Cep")]
        public async Task<ViaCepResponse> GetCep(string cep)
        {
            var result = await _viaCepClient.GetCepInformation(cep);
            return result.Content;
        }

        [HttpGet("EmitirNota")]
        public async Task<string> EmitirNotaFiscal(int id)
        {
            var factory = new PrefeituraFactory();
            var prefeitura = factory.CriarPrefeitura(id);

            return prefeitura.EmitirNotaFiscal();
        }

        [HttpGet("Pedido")]
        public async Task<string> VerificarPedidoPrefeitura(string pedido)
        {
            var result = _departamentoFinanceiro.Verificar(pedido);

            if (!String.IsNullOrEmpty(result))
                return result;
            else
                return "Ninguem pode verificar seu pedido";
        }
    }
}