using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eBios.Api.PatientAdministration.Application.ResponseModels
{
    public class PatientModel
    {
        public string Name { get; set; } = "Test";
        public string DOB { get; set; } = DateTime.Now.ToString();
    }
}
