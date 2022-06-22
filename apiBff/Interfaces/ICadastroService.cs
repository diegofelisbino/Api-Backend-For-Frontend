using Refit;
using apiBff.Dtos;

namespace apiBff.Interfaces
{
    public interface ICadastroService
    {
        [Get("/Cadastro/BuscarCadastroMotorista")]
        Task<MotoristaDto> BuscarCadastroMotorista();
    }
}