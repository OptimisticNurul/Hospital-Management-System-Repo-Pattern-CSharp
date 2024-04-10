using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalManagementSystem.DA;

namespace HospitalManagementSystem.BL
{
    public class PatientManagement
    {
        IPatientDataAccess _dataAccess;

        public PatientManagement(IPatientDataAccess dataAccess)
        {
            _dataAccess = dataAccess;
        }

        public List<Patient> GetPatients()
        {
            return _dataAccess.GetPatients();
        }

        public Patient GetPatient(int id)
        {
            return _dataAccess.GetPatient(id);
        }

        public bool AddPatient(Patient model)
        {
            return _dataAccess.AddPatient(model);
        }

        public bool UpdatePatient(Patient model)
        {
            return _dataAccess.UpdatePatient(model);
        }

        public bool DeletePatient(int id)
        {
            return _dataAccess.DeletePatient(id);
        }
    }
}
