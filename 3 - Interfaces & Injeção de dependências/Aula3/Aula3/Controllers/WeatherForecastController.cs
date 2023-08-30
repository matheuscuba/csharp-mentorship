using Aula3.Implementations;
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

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBancoDados banco)
        {
            _logger = logger;
            _banco = banco;

            _repoCidade = new RepositorioCidade();

            _repoCidade.Adicionar(new Cidade() { 
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
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get(int id)
        {
            var sp = _repoCidade.BuscarPorId("2");

            return Utils.ReturnPropriedade(sp, "Id");

            //return this._banco.BuscarCidade(id);
        }
    }
}