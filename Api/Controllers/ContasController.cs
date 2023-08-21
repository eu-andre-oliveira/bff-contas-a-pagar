using Application.Responses;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Produces("application/json")]
    [EnableCors("CORSPOLICY")]
    [ResponseCache(NoStore = true, Location = ResponseCacheLocation.None)]
    public class ContasController : ControllerBase
    {
        [HttpGet("ListarContas")]
        public IActionResult ListarContas()
        {

            var response = new List<ContasResponse>()
            {
                new ContasResponse()
                {
                    Id = 1,
                    CodigoBarras = "1684648164164165135651321351351310178684619860",
                    DataVencimento = DateTime.Now.ToString("yyyy-MM-dd"),
                    NomeConta = "Netflix",
                    Paga = false,
                    Valor = 45.99m
                }
            };
            return Ok(response);
        }
    }
}
