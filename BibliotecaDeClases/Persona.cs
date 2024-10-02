namespace BibliotecaDeClases
{
    public class Persona
    {
        #region Atributos
        private String apellido;
        private String nombre;
        private DateTime fechaNacimiento;
        #endregion

        #region Constructores
        public Persona(String nombre, String apellido, DateTime fechaNacimiento)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.fechaNacimiento = fechaNacimiento;
        }

        public Persona() {
            nombre = "Amaro";
            apellido = "Suárez";
            fechaNacimiento = new DateTime();
        }
        #endregion

        #region Propiedades
        public String Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public DateTime FechaNac
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }
        #endregion
    }
}
