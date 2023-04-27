namespace Ejercicio_I01
{
    public partial class frmHola : Form
    {
        public frmHola()
        {
            InitializeComponent();
        }

        private void btnSaludar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            string apellido = txtApellido.Text;
            string materia = cmbMaterias.Text;
            if (string.IsNullOrEmpty(nombre) && string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nNombre", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrEmpty(apellido))
            {
                MessageBox.Show("Se deben completar los siguientes campos:\nApellido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string mensaje = $"Soy {nombre} {apellido} y mi materia favorita es {materia}.";
                frmSaludo saludo = new frmSaludo("¡Hola, Windows Forms!", mensaje);
                saludo.ShowDialog();
            }
        }

        private void frmHola_Load(object sender, EventArgs e)
        {
            cmbMaterias.Items.Add("Programacion I");
            cmbMaterias.Items.Add("Programacion II");
            cmbMaterias.Items.Add("Laboratorio I");
            cmbMaterias.Items.Add("Laboratorio II");

            cmbMaterias.SelectedIndex = 2;
        }
    }
}