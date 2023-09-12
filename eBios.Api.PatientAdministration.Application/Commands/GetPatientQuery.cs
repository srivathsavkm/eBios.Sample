using eBios.Api.PatientAdministration.Application.ResponseModels;
using MediatR;

namespace eBios.Api.PatientAdministration.Application.Commands
{
    public class GetPatientQuery: IRequest<PatientModel>
    {
        public int PatientID { get; set; }
    }
}
