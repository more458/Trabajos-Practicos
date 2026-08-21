namespace TP3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LForm1));
            LNya = new Label();
            LModificar = new Label();
            LDni = new Label();
            LNombre = new Label();
            LApellido = new Label();
            TApellido = new TextBox();
            TNombre = new TextBox();
            TDni = new TextBox();
            panel1 = new Panel();
            TMasterCard = new CheckBox();
            TVisa = new CheckBox();
            TNaranja = new CheckBox();
            LTarjeta = new Label();
            TTelefono = new TextBox();
            LTelefono = new Label();
            LNuevoCliente = new Label();
            TGuardar = new Button();
            TEliminar = new Button();
            pictureBox1 = new PictureBox();
            RBVaron = new RadioButton();
            RBMujer = new RadioButton();
            LSalir = new Label();
            TSalir = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // LNya
            // 
            LNya.AutoSize = true;
            LNya.BackColor = SystemColors.AppWorkspace;
            LNya.Location = new Point(115, 95);
            LNya.Name = "LNya";
            LNya.Size = new Size(110, 15);
            LNya.TabIndex = 0;
            LNya.Text = "Nombre y Apellido:";
            LNya.Click += label1_Click;
            // 
            // LModificar
            // 
            LModificar.AutoSize = true;
            LModificar.BackColor = SystemColors.AppWorkspace;
            LModificar.ForeColor = Color.Red;
            LModificar.Location = new Point(241, 95);
            LModificar.Name = "LModificar";
            LModificar.Size = new Size(58, 15);
            LModificar.TabIndex = 1;
            LModificar.Text = "modificar";
            LModificar.Click += label2_Click;
            // 
            // LDni
            // 
            LDni.AutoSize = true;
            LDni.BackColor = SystemColors.AppWorkspace;
            LDni.Location = new Point(39, 77);
            LDni.Name = "LDni";
            LDni.Size = new Size(27, 15);
            LDni.TabIndex = 2;
            LDni.Text = "DNI";
            LDni.Click += LDni_Click;
            // 
            // LNombre
            // 
            LNombre.AutoSize = true;
            LNombre.BackColor = SystemColors.AppWorkspace;
            LNombre.Location = new Point(39, 119);
            LNombre.Name = "LNombre";
            LNombre.Size = new Size(51, 15);
            LNombre.TabIndex = 3;
            LNombre.Text = "Nombre";
            LNombre.Click += label4_Click;
            // 
            // LApellido
            // 
            LApellido.AutoSize = true;
            LApellido.BackColor = SystemColors.AppWorkspace;
            LApellido.Location = new Point(39, 165);
            LApellido.Name = "LApellido";
            LApellido.Size = new Size(51, 15);
            LApellido.TabIndex = 4;
            LApellido.Text = "Apellido";
            LApellido.Click += LApellido_Click;
            // 
            // TApellido
            // 
            TApellido.Location = new Point(123, 157);
            TApellido.Name = "TApellido";
            TApellido.Size = new Size(100, 23);
            TApellido.TabIndex = 7;
            TApellido.TextChanged += textBox1_TextChanged;
            TApellido.KeyPress += TApellido_KeyPress;
            // 
            // TNombre
            // 
            TNombre.Location = new Point(123, 111);
            TNombre.Name = "TNombre";
            TNombre.Size = new Size(100, 23);
            TNombre.TabIndex = 8;
            TNombre.TextChanged += TNombre_TextChanged;
            TNombre.KeyPress += TNombre_KeyPress;
            // 
            // TDni
            // 
            TDni.Location = new Point(123, 69);
            TDni.Name = "TDni";
            TDni.Size = new Size(100, 23);
            TDni.TabIndex = 9;
            TDni.TextChanged += TDni_TextChanged;
            TDni.KeyPress += TDni_KeyPress;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.AppWorkspace;
            panel1.Controls.Add(TMasterCard);
            panel1.Controls.Add(TVisa);
            panel1.Controls.Add(TNaranja);
            panel1.Controls.Add(LTarjeta);
            panel1.Controls.Add(TTelefono);
            panel1.Controls.Add(LTelefono);
            panel1.Controls.Add(TApellido);
            panel1.Controls.Add(TNombre);
            panel1.Controls.Add(LApellido);
            panel1.Controls.Add(TDni);
            panel1.Controls.Add(LDni);
            panel1.Controls.Add(LNombre);
            panel1.Location = new Point(76, 76);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 346);
            panel1.TabIndex = 10;
            // 
            // TMasterCard
            // 
            TMasterCard.AutoSize = true;
            TMasterCard.Location = new Point(152, 308);
            TMasterCard.Name = "TMasterCard";
            TMasterCard.Size = new Size(87, 19);
            TMasterCard.TabIndex = 19;
            TMasterCard.Text = "MasterCard";
            TMasterCard.UseVisualStyleBackColor = true;
            // 
            // TVisa
            // 
            TVisa.AutoSize = true;
            TVisa.Location = new Point(152, 283);
            TVisa.Name = "TVisa";
            TVisa.Size = new Size(47, 19);
            TVisa.TabIndex = 18;
            TVisa.Text = "Visa";
            TVisa.UseVisualStyleBackColor = true;
            TVisa.CheckedChanged += TVisa_CheckedChanged;
            // 
            // TNaranja
            // 
            TNaranja.AutoSize = true;
            TNaranja.Location = new Point(152, 258);
            TNaranja.Name = "TNaranja";
            TNaranja.Size = new Size(67, 19);
            TNaranja.TabIndex = 17;
            TNaranja.Text = "Naranja";
            TNaranja.UseVisualStyleBackColor = true;
            TNaranja.CheckedChanged += TNaranja_CheckedChanged;
            // 
            // LTarjeta
            // 
            LTarjeta.AutoSize = true;
            LTarjeta.Location = new Point(37, 258);
            LTarjeta.Name = "LTarjeta";
            LTarjeta.Size = new Size(109, 15);
            LTarjeta.TabIndex = 16;
            LTarjeta.Text = "Tarjetas de credito :";
            LTarjeta.Click += LTarjeta_Click;
            // 
            // TTelefono
            // 
            TTelefono.Location = new Point(123, 202);
            TTelefono.Name = "TTelefono";
            TTelefono.Size = new Size(100, 23);
            TTelefono.TabIndex = 11;
            TTelefono.TextChanged += textBox1_TextChanged_1;
            // 
            // LTelefono
            // 
            LTelefono.AutoSize = true;
            LTelefono.BackColor = SystemColors.AppWorkspace;
            LTelefono.Location = new Point(37, 210);
            LTelefono.Name = "LTelefono";
            LTelefono.Size = new Size(53, 15);
            LTelefono.TabIndex = 10;
            LTelefono.Text = "Telefono";
            LTelefono.Click += LTelefono_Click;
            // 
            // LNuevoCliente
            // 
            LNuevoCliente.AutoSize = true;
            LNuevoCliente.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LNuevoCliente.ForeColor = SystemColors.HotTrack;
            LNuevoCliente.Location = new Point(252, 20);
            LNuevoCliente.Name = "LNuevoCliente";
            LNuevoCliente.Size = new Size(152, 30);
            LNuevoCliente.TabIndex = 12;
            LNuevoCliente.Text = "Nuevo Cliente";
            // 
            // TGuardar
            // 
            TGuardar.Image = (Image)resources.GetObject("TGuardar.Image");
            TGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            TGuardar.Location = new Point(90, 448);
            TGuardar.Name = "TGuardar";
            TGuardar.Size = new Size(76, 27);
            TGuardar.TabIndex = 5;
            TGuardar.Text = "Guardar";
            TGuardar.TextAlign = ContentAlignment.MiddleRight;
            TGuardar.UseVisualStyleBackColor = true;
            TGuardar.Click += TGuardar_Click;
            // 
            // TEliminar
            // 
            TEliminar.Image = (Image)resources.GetObject("TEliminar.Image");
            TEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            TEliminar.Location = new Point(266, 452);
            TEliminar.Name = "TEliminar";
            TEliminar.Size = new Size(75, 23);
            TEliminar.TabIndex = 6;
            TEliminar.Text = "Eliminar";
            TEliminar.TextAlign = ContentAlignment.MiddleRight;
            TEliminar.UseVisualStyleBackColor = true;
            TEliminar.Click += TEliminar_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(501, 76);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(159, 134);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // RBVaron
            // 
            RBVaron.AutoSize = true;
            RBVaron.Location = new Point(492, 233);
            RBVaron.Name = "RBVaron";
            RBVaron.Size = new Size(55, 19);
            RBVaron.TabIndex = 21;
            RBVaron.Text = "Varon";
            RBVaron.UseVisualStyleBackColor = true;
            RBVaron.CheckedChanged += RDVaron_CheckedChanged;
            // 
            // RBMujer
            // 
            RBMujer.AutoSize = true;
            RBMujer.Location = new Point(641, 233);
            RBMujer.Name = "RBMujer";
            RBMujer.Size = new Size(56, 19);
            RBMujer.TabIndex = 22;
            RBMujer.Text = "Mujer";
            RBMujer.UseVisualStyleBackColor = true;
            RBMujer.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // LSalir
            // 
            LSalir.AutoSize = true;
            LSalir.Location = new Point(518, 460);
            LSalir.Name = "LSalir";
            LSalir.Size = new Size(0, 15);
            LSalir.TabIndex = 23;
            // 
            // TSalir
            // 
            TSalir.Image = (Image)resources.GetObject("TSalir.Image");
            TSalir.ImageAlign = ContentAlignment.MiddleLeft;
            TSalir.Location = new Point(483, 452);
            TSalir.Name = "TSalir";
            TSalir.Size = new Size(75, 23);
            TSalir.TabIndex = 24;
            TSalir.Text = "Salir";
            TSalir.UseVisualStyleBackColor = true;
            TSalir.Click += TSalir_Click;
            // 
            // LForm1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(794, 594);
            Controls.Add(TSalir);
            Controls.Add(LSalir);
            Controls.Add(RBMujer);
            Controls.Add(RBVaron);
            Controls.Add(pictureBox1);
            Controls.Add(LNuevoCliente);
            Controls.Add(TEliminar);
            Controls.Add(TGuardar);
            Controls.Add(LModificar);
            Controls.Add(LNya);
            Controls.Add(panel1);
            Name = "LForm1";
            Text = "Pequeño Formulario";
            Load += LForm1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LNya;
        private Label LModificar;
        private Label LDni;
        private Label LNombre;
        private Label LApellido;
        private TextBox TApellido;
        private TextBox TNombre;
        private TextBox TDni;
        private Panel panel1;
        private TextBox TTelefono;
        private Label LTelefono;
        private Label LNuevoCliente;
        private CheckBox TMasterCard;
        private CheckBox TVisa;
        private CheckBox TNaranja;
        private Label LTarjeta;
        private Button TGuardar;
        private Button TEliminar;
        private PictureBox pictureBox1;
        private RadioButton RBVaron;
        private RadioButton RBMujer;
        private Label LSalir;
        private Button TSalir;
    }
}
