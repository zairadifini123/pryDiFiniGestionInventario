namespace pryDiFiniGestionInventario
{
    partial class AgregarModificarProducto
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBox2 = new TextBox();
            lblStock = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            textBox1 = new TextBox();
            lblDescripcion = new Label();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            txtNombre = new TextBox();
            lblNombre = new Label();
            btnGuardar = new Button();
            btnCancelar = new Button();
            lblAgregarModificar = new Label();
            lblCategorias = new Label();
            cmbCategorias = new ComboBox();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(672, 161);
            textBox2.Margin = new Padding(3, 4, 3, 4);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 32;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(565, 165);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(109, 20);
            lblStock.TabIndex = 31;
            lblStock.Text = "Stock Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(426, 161);
            txtPrecio.Margin = new Padding(3, 4, 3, 4);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(114, 27);
            txtPrecio.TabIndex = 30;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(314, 165);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(114, 20);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(454, 105);
            textBox1.Margin = new Padding(3, 4, 3, 4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 28;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(297, 111);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(151, 20);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripcion Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(176, 161);
            txtCodigo.Margin = new Padding(3, 4, 3, 4);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(114, 27);
            txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(52, 165);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(122, 20);
            lblCodigo.TabIndex = 25;
            lblCodigo.Text = "Codigo Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(167, 105);
            txtNombre.Margin = new Padding(3, 4, 3, 4);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(114, 27);
            txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 111);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(128, 20);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre Producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(236, 228);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(143, 32);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(431, 228);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(143, 32);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.BackColor = SystemColors.ButtonFace;
            lblAgregarModificar.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarModificar.Location = new Point(52, 24);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(478, 46);
            lblAgregarModificar.TabIndex = 35;
            lblAgregarModificar.Text = "Agregar/Modificar producto";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(594, 111);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(80, 20);
            lblCategorias.TabIndex = 36;
            lblCategorias.Text = "Categorias";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(678, 108);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(110, 28);
            cmbCategorias.TabIndex = 37;
            // 
            // AgregarProducto
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 323);
            Controls.Add(cmbCategorias);
            Controls.Add(lblCategorias);
            Controls.Add(lblAgregarModificar);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(textBox2);
            Controls.Add(lblStock);
            Controls.Add(txtPrecio);
            Controls.Add(lblPrecio);
            Controls.Add(textBox1);
            Controls.Add(lblDescripcion);
            Controls.Add(txtCodigo);
            Controls.Add(lblCodigo);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Name = "AgregarProducto";
            Text = "AgregarModificarProducto";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBox2;
        private Label lblStock;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox textBox1;
        private Label lblDescripcion;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox txtNombre;
        private Label lblNombre;
        private Button btnGuardar;
        private Button btnCancelar;
        private Label lblAgregarModificar;
        private Label lblCategorias;
        private ComboBox cmbCategorias;
    }
}