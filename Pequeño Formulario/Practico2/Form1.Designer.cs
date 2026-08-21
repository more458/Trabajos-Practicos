namespace Practico2
{
    partial class LForm1
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
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            label4 = new Label();
            LApellido = new Label();
            TGuardar = new Button();
            TEliminar = new Button();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TDni = new TextBox();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.Location = new Point(39, 9);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            LNya.Click += label1_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(165, 9);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            LModificar.Click += label2_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.Location = new Point(39, 76);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(39, 139);
            label4.Name = "label4";
            label4.Size = new Size(51, 15);
            label4.TabIndex = 3;
            label4.Text = "Nombre";
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.Location = new Point(39, 207);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            // 
            // TGuardar
            // 
            TGuardar.Location = new Point(28, 302);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(75, 23);
            TGuardar.TabIndex = 5;
            TGuardar.Text = "Guardar";
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Location = new Point(144, 302);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 6;
            TEliminar.Text = "Eliminar";
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(119, 207);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.TextChanged += textBox1_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(119, 136);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 8;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDni
            // 
            TDni.Location = new Point(119, 68);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // LForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 438);
            Controls.Add(TDni);
            Controls.Add(TNombre);
            Controls.Add(TApellido);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(LApellido);
            Controls.Add(label4);
            Controls.Add(LDni);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Name = "LForm1";
            Text = "Pequeño Formulario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label label4;
        private Label LApellido;
        private Button TGuardar;
        private Button TEliminar;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDni;
    }
}
