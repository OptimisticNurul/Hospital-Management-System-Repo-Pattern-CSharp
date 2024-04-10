using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace HospitalManagementSystem.DA
{
    public interface IPatientDataAccess
    {
        List<Patient> GetPatients();
        Patient GetPatient(int id);
        bool AddPatient(Patient model);
        bool UpdatePatient(Patient model);
        bool DeletePatient(int id);
    }
}
