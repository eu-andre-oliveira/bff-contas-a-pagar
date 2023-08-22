using Application.Responses;
using Application.ViewModels.Requests;

namespace Application.Services.Interfaces
{
    public interface IContaService
    {
        List<ContaResponse> ListarConta();
        void CadastrarConta(CriarContaRequest conta);
        void EditarConta(EditarContaRequest conta);

    }
}
