using Moneda;

namespace Ejercicio_23
{
    public partial class frmMonedas : Form
    {
        public frmMonedas()
        {
            InitializeComponent();
            this.txtCotizacionEuro.Text = Euro.GetCotizacion().ToString();
            this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
            this.txtCotizacionPeso.Text = Pesos.GetCotizacion().ToString();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            double auxCotizacionEuro;
            double auxCotizacionPeso;

            if (this.btnCandado.ImageIndex == 0)
            {
                this.btnCandado.ImageIndex = 1;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionDolar.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
            }
            else if (((double.TryParse(this.txtCotizacionEuro.Text, out auxCotizacionEuro)) && auxCotizacionEuro > 0) && ((double.TryParse(this.txtCotizacionPeso.Text, out auxCotizacionPeso)) && auxCotizacionPeso > 0))
            {
                this.btnCandado.ImageIndex = 0;
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
            }
        }

        private void txtCotizacionDolar_Leave(object sender, EventArgs e)
        {
            this.txtCotizacionDolar.Text = Dolar.GetCotizacion().ToString();
        }

        private void txtCotizacionEuro_Leave(object sender, EventArgs e)
        {
            double nuevaCotizacionEuro;
            if (!(double.TryParse(this.txtCotizacionEuro.Text, out nuevaCotizacionEuro)) || nuevaCotizacionEuro <= 0)
            {
                this.txtCotizacionEuro.Focus();
            }
            else
            {
                Euro.SetCotizacion(nuevaCotizacionEuro);
            }
        }

        private void txtCotizacionPeso_Leave(object sender, EventArgs e)
        {
            double nuevaCotizacionPeso;
            if (!(double.TryParse(this.txtCotizacionPeso.Text, out nuevaCotizacionPeso)) || nuevaCotizacionPeso <= 0)
            {
                this.txtCotizacionPeso.Focus();
            }
            else
            {
                Pesos.SetCotizacion(nuevaCotizacionPeso);
            }
        }

        private void btnConvertEuro_Click(object sender, EventArgs e)
        {
            double auxEuro;
            if (this.btnCandado.ImageIndex == 0 && double.TryParse(this.txtEuro.Text, out auxEuro) && auxEuro >= 0)
            {
                Euro euro = auxEuro;
                this.txtEuroAEuro.Text = euro.GetCantidad().ToString();
                this.txtEuroADolar.Text = ((Dolar)euro).GetCantidad().ToString();
                this.txtEuroAPeso.Text = ((Pesos)euro).GetCantidad().ToString();
            }
        }

        private void btnConvertDolar_Click(object sender, EventArgs e)
        {
            double auxDolar;
            if (this.btnCandado.ImageIndex == 0 && double.TryParse(this.txtDolar.Text, out auxDolar) && auxDolar >= 0)
            {
                Dolar dolar = auxDolar;
                this.txtDolarADolar.Text = dolar.GetCantidad().ToString();
                this.txtDolarAEuro.Text = ((Euro)dolar).GetCantidad().ToString();
                this.txtDolarAPeso.Text = ((Pesos)dolar).GetCantidad().ToString();
            }
        }

        private void btnConvertPeso_Click(object sender, EventArgs e)
        {
            double auxPeso;
            if (this.btnCandado.ImageIndex == 0 && double.TryParse(this.txtPeso.Text, out auxPeso) && auxPeso >= 0)
            {
                Pesos peso = auxPeso;
                this.txtPesoAPeso.Text = peso.GetCantidad().ToString();
                this.txtPesoAEuro.Text = ((Euro)peso).GetCantidad().ToString();
                this.txtPesoADolar.Text = ((Dolar)peso).GetCantidad().ToString();
            }
        }
    }
}