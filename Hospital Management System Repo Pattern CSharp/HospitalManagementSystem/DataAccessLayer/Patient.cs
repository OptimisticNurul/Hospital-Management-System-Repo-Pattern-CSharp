using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DA
{
    public class Patient
    {
        public int ID;
        public string PatientFullName;
        public string PatientLocation;

        public Patient()
        {

        }

        public Patient(int id, string fullName, string location)
        {
            ID = id;
            PatientFullName = fullName;
            PatientLocation = location;
        }
    }
}
