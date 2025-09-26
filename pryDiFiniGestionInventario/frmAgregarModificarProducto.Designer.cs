namespace pryDiFiniGestionInventario
{
    partial class frmAgregarModificarProducto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgregarModificarProducto));
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
            textBox2.Location = new Point(588, 121);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 32;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(494, 124);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(88, 15);
            lblStock.TabIndex = 31;
            lblStock.Text = "Stock Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(373, 121);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 30;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(275, 124);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(92, 15);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(397, 79);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 28;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(260, 83);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 15);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripción Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(154, 121);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(46, 124);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 25;
            lblCodigo.Text = "Código Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(146, 79);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(37, 83);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 15);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre Producto";
            // 
            // btnGuardar
            // 
            btnGuardar.Location = new Point(206, 171);
            btnGuardar.Margin = new Padding(3, 2, 3, 2);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(125, 24);
            btnGuardar.TabIndex = 33;
            btnGuardar.Text = "Guardar";
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(377, 171);
            btnCancelar.Margin = new Padding(3, 2, 3, 2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(125, 24);
            btnCancelar.TabIndex = 34;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // lblAgregarModificar
            // 
            lblAgregarModificar.AutoSize = true;
            lblAgregarModificar.BackColor = SystemColors.ButtonFace;
            lblAgregarModificar.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAgregarModificar.Location = new Point(46, 18);
            lblAgregarModificar.Name = "lblAgregarModificar";
            lblAgregarModificar.Size = new Size(385, 37);
            lblAgregarModificar.TabIndex = 35;
            lblAgregarModificar.Text = "Agregar/Modificar producto";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(520, 83);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(63, 15);
            lblCategorias.TabIndex = 36;
            lblCategorias.Text = "Categorías";
            // 
            // cmbCategorias
            // 
            cmbCategorias.FormattingEnabled = true;
            cmbCategorias.Location = new Point(593, 81);
            cmbCategorias.Margin = new Padding(3, 2, 3, 2);
            cmbCategorias.Name = "cmbCategorias";
            cmbCategorias.Size = new Size(97, 23);
            cmbCategorias.TabIndex = 37;
            // 
            // frmAgregarModificarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 242);
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
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmAgregarModificarProducto";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Agregar/Modificar Producto";
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