namespace pryDiFiniGestionInventario
{
    partial class FrmInicio
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
            txtBuscar = new TextBox();
            lblBuscar = new Label();
            lblCategorias = new Label();
            dgvProductos = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Codigo = new DataGridViewTextBoxColumn();
            Descripcion = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            Categoria = new DataGridViewTextBoxColumn();
            btnAgregar = new Button();
            btnModificar = new Button();
            btnEliminar = new Button();
            btnReporte = new Button();
            btnSalir = new Button();
            lblInicio = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvProductos).BeginInit();
            SuspendLayout();
            // 
            // txtBuscar
            // 
            txtBuscar.Location = new Point(213, 152);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.Size = new Size(228, 27);
            txtBuscar.TabIndex = 14;
            // 
            // lblBuscar
            // 
            lblBuscar.AutoSize = true;
            lblBuscar.Location = new Point(90, 152);
            lblBuscar.Name = "lblBuscar";
            lblBuscar.Size = new Size(117, 20);
            lblBuscar.TabIndex = 15;
            lblBuscar.Text = "Buscar producto";
            // 
            // lblCategorias
            // 
            lblCategorias.AutoSize = true;
            lblCategorias.Location = new Point(447, 155);
            lblCategorias.Name = "lblCategorias";
            lblCategorias.Size = new Size(146, 20);
            lblCategorias.TabIndex = 17;
            lblCategorias.Text = "Buscar por categoria";
            // 
            // dgvProductos
            // 
            dgvProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvProductos.Columns.AddRange(new DataGridViewColumn[] { Nombre, Codigo, Descripcion, Precio, Stock, Categoria });
            dgvProductos.Location = new Point(26, 201);
            dgvProductos.Name = "dgvProductos";
            dgvProductos.RowHeadersWidth = 51;
            dgvProductos.Size = new Size(621, 64);
            dgvProductos.TabIndex = 18;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Codigo
            // 
            Codigo.HeaderText = "Codigo";
            Codigo.MinimumWidth = 6;
            Codigo.Name = "Codigo";
            // 
            // Descripcion
            // 
            Descripcion.HeaderText = "Descripcion";
            Descripcion.MinimumWidth = 6;
            Descripcion.Name = "Descripcion";
            // 
            // Precio
            // 
            Precio.HeaderText = "Precio";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Categoria
            // 
            Categoria.HeaderText = "Categoria";
            Categoria.MinimumWidth = 6;
            Categoria.Name = "Categoria";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(656, 201);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click_1;
            // 
            // btnModificar
            // 
            btnModificar.Location = new Point(656, 236);
            btnModificar.Name = "btnModificar";
            btnModificar.Size = new Size(94, 29);
            btnModificar.TabIndex = 20;
            btnModificar.Text = "Modificar";
            btnModificar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.Location = new Point(656, 271);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(94, 29);
            btnEliminar.TabIndex = 21;
            btnEliminar.Text = "Eliminar";
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnReporte
            // 
            btnReporte.BackColor = Color.Cyan;
            btnReporte.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReporte.Location = new Point(213, 280);
            btnReporte.Name = "btnReporte";
            btnReporte.Size = new Size(192, 44);
            btnReporte.TabIndex = 22;
            btnReporte.Text = "Hacer Reporte";
            btnReporte.UseVisualStyleBackColor = false;
            // 
            // btnSalir
            // 
            btnSalir.Location = new Point(430, 292);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 23;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = true;
            // 
            // lblInicio
            // 
            lblInicio.AutoSize = true;
            lblInicio.BackColor = SystemColors.ButtonFace;
            lblInicio.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInicio.Location = new Point(131, 34);
            lblInicio.Name = "lblInicio";
            lblInicio.Size = new Size(462, 81);
            lblInicio.TabIndex = 24;
            lblInicio.Text = "Elige que hacer";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(773, 386);
            Controls.Add(lblInicio);
            Controls.Add(btnSalir);
            Controls.Add(btnReporte);
            Controls.Add(btnEliminar);
            Controls.Add(btnModificar);
            Controls.Add(btnAgregar);
            Controls.Add(dgvProductos);
            Controls.Add(lblCategorias);
            Controls.Add(lblBuscar);
            Controls.Add(txtBuscar);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FrmInicio";
            Text = "Inicio";
            ((System.ComponentModel.ISupportInitialize)dgvProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblTexto;
        private TextBox txtProducto;
        private Button btnBuscar;
        private Button btnReportes;
        private Button btnStock;
        private Label lbEditar;
        private Label lblBuscar;
        private TextBox txtBuscar;
        private Label lblCategorias;
        private DataGridView dgvProductos;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Codigo;
        private DataGridViewTextBoxColumn Descripcion;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Stock;
        private DataGridViewTextBoxColumn Categoria;
        private Button btnAgregar;
        private Button btnModificar;
        private Button btnEliminar;
        private Button btnReporte;
        private Button btnSalir;
        private Label lblInicio;
    }
}
