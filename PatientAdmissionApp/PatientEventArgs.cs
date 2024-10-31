using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAdmissionApp
{
    public class PatientEventArgs : EventArgs
    {
        public PatientModel Patient { get; }

        public PatientEventArgs(PatientModel patient)
        {
            Patient = patient;
        }
    }
}
