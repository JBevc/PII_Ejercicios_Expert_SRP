namespace Library
{
    public class Paciente 
    {
        public string NombrePaciente {get;}
        public string EdadPaciente  {get;}
        public Paciente (string nombre, string edad)
        {
            this.NombrePaciente = nombre;
            this.EdadPaciente = edad;
        }
    }
}