namespace Practico1
{
    partial class formulario1
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
            BEliminar = new Button();
            BGuardar = new Button();
            LNombre = new Label();
            LApellido = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtResultado = new TextBox();
            BSalir = new Button();
            SuspendLayout();
            // 
            // BEliminar
            // 
            BEliminar.Location = new Point(136, 164);
            BEliminar.Name = "BEliminar";
            BEliminar.Size = new Size(75, 23);
            BEliminar.TabIndex = 0;
            BEliminar.Text = "Eliminar";
            BEliminar.UseVisualStyleBackColor = true;
            BEliminar.Click += BEliminar_Click;
            // 
            // BGuardar
            // 
            BGuardar.Location = new Point(41, 164);
            BGuardar.Name = "BGuardar";
            BGuardar.Size = new Size(75, 23);
            BGuardar.TabIndex = 1;
            BGuardar.Text = "Guardar";
            BGuardar.UseVisualStyleBackColor = true;
            BGuardar.Click += BGuardar_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.Location = new Point(41, 119);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 2;
            LNombre.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(41, 58);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 3;
            LApellido.Text = "Apellido";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(111, 111);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(111, 50);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(100, 23);
            txtApellido.TabIndex = 5;
            // 
            // txtResultado
            // 
            txtResultado.Location = new Point(269, 50);
            txtResultado.Multiline = true;
            txtResultado.Name = "txtResultado";
            txtResultado.Size = new Size(185, 137);
            txtResultado.TabIndex = 6;
            // 
            // BSalir
            // 
            BSalir.Location = new Point(406, 235);
            BSalir.Name = "BSalir";
            BSalir.Size = new Size(75, 23);
            BSalir.TabIndex = 7;
            BSalir.Text = "&Salir";
            BSalir.UseVisualStyleBackColor = true;
            BSalir.Click += BSalir_Click;
            // 
            // formulario1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 261);
            Controls.Add(BSalir);
            Controls.Add(txtResultado);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(LApellido);
            Controls.Add(LNombre);
            Controls.Add(BGuardar);
            Controls.Add(BEliminar);
            Name = "formulario1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Mi primer Forms";
            Load += formulario1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button BEliminar;
        private Button BGuardar;
        private Label LNombre;
        private Label LApellido;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtResultado;
        private Button BSalir;
    }
}
