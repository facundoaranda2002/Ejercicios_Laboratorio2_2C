using Entidades;
namespace Ejercicio_24
{
    public partial class frmTemperatura : Form
    {
        public frmTemperatura()
        {
            InitializeComponent();
        }

        private void btnConvertFahrenheit_Click(object sender, EventArgs e)
        {
            double auxFahrenheit;
            if (double.TryParse(this.txtFahrenheit.Text, out auxFahrenheit))
            {
                Fahrenheit fahrenheit = auxFahrenheit;
                this.txtFahrenheitAFahrenheit.Text = fahrenheit.GetGrados().ToString();
                this.txtFahrenheitACelsius.Text = ((Celsius)fahrenheit).GetGrados().ToString();
                this.txtFahrenheitAKelvin.Text = ((Kelvin)fahrenheit).GetGrados().ToString();
            }
        }

        private void btnConvertCelsius_Click(object sender, EventArgs e)
        {
            double auxCelsius;
            if (double.TryParse(this.txtCelsius.Text, out auxCelsius))
            {
                Celsius celsius = auxCelsius;
                this.txtCelsiusAFahrenheit.Text = ((Fahrenheit)celsius).GetGrados().ToString();
                this.txtCelsiusACelsius.Text = celsius.GetGrados().ToString();
                this.txtCelsiusAKelvin.Text = ((Kelvin)celsius).GetGrados().ToString();
            }
        }

        private void btnConvertKelvin_Click(object sender, EventArgs e)
        {
            double auxKelvin;
            if (double.TryParse(this.txtKelvin.Text, out auxKelvin))
            {
                Kelvin kelvin = auxKelvin;
                this.txtKelvinAFahrenheit.Text = ((Fahrenheit)kelvin).GetGrados().ToString();
                this.txtKelvinACelsius.Text = ((Celsius)kelvin).GetGrados().ToString();
                this.txtKelvinAKelvin.Text = kelvin.GetGrados().ToString();
            }
        }
    }
}