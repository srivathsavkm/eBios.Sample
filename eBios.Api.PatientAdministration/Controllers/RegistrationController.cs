using eBios.Api.PatientAdministration.Service.Interface;
using Microsoft.AspNetCore.Mvc;

namespace eBios.Api.PatientAdministration.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class RegistrationController : ControllerBase
    {
        private readonly IRegistration _registration;
        public RegistrationController(IRegistration registration)
        {
            _registration= registration;
        }
        [HttpGet]
        public IActionResult GetPatient([FromQuery] int patientId)
        {
            var response = _registration.GetRegistration(patientId);

            return Ok(response);
        }
    }
}
