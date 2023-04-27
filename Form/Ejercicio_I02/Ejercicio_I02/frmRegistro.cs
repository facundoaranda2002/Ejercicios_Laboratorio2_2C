using Entidades;
namespace Ejercicio_I02
{
    public partial class frmRegistro : Form
    {
        public frmRegistro()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string[] auxCursos = new string[3];
            int cont = 0;
            string auxGenero;
            string auxPais;


            foreach (Control control in this.grpCursos.Controls)
            {
                
                if (control is CheckBox && ((CheckBox)control).Checked)
                {
                    auxCursos[cont] = ((CheckBox)control).Text;
                    cont++;
                }
                
                    
            }
            cont = 0;

            if (!this.rdbFemenino.Checked && !this.rdbMasculino.Checked && !this.rdbNoBinario.Checked)
            {
                MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(this.lstPais.SelectedIndex == -1)
            {
                MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int flag = 0;
                foreach (Control control in this.grpDetalles.Controls)
                {
                    if ((control is NumericUpDown && ((NumericUpDown)control).Value > 150) || (control is TextBox && string.IsNullOrEmpty(((TextBox)control).Text)))
                    {
                        MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        flag = 1; 
                        break;
                    }
                }
                if(flag == 0)
                {
                    

                    if (this.rdbFemenino.Checked) auxGenero = this.rdbFemenino.Text;
                    else if (this.rdbMasculino.Checked) auxGenero = this.rdbMasculino.Text;
                    else auxGenero = this.rdbNoBinario.Text;

                    auxPais = (this.lstPais.SelectedItem).ToString();

                    Ingresante ingresante = new Ingresante(this.txtNombre.Text, this.txtDireccion.Text, auxGenero, auxPais, auxCursos, (int)(this.numEdad.Value));

                    MessageBox.Show(ingresante.Mostrar());
                }
            }

            /*
            int cantidad = 0;

            foreach(Control item in this.grpGenero.Controls)
            {
                if(item is RadioButton)
                {
                    
                    if(((RadioButton)item).Checked)
                    {
                        break;
                    }
                    cantidad++;
                }
                if(cantidad == this.grpGenero.Controls.Count)
                {
                    MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            */
            /*
            string[] auxCursos = new string[3];

            foreach (Control control in grpDetalles.Controls)
            {
                if ((control is NumericUpDown && (int.Parse(control.Text) <= 0 || int.Parse(control.Text) > 150)) || (control is TextBox && string.IsNullOrEmpty(control.Text)))
                {
                    MessageBox.Show("Datos invalidos o incompletos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (Control control in grpGenero.Controls)
                    {
                        if (control is RadioButton)
                        {
                            auxGenero = control.Text;
                            break;
                        }
                    }
                }
            }
            



            foreach (Control control in grpCursos.Controls)
            {
                int i = 0;
                if (control is CheckBox)
                {
                    auxCursos[i] = control.Text;
                    i++;
                }
            }

            auxPais = lstPais.Text;

            Ingresante ingresante = new Ingresante(auxNombre, auxDireccion, auxGenero, auxPais, auxCursos, auxEdad);

            MessageBox.Show(ingresante.Mostrar());
            */
        }
    }
}