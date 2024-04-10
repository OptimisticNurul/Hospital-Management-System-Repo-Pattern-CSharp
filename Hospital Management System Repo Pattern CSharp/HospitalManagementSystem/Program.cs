using System;
using System.Collections.Generic;
using System.Linq;
using HospitalManagementSystem.BL;
using HospitalManagementSystem.DA;

namespace HospitalManagementSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            PatientManagement patientManagement = new PatientManagement(new PatientDataAccess());
            bool isRunning = true;

            while (isRunning)
            {
                try
                {
                    Console.WriteLine("Type 'L' for List, 'A' for Add, 'U' for Update 'D' for Delete, 'S' for Search,'C' for Clear, 'X' for Exit");
                    string command = Console.ReadLine();

                    if (command == "L")
                    {
                        List<Patient> patientList = patientManagement.GetPatients();
                        Console.WriteLine("List of Patients:");
                        Console.WriteLine("ID".PadRight(4) + " | " + "Full Name".PadRight(20) + " | " + "Location");
                        Console.WriteLine(new string('-', 45));

                        foreach (Patient patient in patientList)
                        {
                            Console.WriteLine(patient.ID.ToString().PadRight(4) + " | " +
                                              patient.PatientFullName.PadRight(20) + " | " +
                                              patient.PatientLocation);
                        }
                    }
                    else if (command == "S")
                    {
                        Console.WriteLine("Input an ID to find a patient:");
                        string id = Console.ReadLine();
                        Patient aPatient = patientManagement.GetPatient(Convert.ToInt32(id));
                        Console.WriteLine(aPatient.ID + ". " + aPatient.PatientFullName + " -- " + aPatient.PatientLocation);
                    }
                    else if (command == "A")
                    {
                        Console.WriteLine("Input an ID:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a full name:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Input a location:");
                        string location = Console.ReadLine();
                        Patient aPatient = new Patient();
                        aPatient.ID = Convert.ToInt32(id);
                        aPatient.PatientFullName = fullName;
                        aPatient.PatientLocation = location;
                        bool isExecuted = patientManagement.AddPatient(aPatient);

                        if (isExecuted)
                        {
                            Console.WriteLine("Added successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to add.");
                        }
                    }
                    else if (command == "U")
                    {
                        Console.WriteLine("Input an ID:");
                        string id = Console.ReadLine();
                        Console.WriteLine("Input a full name:");
                        string fullName = Console.ReadLine();
                        Console.WriteLine("Input a location:");
                        string location = Console.ReadLine();
                        Patient aPatient = new Patient();
                        aPatient.ID = Convert.ToInt32(id);
                        aPatient.PatientFullName = fullName;
                        aPatient.PatientLocation = location;
                        bool isExecuted = patientManagement.UpdatePatient(aPatient);

                        if (isExecuted)
                        {
                            Console.WriteLine("Updated successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to update.");
                        }
                    }
                    else if (command == "D")
                    {
                        Console.WriteLine("Input an ID:");
                        string id = Console.ReadLine();
                        bool isExecuted = patientManagement.DeletePatient(Convert.ToInt32(id));

                        if (isExecuted)
                        {
                            Console.WriteLine("Deleted successfully.");
                        }
                        else
                        {
                            Console.WriteLine("Failed to delete.");
                        }
                    }
                    else if (command == "C")
                    {
                        Console.Clear();
                    }
                    else if (command == "X")
                    {
                        isRunning = false;
                    }
                    else
                    {
                        Console.WriteLine("Command not found.");
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
