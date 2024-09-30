namespace BibliotecaDeClases
{
    public class Persona
    {
        private String apellido;
        private String nombre;
        private DateTime fechaNacimiento;
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value.ToUpper(); }
        }
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value.ToLower(); }
        }
        public DateTime FechaNac
        {
            get { return fechaNacimiento; }
            set
            {
                if (value.Year >= 1900)
                {
                    fechaNacimiento = value;
                }
            }
        }
    }
}
