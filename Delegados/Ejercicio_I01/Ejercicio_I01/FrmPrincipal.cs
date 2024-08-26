namespace Ejercicio_I01
{
    public partial class FrmPrincipal : Form
    {
        private FrmMostrar frmMostrar;
        private FrmTestDelegados frmTestDelegados;
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            this.frmMostrar = new FrmMostrar();
            frmMostrar.MdiParent = this;
            this.frmTestDelegados = new FrmTestDelegados(this.frmMostrar.ActualizarNombre);
            frmTestDelegados.MdiParent = this;
        }

        private void testDelegadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.frmTestDelegados.Show();
            this.mostrarToolStripMenuItem.Enabled = true;
        }

        private void mostrarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            this.frmMostrar.Show();
        }
    }
}