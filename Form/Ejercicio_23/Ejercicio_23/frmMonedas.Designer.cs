namespace Ejercicio_23
{
    partial class frmMonedas
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMonedas));
            btnCandado = new Button();
            imlCandados = new ImageList(components);
            lblCotizacion = new Label();
            lblPeso = new Label();
            lblDolar = new Label();
            lblEuro = new Label();
            txtEuro = new TextBox();
            txtDolar = new TextBox();
            txtPeso = new TextBox();
            txtPesoAEuro = new TextBox();
            txtDolarAEuro = new TextBox();
            txtEuroAEuro = new TextBox();
            txtPesoADolar = new TextBox();
            txtDolarADolar = new TextBox();
            txtEuroADolar = new TextBox();
            txtPesoAPeso = new TextBox();
            txtDolarAPeso = new TextBox();
            txtEuroAPeso = new TextBox();
            txtCotizacionPeso = new TextBox();
            txtCotizacionDolar = new TextBox();
            txtCotizacionEuro = new TextBox();
            btnConvertEuro = new Button();
            btnConvertDolar = new Button();
            btnConvertPeso = new Button();
            lblEuroA = new Label();
            lblDolarA = new Label();
            lblPesoA = new Label();
            SuspendLayout();
            // 
            // btnCandado
            // 
            btnCandado.ImageIndex = 0;
            btnCandado.ImageList = imlCandados;
            btnCandado.Location = new Point(282, 44);
            btnCandado.Name = "btnCandado";
            btnCandado.Size = new Size(64, 64);
            btnCandado.TabIndex = 0;
            btnCandado.UseVisualStyleBackColor = true;
            btnCandado.Click += btnCandado_Click;
            // 
            // imlCandados
            // 
            imlCandados.ColorDepth = ColorDepth.Depth32Bit;
            imlCandados.ImageStream = (ImageListStreamer)resources.GetObject("imlCandados.ImageStream");
            imlCandados.TransparentColor = Color.Transparent;
            imlCandados.Images.SetKeyName(0, "internet_lock_locked_padlock_password_secure_security_icon_127078.png");
            imlCandados.Images.SetKeyName(1, "internet_locked_padlock_password_secure_security_unlock_icon_127083.png");
            // 
            // lblCotizacion
            // 
            lblCotizacion.AutoSize = true;
            lblCotizacion.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblCotizacion.Location = new Point(122, 51);
            lblCotizacion.Name = "lblCotizacion";
            lblCotizacion.Size = new Size(142, 37);
            lblCotizacion.TabIndex = 1;
            lblCotizacion.Text = "Cotizacion";
            // 
            // lblPeso
            // 
            lblPeso.AutoSize = true;
            lblPeso.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPeso.Location = new Point(12, 228);
            lblPeso.Name = "lblPeso";
            lblPeso.Size = new Size(72, 37);
            lblPeso.TabIndex = 2;
            lblPeso.Text = "Peso";
            // 
            // lblDolar
            // 
            lblDolar.AutoSize = true;
            lblDolar.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDolar.Location = new Point(12, 171);
            lblDolar.Name = "lblDolar";
            lblDolar.Size = new Size(82, 37);
            lblDolar.TabIndex = 3;
            lblDolar.Text = "Dolar";
            // 
            // lblEuro
            // 
            lblEuro.AutoSize = true;
            lblEuro.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEuro.Location = new Point(12, 116);
            lblEuro.Name = "lblEuro";
            lblEuro.Size = new Size(71, 37);
            lblEuro.TabIndex = 4;
            lblEuro.Text = "Euro";
            // 
            // txtEuro
            // 
            txtEuro.Location = new Point(140, 130);
            txtEuro.Name = "txtEuro";
            txtEuro.Size = new Size(130, 23);
            txtEuro.TabIndex = 5;
            // 
            // txtDolar
            // 
            txtDolar.Location = new Point(140, 185);
            txtDolar.Name = "txtDolar";
            txtDolar.Size = new Size(130, 23);
            txtDolar.TabIndex = 6;
            // 
            // txtPeso
            // 
            txtPeso.Location = new Point(140, 242);
            txtPeso.Name = "txtPeso";
            txtPeso.Size = new Size(130, 23);
            txtPeso.TabIndex = 7;
            // 
            // txtPesoAEuro
            // 
            txtPesoAEuro.Enabled = false;
            txtPesoAEuro.Location = new Point(357, 242);
            txtPesoAEuro.Name = "txtPesoAEuro";
            txtPesoAEuro.Size = new Size(130, 23);
            txtPesoAEuro.TabIndex = 10;
            // 
            // txtDolarAEuro
            // 
            txtDolarAEuro.Enabled = false;
            txtDolarAEuro.Location = new Point(357, 185);
            txtDolarAEuro.Name = "txtDolarAEuro";
            txtDolarAEuro.Size = new Size(130, 23);
            txtDolarAEuro.TabIndex = 9;
            // 
            // txtEuroAEuro
            // 
            txtEuroAEuro.Enabled = false;
            txtEuroAEuro.Location = new Point(357, 130);
            txtEuroAEuro.Name = "txtEuroAEuro";
            txtEuroAEuro.Size = new Size(130, 23);
            txtEuroAEuro.TabIndex = 8;
            // 
            // txtPesoADolar
            // 
            txtPesoADolar.Enabled = false;
            txtPesoADolar.Location = new Point(507, 242);
            txtPesoADolar.Name = "txtPesoADolar";
            txtPesoADolar.Size = new Size(130, 23);
            txtPesoADolar.TabIndex = 13;
            // 
            // txtDolarADolar
            // 
            txtDolarADolar.Enabled = false;
            txtDolarADolar.Location = new Point(507, 185);
            txtDolarADolar.Name = "txtDolarADolar";
            txtDolarADolar.Size = new Size(130, 23);
            txtDolarADolar.TabIndex = 12;
            // 
            // txtEuroADolar
            // 
            txtEuroADolar.Enabled = false;
            txtEuroADolar.Location = new Point(507, 130);
            txtEuroADolar.Name = "txtEuroADolar";
            txtEuroADolar.Size = new Size(130, 23);
            txtEuroADolar.TabIndex = 11;
            // 
            // txtPesoAPeso
            // 
            txtPesoAPeso.Enabled = false;
            txtPesoAPeso.Location = new Point(658, 242);
            txtPesoAPeso.Name = "txtPesoAPeso";
            txtPesoAPeso.Size = new Size(130, 23);
            txtPesoAPeso.TabIndex = 16;
            // 
            // txtDolarAPeso
            // 
            txtDolarAPeso.Enabled = false;
            txtDolarAPeso.Location = new Point(658, 185);
            txtDolarAPeso.Name = "txtDolarAPeso";
            txtDolarAPeso.Size = new Size(130, 23);
            txtDolarAPeso.TabIndex = 15;
            // 
            // txtEuroAPeso
            // 
            txtEuroAPeso.Enabled = false;
            txtEuroAPeso.Location = new Point(658, 130);
            txtEuroAPeso.Name = "txtEuroAPeso";
            txtEuroAPeso.Size = new Size(130, 23);
            txtEuroAPeso.TabIndex = 14;
            // 
            // txtCotizacionPeso
            // 
            txtCotizacionPeso.Enabled = false;
            txtCotizacionPeso.Location = new Point(658, 65);
            txtCotizacionPeso.Name = "txtCotizacionPeso";
            txtCotizacionPeso.Size = new Size(130, 23);
            txtCotizacionPeso.TabIndex = 19;
            txtCotizacionPeso.Leave += txtCotizacionPeso_Leave;
            // 
            // txtCotizacionDolar
            // 
            txtCotizacionDolar.Enabled = false;
            txtCotizacionDolar.Location = new Point(507, 65);
            txtCotizacionDolar.Name = "txtCotizacionDolar";
            txtCotizacionDolar.Size = new Size(130, 23);
            txtCotizacionDolar.TabIndex = 18;
            txtCotizacionDolar.Leave += txtCotizacionDolar_Leave;
            // 
            // txtCotizacionEuro
            // 
            txtCotizacionEuro.Enabled = false;
            txtCotizacionEuro.Location = new Point(357, 65);
            txtCotizacionEuro.Name = "txtCotizacionEuro";
            txtCotizacionEuro.Size = new Size(130, 23);
            txtCotizacionEuro.TabIndex = 17;
            txtCotizacionEuro.Leave += txtCotizacionEuro_Leave;
            // 
            // btnConvertEuro
            // 
            btnConvertEuro.Location = new Point(276, 130);
            btnConvertEuro.Name = "btnConvertEuro";
            btnConvertEuro.Size = new Size(75, 23);
            btnConvertEuro.TabIndex = 20;
            btnConvertEuro.Text = "->";
            btnConvertEuro.UseVisualStyleBackColor = true;
            btnConvertEuro.Click += btnConvertEuro_Click;
            // 
            // btnConvertDolar
            // 
            btnConvertDolar.Location = new Point(276, 185);
            btnConvertDolar.Name = "btnConvertDolar";
            btnConvertDolar.Size = new Size(75, 23);
            btnConvertDolar.TabIndex = 21;
            btnConvertDolar.Text = "->";
            btnConvertDolar.UseVisualStyleBackColor = true;
            btnConvertDolar.Click += btnConvertDolar_Click;
            // 
            // btnConvertPeso
            // 
            btnConvertPeso.Location = new Point(276, 242);
            btnConvertPeso.Name = "btnConvertPeso";
            btnConvertPeso.Size = new Size(75, 23);
            btnConvertPeso.TabIndex = 22;
            btnConvertPeso.Text = "->";
            btnConvertPeso.UseVisualStyleBackColor = true;
            btnConvertPeso.Click += btnConvertPeso_Click;
            // 
            // lblEuroA
            // 
            lblEuroA.AutoSize = true;
            lblEuroA.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblEuroA.Location = new Point(384, 90);
            lblEuroA.Name = "lblEuroA";
            lblEuroA.Size = new Size(71, 37);
            lblEuroA.TabIndex = 23;
            lblEuroA.Text = "Euro";
            // 
            // lblDolarA
            // 
            lblDolarA.AutoSize = true;
            lblDolarA.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblDolarA.Location = new Point(532, 91);
            lblDolarA.Name = "lblDolarA";
            lblDolarA.Size = new Size(82, 37);
            lblDolarA.TabIndex = 24;
            lblDolarA.Text = "Dolar";
            // 
            // lblPesoA
            // 
            lblPesoA.AutoSize = true;
            lblPesoA.Font = new Font("Segoe UI", 20.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblPesoA.Location = new Point(684, 91);
            lblPesoA.Name = "lblPesoA";
            lblPesoA.Size = new Size(72, 37);
            lblPesoA.TabIndex = 25;
            lblPesoA.Text = "Peso";
            // 
            // frmMonedas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPesoA);
            Controls.Add(lblDolarA);
            Controls.Add(lblEuroA);
            Controls.Add(btnConvertPeso);
            Controls.Add(btnConvertDolar);
            Controls.Add(btnConvertEuro);
            Controls.Add(txtCotizacionPeso);
            Controls.Add(txtCotizacionDolar);
            Controls.Add(txtCotizacionEuro);
            Controls.Add(txtPesoAPeso);
            Controls.Add(txtDolarAPeso);
            Controls.Add(txtEuroAPeso);
            Controls.Add(txtPesoADolar);
            Controls.Add(txtDolarADolar);
            Controls.Add(txtEuroADolar);
            Controls.Add(txtPesoAEuro);
            Controls.Add(txtDolarAEuro);
            Controls.Add(txtEuroAEuro);
            Controls.Add(txtPeso);
            Controls.Add(txtDolar);
            Controls.Add(txtEuro);
            Controls.Add(lblEuro);
            Controls.Add(lblDolar);
            Controls.Add(lblPeso);
            Controls.Add(lblCotizacion);
            Controls.Add(btnCandado);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmMonedas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Conversor";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCandado;
        private ImageList imlCandados;
        private Label lblCotizacion;
        private Label lblPeso;
        private Label lblDolar;
        private Label lblEuro;
        private TextBox txtEuro;
        private TextBox txtDolar;
        private TextBox txtPeso;
        private TextBox txtPesoAEuro;
        private TextBox txtDolarAEuro;
        private TextBox txtEuroAEuro;
        private TextBox txtPesoADolar;
        private TextBox txtDolarADolar;
        private TextBox txtEuroADolar;
        private TextBox txtPesoAPeso;
        private TextBox txtDolarAPeso;
        private TextBox txtEuroAPeso;
        private TextBox txtCotizacionPeso;
        private TextBox txtCotizacionDolar;
        private TextBox txtCotizacionEuro;
        private Button btnConvertEuro;
        private Button btnConvertDolar;
        private Button btnConvertPeso;
        private Label lblEuroA;
        private Label lblDolarA;
        private Label lblPesoA;
    }
}