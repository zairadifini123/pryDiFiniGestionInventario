namespace pryDiFiniGestionInventario
{
    partial class frmEditarProducto
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
            lbEditar = new Label();
            lblNombre = new Label();
            txtNombre = new TextBox();
            txtCodigo = new TextBox();
            lblCodigo = new Label();
            textBox1 = new TextBox();
            lblDescripcion = new Label();
            txtPrecio = new TextBox();
            lblPrecio = new Label();
            textBox2 = new TextBox();
            lblStock = new Label();
            btnAgregar = new Button();
            btnModifcar = new Button();
            btnEliminar = new Button();
            SuspendLayout();
            // 
            // lbEditar
            // 
            lbEditar.AutoSize = true;
            lbEditar.BackColor = SystemColors.ButtonFace;
            lbEditar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditar.Location = new Point(12, 9);
            lbEditar.Name = "lbEditar";
            lbEditar.Size = new Size(383, 65);
            lbEditar.TabIndex = 12;
            lbEditar.Text = "Editar producto";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(25, 87);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 15);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(134, 84);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 14;
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(134, 124);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 16;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(25, 127);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 15;
            lblCodigo.Text = "Codigo Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(382, 84);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 18;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(255, 87);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 15);
            lblDescripcion.TabIndex = 17;
            lblDescripcion.Text = "Descripcion Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(353, 124);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 20;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(255, 127);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(92, 15);
            lblPrecio.TabIndex = 19;
            lblPrecio.Text = "Precio Producto";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(568, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 22;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(474, 127);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(88, 15);
            lblStock.TabIndex = 21;
            lblStock.Text = "Stock Producto";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(192, 178);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 24;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnModifcar
            // 
            btnModifcar.Location = new Point(301, 178);
            btnModifcar.Name = "btnModifcar";
            btnModifcar.Size = new Size(75, 23);
            btnModifcar.TabIndex = 25;
            btnModifcar.Text = "Modificar";
            btnModifcar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(407, 178);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(75, 23);
            btnEliminar.TabIndex = 26;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // frmEditarProducto
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(704, 349);
            Controls.Add(btnEliminar);
            Controls.Add(btnModifcar);
            Controls.Add(btnAgregar);
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
            Controls.Add(lbEditar);
            Name = "frmEditarProducto";
            Text = "EditarProducto";
            Load += EditarProducto_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbEditar;
        private Label lblNombre;
        private TextBox txtNombre;
        private TextBox txtCodigo;
        private Label lblCodigo;
        private TextBox textBox1;
        private Label lblDescripcion;
        private TextBox txtPrecio;
        private Label lblPrecio;
        private TextBox textBox2;
        private Label lblStock;
        private Button btnAgregar;
        private Button btnModifcar;
        private Button btnEliminar;
    }
}