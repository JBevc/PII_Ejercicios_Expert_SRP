using System;
using System.Collections.Generic;
using System.Text;

namespace Library
{
    public class AppointmentService
    {

        public static List<string> Specialities = new List<string> {"Pediatry","Dermatology", "Cardiology"};

        public static string CreateAppointment(string name, string id, string phoneNumber, DateTime date, string appoinmentPlace, string doctorName, int patientAge, string speciality, string appointmentId)
        {
            StringBuilder stringBuilder = new StringBuilder("Scheduling appointment...\n");
            Boolean isValid = true;
            bool SpecialityVerifier = Specialities.Contains(speciality);

            if (string.IsNullOrEmpty(name))
            {
                stringBuilder.Append("Unable to schedule appointment, 'name' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(id))
            {
                stringBuilder.Append("Unable to schedule appointment, 'id' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(phoneNumber))
            {
                stringBuilder.Append("Unable to schedule appointment, 'phone number' is required\n");
                isValid = false;
            }

            if (string.IsNullOrEmpty(appoinmentPlace))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appoinment place' is required\n");
                isValid = false;
            }


            if (string.IsNullOrEmpty(doctorName))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor name' is required\n");
                isValid = false;
            }

            
            int maxAge = 200;
            if (patientAge<0 || patientAge>maxAge)
            {
                stringBuilder.Append("Unable to schedule appointment, 'patient's age' is invalid\n");
                isValid = false;
            }
            
        

            if (string.IsNullOrEmpty(speciality))
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor's speciality' is required\n");
                isValid = false;
            }
            
            if (!SpecialityVerifier)
            {
                stringBuilder.Append("Unable to schedule appointment, 'doctor's speciality' is invalid\n");
                isValid = false;
            }
            

            if (string.IsNullOrEmpty(appointmentId))
            {
                stringBuilder.Append("Unable to schedule appointment, 'appointment's identifier' is required\n");
                isValid = false;
            }
            

            if (isValid)
            {
                stringBuilder.Append("Appoinment scheduled");
            }

            return stringBuilder.ToString();

            
        }

    }
}
