namespace pryDiFiniGestionInventario
{
    partial class Reportes
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
            lblReporte = new Label();
            btnCerrar = new Button();
            dgvStock = new DataGridView();
            Nombre = new DataGridViewTextBoxColumn();
            Stock = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dgvStock).BeginInit();
            SuspendLayout();
            // 
            // lblReporte
            // 
            lblReporte.AutoSize = true;
            lblReporte.BackColor = SystemColors.ButtonFace;
            lblReporte.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblReporte.Location = new Point(70, 9);
            lblReporte.Name = "lblReporte";
            lblReporte.Size = new Size(649, 81);
            lblReporte.TabIndex = 14;
            lblReporte.Text = "Reporte de inventario";
            // 
            // btnCerrar
            // 
            btnCerrar.Location = new Point(327, 239);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(94, 29);
            btnCerrar.TabIndex = 16;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // dgvStock
            // 
            dgvStock.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvStock.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvStock.Columns.AddRange(new DataGridViewColumn[] { Nombre, Stock });
            dgvStock.Location = new Point(90, 131);
            dgvStock.Name = "dgvStock";
            dgvStock.RowHeadersWidth = 51;
            dgvStock.Size = new Size(621, 58);
            dgvStock.TabIndex = 19;
            // 
            // Nombre
            // 
            Nombre.HeaderText = "Nombre";
            Nombre.MinimumWidth = 6;
            Nombre.Name = "Nombre";
            // 
            // Stock
            // 
            Stock.HeaderText = "Stock";
            Stock.MinimumWidth = 6;
            Stock.Name = "Stock";
            // 
            // Reportes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 321);
            Controls.Add(dgvStock);
            Controls.Add(btnCerrar);
            Controls.Add(lblReporte);
            Name = "Reportes";
            Text = "Reportes";
            Load += Reportes_Load;
            ((System.ComponentModel.ISupportInitialize)dgvStock).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblReporte;
        private Button btnCerrar;
        private DataGridView dgvStock;
        private DataGridViewTextBoxColumn Nombre;
        private DataGridViewTextBoxColumn Stock;
    }
}