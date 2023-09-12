using eBios.Api.PatientAdministration.Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace eBios.PatientAdministration.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly IMediator _mediator;
        public RegistrationController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpGet]
        public IActionResult GetPatient([FromQuery] GetPatientQuery model)
        {
            var response = _mediator.Send(model);

            return Ok(response);
        }
    }
}
