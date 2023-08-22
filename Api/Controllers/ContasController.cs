using Application.Responses;
using Application.Services.Interfaces;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [EnableCors()]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class ContasController : ControllerBase
    {
        private readonly IContaService _contaService;
        public ContasController(IContaService contaService)
        {
            _contaService = contaService;
        }
        [HttpGet("ListarContas")]
        public IActionResult ListarContas()
        {

            //var response = new List<ContaResponse>()
            //{
            //    new ContaResponse()
            //    {
            //        Id = 1,
            //        CodigoBarras = "1684648164164165135651321351351310178684619860",
            //        DataVencimento = DateTime.Now.ToString("yyyy-MM-dd"),
            //        NomeConta = "Netflix",
            //        Paga = false,
            //        Valor = 45.99m
            //    }
            //};
            List<ContaResponse> response = _contaService.ListarConta();
            return Ok(response);
        }
    }
}
