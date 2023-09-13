using eBios.Api.PatientAdministration.Model;

namespace eBios.Api.PatientAdministration.Service.Interface
{
    public interface IRegistration
    {
        public RegistrationDetails GetRegistration(int patientId);
    }
}
