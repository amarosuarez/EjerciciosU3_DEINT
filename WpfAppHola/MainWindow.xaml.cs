using BibliotecaDeClases;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfAppHola
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            String nombre = nombreTB.Text; 
            String apellido = apellidoTB.Text;
            String day = diaTB.Text;
            String month = mesTB.Text;
            String year = anioTB.Text;
            bool correct = false;

            if (nombre != "" && apellido != "" && day != "" && month != "" && year != "")
            {
                int dia = Int32.Parse(diaTB.Text);
                int mes = Int32.Parse(mesTB.Text);
                int anyo = Int32.Parse(anioTB.Text);

                switch (mes)
                {
                    case 1:
                    case 3:
                    case 5:
                    case 7:
                    case 8:
                    case 10:
                    case 12:
                        if (dia > 0 && dia <= 31)
                        {
                            correct = true;
                        }
                        break;
                    case 4:
                    case 6:
                    case 9:
                    case 11:
                        if (dia > 0 && dia <= 30)
                        {
                            correct = true;
                        }
                        break;
                    case 2:
                        if (DateTime.IsLeapYear(anyo))
                        {
                            if (dia > 0 && dia <= 29)
                            {
                                correct = true;
                            }
                        }
                        else if (dia > 0 && dia < 29)
                        {
                            correct = true;
                        }
                        break;
                }

                
            }

            if (correct)
            {
                DateTime cumple = new DateTime();
                String fecha = day + "/" + month + "/" + year;
                cumple = DateTime.Parse(fecha);


                Persona persona = new Persona(nombreTB.Text, apellidoTB.Text, cumple);

                String messageBoxText = "Hola, " + persona.Nombre + " " + persona.Apellido + " " +
                    " naciste el " + persona.FechaNac.ToLongDateString();
                MessageBoxResult result;

                result = MessageBox.Show(messageBoxText);
            } else
            {
                MessageBox.Show("Revisa que todos los campos estén completos o que la fecha sea correcta", "ERROR!");
            }
        }

        private void NumberValidationTextBox(object sender, TextCompositionEventArgs e)
        {
            Regex regex = new Regex("[^0-9]+");
            e.Handled = regex.IsMatch(e.Text);
        }
    }

}