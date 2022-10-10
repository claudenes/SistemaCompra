using MediatR;
using Microsoft.AspNetCore.Mvc;
using SistemaCompra.Application.SolicitacaoCompra.Command.RegistrarCompra;

namespace SistemaCompra.API.SolicitacaoCompra
{
    public class SolicitacaoCompraController : Controller
    {
        private readonly IMediator _mediator;

        public SolicitacaoCompraController(IMediator mediator)
        {
            this._mediator = mediator;
        }

        [HttpPost, Route("solicitacaocompra/salvar")]
        public IActionResult SolicitacaoCompra([FromBody] RegistrarCompraCommand registrarcompraCommand)
        {
            _mediator.Send(registrarcompraCommand);
            return StatusCode(201);
        }
    }
}
