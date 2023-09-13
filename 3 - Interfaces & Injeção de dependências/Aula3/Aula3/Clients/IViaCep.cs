using Aula3.Models;
using Refit;

namespace Aula3.Clients
{
    public interface IViaCep
    {
        [Get("/ws/{cep}/json")]
        public Task<ApiResponse<ViaCepResponse>> GetCepInformation(string cep);
    }
}
