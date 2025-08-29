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
            btnEditar = new Button();
            btnBuscar = new Button();
            btnReportes = new Button();
            btnStock = new Button();
            lbEditar = new Label();
            SuspendLayout();
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(154, 115);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(109, 23);
            btnEditar.TabIndex = 5;
            btnEditar.Text = "Editar Producto";
            btnEditar.UseVisualStyleBackColor = true;
            btnEditar.Click += btnAgregar_Click;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(269, 115);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(75, 23);
            btnBuscar.TabIndex = 8;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // btnReportes
            // 
            btnReportes.Location = new Point(350, 115);
            btnReportes.Name = "btnReportes";
            btnReportes.Size = new Size(75, 23);
            btnReportes.TabIndex = 9;
            btnReportes.Text = "Reportes";
            btnReportes.UseVisualStyleBackColor = true;
            // 
            // btnStock
            // 
            btnStock.Location = new Point(431, 115);
            btnStock.Name = "btnStock";
            btnStock.Size = new Size(75, 23);
            btnStock.TabIndex = 10;
            btnStock.Text = "Stock";
            btnStock.UseVisualStyleBackColor = true;
            // 
            // lbEditar
            // 
            lbEditar.AutoSize = true;
            lbEditar.BackColor = SystemColors.ButtonFace;
            lbEditar.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbEditar.Location = new Point(47, 31);
            lbEditar.Name = "lbEditar";
            lbEditar.Size = new Size(585, 65);
            lbEditar.TabIndex = 13;
            lbEditar.Text = "Ingrese que quiere hacer";
            // 
            // FrmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(676, 233);
            Controls.Add(lbEditar);
            Controls.Add(btnStock);
            Controls.Add(btnReportes);
            Controls.Add(btnBuscar);
            Controls.Add(btnEditar);
            Name = "FrmInicio";
            Text = "Inicio";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox1;
        private Label lblTexto;
        private TextBox txtProducto;
        private Button btnEditar;
        private Button btnBuscar;
        private Button btnReportes;
        private Button btnStock;
        private Label lbEditar;
        private Label label1;
    }
}
