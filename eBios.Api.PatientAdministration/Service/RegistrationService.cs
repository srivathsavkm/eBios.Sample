using eBios.Api.PatientAdministration.Model;
using eBios.Api.PatientAdministration.Service.Interface;

namespace eBios.Api.PatientAdministration.Service
{
    public class RegistrationService : IRegistration
    {
        public RegistrationDetails GetRegistration(int patientId)
        {
            return new RegistrationDetails();
        }
    }
}
