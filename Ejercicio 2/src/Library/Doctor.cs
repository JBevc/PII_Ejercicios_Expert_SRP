namespace Library
{
    public class Doctor
    {
        new string DoctorName {get;}
        new string Especialidad {get;}

        public Doctor (string nombre, string especialidad)
        {
            this.DoctorName = nombre;
            this.Especialidad = especialidad;
        }

    }
}