namespace eBios.Api.PatientAdministration.Model
{
    public class RegistrationDetails
    {
        public string Name { get; set; } = "Test";
        public string DOB { get; set; } = DateTime.Now.ToString();
    }
}
