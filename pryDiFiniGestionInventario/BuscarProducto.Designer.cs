namespace pryDiFiniGestionInventario
{
    partial class BuscarProducto
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
            lblBuscar = new Label();
            lblResultado = new Label();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(585, 149);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 33;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(491, 152);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(88, 15);
            lblStock.TabIndex = 32;
            lblStock.Text = "Stock Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(370, 149);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 31;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(272, 152);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(92, 15);
            lblPrecio.TabIndex = 30;
            lblPrecio.Text = "Precio Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(399, 109);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 29;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(272, 112);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 15);
            lblDescripcion.TabIndex = 28;
            lblDescripcion.Text = "Descripcion Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(151, 149);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 27;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(42, 152);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 26;
            lblCodigo.Text = "Codigo Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(151, 109);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 25;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(42, 112);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 15);
            lblNombre.TabIndex = 24;
            lblNombre.Text = "Nombre Producto";
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.BackColor = SystemColors.ButtonFace;
            lblBuscar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBuscar.Location = new Point(29, 34);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(398, 65);
            lblBuscar.TabIndex = 23;
            lblBuscar.Text = "Buscar producto";
            // 
            // lblResultado
            // 
            lblResultado.AutoSize = true;
            lblResultado.Location = new Point(42, 210);
            lblResultado.Name = "lblResultado";
            lblResultado.Size = new Size(69, 15);
            lblResultado.TabIndex = 34;
            lblResultado.Text = "RESULTADO";
            // 
            // BuscarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 328);
            Controls.Add(lblResultado);
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
            Controls.Add(lblBuscar);
            Name = "BuscarProducto";
            Text = "BuscarProducto";
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
        private Label lblBuscar;
        private Label lblResultado;
    }
}