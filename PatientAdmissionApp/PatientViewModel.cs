using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatientAdmissionApp
{
    public class PatientViewModel : IPatient, INotifyPropertyChanged
    {
        public ObservableCollection<PatientModel> Patients { get; private set; } = new ObservableCollection<PatientModel>();
        public event EventHandler PatientUpdated;

        public IList<PatientModel> GetRegisteredPatients()
        {
            return Patients.ToList();
        }

        public void RegisterPatient(PatientModel patient)
        {
            Patients.Add(patient);
            OnPatientRegistered(new PatientEventArgs(patient));
        }

        public void updateAppointmentStatus(PatientModel patient, string status)
        {
            patient.ConfirmationStatus = status;
            OnAppointmentUpdated(new PatientEventArgs(patient));
        }

        public event EventHandler<PatientEventArgs> PatientRegistered;
        public event EventHandler<PatientEventArgs> AppointmentUpdated;
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPatientRegistered(PatientEventArgs e)
        {
            PatientRegistered?.Invoke(this, e);
        }

        protected virtual void OnAppointmentUpdated(PatientEventArgs e)
        {
            AppointmentUpdated?.Invoke(this, e);
        }
    }
}
