using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalManagementSystem.DA
{
    public class PatientDataAccess : IPatientDataAccess
    {
        List<Patient> patientList = new List<Patient>()
        {
            new Patient(1, "Rahim Ahmed", "1 Dhanmondi, Dhaka"),
            new Patient(2, "Fatema Khatun", "15 Gulshan, Dhaka"),
            new Patient(3, "Ayesha Begum", "27 Banani, Dhaka"),
            new Patient(4, "Mohammad Khan", "10 Mirpur, Dhaka"),
            new Patient(5, "Sultana Akter", "5 Uttara, Dhaka"),
            new Patient(6, "Asad Ullah", "20 Badda, Dhaka"),
            new Patient(7, "Nadia Rahman", "8 Rampura, Dhaka"),
            new Patient(8, "Abdul Wahab", "12 Malibagh, Dhaka"),
            new Patient(9, "Sadia Khan", "25 Motijheel, Dhaka"),
            new Patient(10, "Imran Ali", "3 Tejgaon, Dhaka"),
            new Patient(11, "Fahmida Akhter", "18 Basundhara, Dhaka"),
            new Patient(12, "Kamrul Hasan", "22 Shyamoli, Dhaka"),
            new Patient(13, "Nusrat Jahan", "14 Baridhara, Dhaka"),
            new Patient(14, "Shafiqul Islam", "17 Mohammadpur, Dhaka"),
            new Patient(15, "Farhana Rahman", "9 Pallabi, Dhaka"),
        };

        public List<Patient> GetPatients()
        {
            return patientList.OrderBy(x => x.ID).ToList();
        }

        public Patient GetPatient(int id)
        {
            Patient patient = patientList.FirstOrDefault(x => x.ID == id);
            return patient;
        }

        public bool AddPatient(Patient model)
        {
            patientList.Add(model);
            return true;
        }

        public bool UpdatePatient(Patient model)
        {
            bool isExecuted = false;
            Patient patient = patientList.FirstOrDefault(x => x.ID == model.ID);
            if (patient != null)
            {
                patientList.Remove(patient);
                patientList.Add(model);
                isExecuted = true;
            }
            return isExecuted;
        }

        public bool DeletePatient(int id)
        {
            bool isExecuted = false;
            Patient patient = patientList.FirstOrDefault(x => x.ID == id);
            if (patient != null)
            {
                patientList.Remove(patient);
                isExecuted = true;
            }
            return isExecuted;
        }
    }
}
