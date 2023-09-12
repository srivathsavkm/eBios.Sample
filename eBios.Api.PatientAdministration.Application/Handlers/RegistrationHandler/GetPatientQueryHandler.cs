using eBios.Api.PatientAdministration.Application.Commands;
using eBios.Api.PatientAdministration.Application.ResponseModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBios.Api.PatientAdministration.Application.Handlers.RegistrationHandler
{
    public class GetPatientQueryHandler : IRequestHandler<GetPatientQuery, PatientModel>
    {
        public async Task<PatientModel> Handle(GetPatientQuery request, CancellationToken cancellationToken)
        {
            return new PatientModel();
        }
    }
}
