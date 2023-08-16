using Aula3.Implementations;
using Aula3.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Aula3.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;
        private readonly IBancoDados _banco;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IBancoDados banco)
        {
            _logger = logger;
            _banco = banco;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public string Get(int id)
        {
            return this._banco.BuscarCidade(id);
        }
    }
}