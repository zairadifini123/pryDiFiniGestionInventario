namespace pryDiFiniGestionInventario
{
    partial class frmModificar
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
            lbEditar = new Label();
            btModificar = new Button();
            SuspendLayout();
            // 
            // textBox2
            // 
            textBox2.Location = new Point(574, 144);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 32;
            // 
            // lblStock
            // 
            lblStock.AutoSize = true;
            lblStock.Location = new Point(480, 147);
            lblStock.Name = "lblStock";
            lblStock.Size = new Size(88, 15);
            lblStock.TabIndex = 31;
            lblStock.Text = "Stock Producto";
            // 
            // txtPrecio
            // 
            txtPrecio.Location = new Point(359, 144);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(100, 23);
            txtPrecio.TabIndex = 30;
            // 
            // lblPrecio
            // 
            lblPrecio.AutoSize = true;
            lblPrecio.Location = new Point(261, 147);
            lblPrecio.Name = "lblPrecio";
            lblPrecio.Size = new Size(92, 15);
            lblPrecio.TabIndex = 29;
            lblPrecio.Text = "Precio Producto";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(388, 104);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 28;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(261, 107);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(121, 15);
            lblDescripcion.TabIndex = 27;
            lblDescripcion.Text = "Descripcion Producto";
            // 
            // txtCodigo
            // 
            txtCodigo.Location = new Point(140, 144);
            txtCodigo.Name = "txtCodigo";
            txtCodigo.Size = new Size(100, 23);
            txtCodigo.TabIndex = 26;
            // 
            // lblCodigo
            // 
            lblCodigo.AutoSize = true;
            lblCodigo.Location = new Point(31, 147);
            lblCodigo.Name = "lblCodigo";
            lblCodigo.Size = new Size(98, 15);
            lblCodigo.TabIndex = 25;
            lblCodigo.Text = "Codigo Producto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(140, 104);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 24;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(31, 107);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(103, 15);
            lblNombre.TabIndex = 23;
            lblNombre.Text = "Nombre Producto";
            // 
            // lbEditar
            // 
            lbEditar.AutoSize = true;
            lbEditar.BackColor = SystemColors.ButtonFace;
            lbEditar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditar.Location = new Point(12, 36);
            lbEditar.Name = "lbEditar";
            lbEditar.Size = new Size(468, 65);
            lbEditar.TabIndex = 33;
            lbEditar.Text = "Modificar producto";
            // 
            // btModificar
            // 
            btModificar.Location = new Point(307, 190);
            btModificar.Name = "btModificar";
            btModificar.Size = new Size(75, 23);
            btModificar.TabIndex = 34;
            btModificar.Text = "Modificar";
            btModificar.UseVisualStyleBackColor = true;
            // 
            // frmModificar
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(689, 256);
            Controls.Add(btModificar);
            Controls.Add(lbEditar);
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
            Name = "frmModificar";
            Text = "Modificar";
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
        private Label lbEditar;
        private Button btModificar;
    }
}