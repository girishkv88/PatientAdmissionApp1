using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAdmissionApp
{
    public interface IPatient
    {
        ObservableCollection<PatientModel> Patients { get; }    
        void RegisterPatient(PatientModel patient);  
        void updateAppointmentStatus(PatientModel patient, string status);

        IList<PatientModel> GetRegisteredPatients();   

        event EventHandler PatientUpdated;

    }
}
