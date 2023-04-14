namespace Ejercicio_23
{
    public partial class frmMonedas : Form
    {
        public frmMonedas()
        {
            InitializeComponent();
        }

        private void btnCandado_Click(object sender, EventArgs e)
        {
            if (this.btnCandado.ImageIndex == 0)
            {
                this.btnCandado.ImageIndex = 1;
                this.txtCotizacionEuro.Enabled = true;
                this.txtCotizacionDolar.Enabled = true;
                this.txtCotizacionPeso.Enabled = true;
            }
            else
            {
                this.btnCandado.ImageIndex = 0;
                this.txtCotizacionEuro.Enabled = false;
                this.txtCotizacionDolar.Enabled = false;
                this.txtCotizacionPeso.Enabled = false;
            }
        }
    }
}