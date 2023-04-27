namespace Ejercicio_I02
{
    partial class frmRegistro
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            grpDetalles = new GroupBox();
            numEdad = new NumericUpDown();
            txtDireccion = new TextBox();
            txtNombre = new TextBox();
            lblEdad = new Label();
            lblDireccion = new Label();
            lblNombre = new Label();
            grpGenero = new GroupBox();
            rdbNoBinario = new RadioButton();
            rdbFemenino = new RadioButton();
            rdbMasculino = new RadioButton();
            grpCursos = new GroupBox();
            chkbCurso3 = new CheckBox();
            chkbCurso2 = new CheckBox();
            chkbCurso1 = new CheckBox();
            lstPais = new ListBox();
            lblPais = new Label();
            btnIngresar = new Button();
            grpDetalles.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).BeginInit();
            grpGenero.SuspendLayout();
            grpCursos.SuspendLayout();
            SuspendLayout();
            // 
            // grpDetalles
            // 
            grpDetalles.Controls.Add(numEdad);
            grpDetalles.Controls.Add(txtDireccion);
            grpDetalles.Controls.Add(txtNombre);
            grpDetalles.Controls.Add(lblEdad);
            grpDetalles.Controls.Add(lblDireccion);
            grpDetalles.Controls.Add(lblNombre);
            grpDetalles.Location = new Point(51, 26);
            grpDetalles.Name = "grpDetalles";
            grpDetalles.Size = new Size(268, 162);
            grpDetalles.TabIndex = 0;
            grpDetalles.TabStop = false;
            grpDetalles.Text = "Detalles del usuario";
            // 
            // numEdad
            // 
            numEdad.Location = new Point(112, 110);
            numEdad.Name = "numEdad";
            numEdad.Size = new Size(120, 23);
            numEdad.TabIndex = 5;
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(112, 72);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(120, 23);
            txtDireccion.TabIndex = 4;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(112, 33);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(120, 23);
            txtNombre.TabIndex = 3;
            // 
            // lblEdad
            // 
            lblEdad.AutoSize = true;
            lblEdad.Location = new Point(19, 112);
            lblEdad.Name = "lblEdad";
            lblEdad.Size = new Size(33, 15);
            lblEdad.TabIndex = 2;
            lblEdad.Text = "Edad";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(19, 75);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(57, 15);
            lblDireccion.TabIndex = 1;
            lblDireccion.Text = "Direccion";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(19, 36);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(51, 15);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // grpGenero
            // 
            grpGenero.Controls.Add(rdbNoBinario);
            grpGenero.Controls.Add(rdbFemenino);
            grpGenero.Controls.Add(rdbMasculino);
            grpGenero.Location = new Point(414, 26);
            grpGenero.Name = "grpGenero";
            grpGenero.Size = new Size(144, 127);
            grpGenero.TabIndex = 1;
            grpGenero.TabStop = false;
            grpGenero.Text = "Genero";
            // 
            // rdbNoBinario
            // 
            rdbNoBinario.AutoSize = true;
            rdbNoBinario.Location = new Point(29, 83);
            rdbNoBinario.Name = "rdbNoBinario";
            rdbNoBinario.Size = new Size(81, 19);
            rdbNoBinario.TabIndex = 2;
            rdbNoBinario.Text = "No Binario";
            rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbFemenino
            // 
            rdbFemenino.AutoSize = true;
            rdbFemenino.Location = new Point(29, 58);
            rdbFemenino.Name = "rdbFemenino";
            rdbFemenino.Size = new Size(78, 19);
            rdbFemenino.TabIndex = 1;
            rdbFemenino.Text = "Femenino";
            rdbFemenino.UseVisualStyleBackColor = true;
            // 
            // rdbMasculino
            // 
            rdbMasculino.AutoSize = true;
            rdbMasculino.Location = new Point(29, 33);
            rdbMasculino.Name = "rdbMasculino";
            rdbMasculino.Size = new Size(80, 19);
            rdbMasculino.TabIndex = 0;
            rdbMasculino.Text = "Masculino";
            rdbMasculino.UseVisualStyleBackColor = true;
            // 
            // grpCursos
            // 
            grpCursos.Controls.Add(chkbCurso3);
            grpCursos.Controls.Add(chkbCurso2);
            grpCursos.Controls.Add(chkbCurso1);
            grpCursos.Location = new Point(414, 159);
            grpCursos.Name = "grpCursos";
            grpCursos.Size = new Size(144, 124);
            grpCursos.TabIndex = 2;
            grpCursos.TabStop = false;
            grpCursos.Text = "Cursos";
            // 
            // chkbCurso3
            // 
            chkbCurso3.AutoSize = true;
            chkbCurso3.Location = new Point(29, 87);
            chkbCurso3.Name = "chkbCurso3";
            chkbCurso3.Size = new Size(78, 19);
            chkbCurso3.TabIndex = 2;
            chkbCurso3.Text = "JavaScript";
            chkbCurso3.UseVisualStyleBackColor = true;
            // 
            // chkbCurso2
            // 
            chkbCurso2.AutoSize = true;
            chkbCurso2.Location = new Point(29, 62);
            chkbCurso2.Name = "chkbCurso2";
            chkbCurso2.Size = new Size(50, 19);
            chkbCurso2.TabIndex = 1;
            chkbCurso2.Text = "C++";
            chkbCurso2.UseVisualStyleBackColor = true;
            // 
            // chkbCurso1
            // 
            chkbCurso1.AutoSize = true;
            chkbCurso1.Location = new Point(29, 37);
            chkbCurso1.Name = "chkbCurso1";
            chkbCurso1.Size = new Size(41, 19);
            chkbCurso1.TabIndex = 0;
            chkbCurso1.Text = "C#";
            chkbCurso1.UseVisualStyleBackColor = true;
            // 
            // lstPais
            // 
            lstPais.FormattingEnabled = true;
            lstPais.ItemHeight = 15;
            lstPais.Items.AddRange(new object[] { "Argentina", "Chile", "Uruguay" });
            lstPais.Location = new Point(51, 221);
            lstPais.Name = "lstPais";
            lstPais.Size = new Size(266, 109);
            lstPais.TabIndex = 3;
            // 
            // lblPais
            // 
            lblPais.AutoSize = true;
            lblPais.Location = new Point(51, 197);
            lblPais.Name = "lblPais";
            lblPais.Size = new Size(28, 15);
            lblPais.TabIndex = 4;
            lblPais.Text = "Pais";
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(432, 302);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(126, 28);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnIngresar);
            Controls.Add(lblPais);
            Controls.Add(lstPais);
            Controls.Add(grpCursos);
            Controls.Add(grpGenero);
            Controls.Add(grpDetalles);
            Name = "frmRegistro";
            Text = "Registro";
            grpDetalles.ResumeLayout(false);
            grpDetalles.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numEdad).EndInit();
            grpGenero.ResumeLayout(false);
            grpGenero.PerformLayout();
            grpCursos.ResumeLayout(false);
            grpCursos.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grpDetalles;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblEdad;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private NumericUpDown numEdad;
        private GroupBox grpGenero;
        private RadioButton rdbNoBinario;
        private RadioButton rdbFemenino;
        private RadioButton rdbMasculino;
        private GroupBox grpCursos;
        private CheckBox chkbCurso3;
        private CheckBox chkbCurso2;
        private CheckBox chkbCurso1;
        private ListBox lstPais;
        private Label lblPais;
        private Button btnIngresar;
    }
}