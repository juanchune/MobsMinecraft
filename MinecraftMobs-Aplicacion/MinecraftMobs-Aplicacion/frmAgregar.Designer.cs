namespace MinecraftMobs_Aplicacion
{
    partial class frmAgregar
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
            lblTitulo = new Label();
            btnAgregar = new Button();
            grbTipo = new GroupBox();
            rdbHostil = new RadioButton();
            rdbNeutral = new RadioButton();
            rdbPasivo = new RadioButton();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            grbPasivo = new GroupBox();
            lblRutaImgPasivo = new Label();
            imagenPasivo = new PictureBox();
            agImgPasivo = new Button();
            label1 = new Label();
            txtUrlPasivo = new TextBox();
            nudVida = new NumericUpDown();
            txtSpawn = new TextBox();
            txtDrop = new TextBox();
            txtNombre = new TextBox();
            lblSpawn = new Label();
            lblDrop = new Label();
            lblVida = new Label();
            lblNombre = new Label();
            grbHostil = new GroupBox();
            lblRutaImgHostil = new Label();
            agImgHostil = new Button();
            txtUrlHostil = new TextBox();
            cmbAtaque = new ComboBox();
            nudDaño = new NumericUpDown();
            lblAtaque = new Label();
            lblDaño = new Label();
            imagenHostil = new PictureBox();
            label2 = new Label();
            nudVidaHostil = new NumericUpDown();
            txtDropHostil = new TextBox();
            txtSpawnHostil = new TextBox();
            txtNombreHostil = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnCancelar = new Button();
            grbTipo.SuspendLayout();
            grbPasivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPasivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).BeginInit();
            grbHostil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDaño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenHostil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVidaHostil).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Minecrafter", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(155, 20);
            lblTitulo.Margin = new Padding(2, 0, 2, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(440, 38);
            lblTitulo.TabIndex = 1;
            lblTitulo.Text = "Agregar un mob";
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(376, 804);
            btnAgregar.Margin = new Padding(2);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(92, 29);
            btnAgregar.TabIndex = 2;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // grbTipo
            // 
            grbTipo.Controls.Add(rdbHostil);
            grbTipo.Controls.Add(rdbNeutral);
            grbTipo.Controls.Add(rdbPasivo);
            grbTipo.Location = new Point(155, 71);
            grbTipo.Margin = new Padding(2);
            grbTipo.Name = "grbTipo";
            grbTipo.Padding = new Padding(2);
            grbTipo.Size = new Size(434, 51);
            grbTipo.TabIndex = 3;
            grbTipo.TabStop = false;
            // 
            // rdbHostil
            // 
            rdbHostil.AutoSize = true;
            rdbHostil.Location = new Point(329, 24);
            rdbHostil.Margin = new Padding(2);
            rdbHostil.Name = "rdbHostil";
            rdbHostil.Size = new Size(69, 24);
            rdbHostil.TabIndex = 6;
            rdbHostil.Text = "Hostil";
            rdbHostil.UseVisualStyleBackColor = true;
            rdbHostil.Click += rdbHostil_Click;
            // 
            // rdbNeutral
            // 
            rdbNeutral.AutoSize = true;
            rdbNeutral.Location = new Point(172, 23);
            rdbNeutral.Margin = new Padding(2);
            rdbNeutral.Name = "rdbNeutral";
            rdbNeutral.Size = new Size(79, 24);
            rdbNeutral.TabIndex = 5;
            rdbNeutral.Text = "Neutral";
            rdbNeutral.UseVisualStyleBackColor = true;
            rdbNeutral.Click += rdbNeutral_Click;
            // 
            // rdbPasivo
            // 
            rdbPasivo.AutoSize = true;
            rdbPasivo.Checked = true;
            rdbPasivo.Location = new Point(12, 23);
            rdbPasivo.Margin = new Padding(2);
            rdbPasivo.Name = "rdbPasivo";
            rdbPasivo.Size = new Size(71, 24);
            rdbPasivo.TabIndex = 4;
            rdbPasivo.TabStop = true;
            rdbPasivo.Text = "Pasivo";
            rdbPasivo.UseVisualStyleBackColor = true;
            rdbPasivo.Click += rdbPasivo_Click;
            // 
            // grbPasivo
            // 
            grbPasivo.Controls.Add(lblRutaImgPasivo);
            grbPasivo.Controls.Add(imagenPasivo);
            grbPasivo.Controls.Add(agImgPasivo);
            grbPasivo.Controls.Add(label1);
            grbPasivo.Controls.Add(txtUrlPasivo);
            grbPasivo.Controls.Add(nudVida);
            grbPasivo.Controls.Add(txtSpawn);
            grbPasivo.Controls.Add(txtDrop);
            grbPasivo.Controls.Add(txtNombre);
            grbPasivo.Controls.Add(lblSpawn);
            grbPasivo.Controls.Add(lblDrop);
            grbPasivo.Controls.Add(lblVida);
            grbPasivo.Controls.Add(lblNombre);
            grbPasivo.Location = new Point(14, 141);
            grbPasivo.Margin = new Padding(2);
            grbPasivo.Name = "grbPasivo";
            grbPasivo.Padding = new Padding(2);
            grbPasivo.Size = new Size(339, 518);
            grbPasivo.TabIndex = 4;
            grbPasivo.TabStop = false;
            // 
            // lblRutaImgPasivo
            // 
            lblRutaImgPasivo.AutoSize = true;
            lblRutaImgPasivo.Location = new Point(85, 373);
            lblRutaImgPasivo.Name = "lblRutaImgPasivo";
            lblRutaImgPasivo.Size = new Size(50, 20);
            lblRutaImgPasivo.TabIndex = 13;
            lblRutaImgPasivo.Text = "label7";
            lblRutaImgPasivo.Visible = false;
            // 
            // imagenPasivo
            // 
            imagenPasivo.Location = new Point(9, 304);
            imagenPasivo.Margin = new Padding(2);
            imagenPasivo.Name = "imagenPasivo";
            imagenPasivo.Size = new Size(177, 159);
            imagenPasivo.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenPasivo.TabIndex = 9;
            imagenPasivo.TabStop = false;
            // 
            // agImgPasivo
            // 
            agImgPasivo.Location = new Point(288, 473);
            agImgPasivo.Margin = new Padding(2);
            agImgPasivo.Name = "agImgPasivo";
            agImgPasivo.Size = new Size(31, 29);
            agImgPasivo.TabIndex = 12;
            agImgPasivo.Text = "...";
            agImgPasivo.UseVisualStyleBackColor = true;
            agImgPasivo.Click += agImgPasivo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 265);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(59, 20);
            label1.TabIndex = 8;
            label1.Text = "Imagen";
            // 
            // txtUrlPasivo
            // 
            txtUrlPasivo.Location = new Point(10, 473);
            txtUrlPasivo.Margin = new Padding(2);
            txtUrlPasivo.Name = "txtUrlPasivo";
            txtUrlPasivo.Size = new Size(310, 27);
            txtUrlPasivo.TabIndex = 11;
            // 
            // nudVida
            // 
            nudVida.Location = new Point(10, 105);
            nudVida.Margin = new Padding(2);
            nudVida.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVida.Name = "nudVida";
            nudVida.Size = new Size(318, 27);
            nudVida.TabIndex = 7;
            nudVida.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtSpawn
            // 
            txtSpawn.Location = new Point(9, 168);
            txtSpawn.Margin = new Padding(2);
            txtSpawn.Name = "txtSpawn";
            txtSpawn.Size = new Size(319, 27);
            txtSpawn.TabIndex = 6;
            // 
            // txtDrop
            // 
            txtDrop.Location = new Point(10, 222);
            txtDrop.Margin = new Padding(2);
            txtDrop.Name = "txtDrop";
            txtDrop.Size = new Size(319, 27);
            txtDrop.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(10, 44);
            txtNombre.Margin = new Padding(2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(319, 27);
            txtNombre.TabIndex = 4;
            // 
            // lblSpawn
            // 
            lblSpawn.AutoSize = true;
            lblSpawn.Location = new Point(10, 139);
            lblSpawn.Margin = new Padding(2, 0, 2, 0);
            lblSpawn.Name = "lblSpawn";
            lblSpawn.Size = new Size(53, 20);
            lblSpawn.TabIndex = 3;
            lblSpawn.Text = "Spawn";
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Location = new Point(10, 200);
            lblDrop.Margin = new Padding(2, 0, 2, 0);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(43, 20);
            lblDrop.TabIndex = 2;
            lblDrop.Text = "Drop";
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Location = new Point(10, 83);
            lblVida.Margin = new Padding(2, 0, 2, 0);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(39, 20);
            lblVida.TabIndex = 1;
            lblVida.Text = "Vida";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(10, 22);
            lblNombre.Margin = new Padding(2, 0, 2, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // grbHostil
            // 
            grbHostil.Controls.Add(lblRutaImgHostil);
            grbHostil.Controls.Add(agImgHostil);
            grbHostil.Controls.Add(txtUrlHostil);
            grbHostil.Controls.Add(cmbAtaque);
            grbHostil.Controls.Add(nudDaño);
            grbHostil.Controls.Add(lblAtaque);
            grbHostil.Controls.Add(lblDaño);
            grbHostil.Controls.Add(imagenHostil);
            grbHostil.Controls.Add(label2);
            grbHostil.Controls.Add(nudVidaHostil);
            grbHostil.Controls.Add(txtDropHostil);
            grbHostil.Controls.Add(txtSpawnHostil);
            grbHostil.Controls.Add(txtNombreHostil);
            grbHostil.Controls.Add(label3);
            grbHostil.Controls.Add(label4);
            grbHostil.Controls.Add(label5);
            grbHostil.Controls.Add(label6);
            grbHostil.Location = new Point(376, 141);
            grbHostil.Margin = new Padding(2);
            grbHostil.Name = "grbHostil";
            grbHostil.Padding = new Padding(2);
            grbHostil.Size = new Size(339, 637);
            grbHostil.TabIndex = 10;
            grbHostil.TabStop = false;
            grbHostil.Visible = false;
            // 
            // lblRutaImgHostil
            // 
            lblRutaImgHostil.AutoSize = true;
            lblRutaImgHostil.Location = new Point(70, 457);
            lblRutaImgHostil.Name = "lblRutaImgHostil";
            lblRutaImgHostil.Size = new Size(50, 20);
            lblRutaImgHostil.TabIndex = 14;
            lblRutaImgHostil.Text = "label7";
            lblRutaImgHostil.Visible = false;
            // 
            // agImgHostil
            // 
            agImgHostil.Location = new Point(288, 600);
            agImgHostil.Margin = new Padding(2);
            agImgHostil.Name = "agImgHostil";
            agImgHostil.Size = new Size(31, 29);
            agImgHostil.TabIndex = 17;
            agImgHostil.Text = "...";
            agImgHostil.UseVisualStyleBackColor = true;
            agImgHostil.Click += agImgHostil_Click;
            // 
            // txtUrlHostil
            // 
            txtUrlHostil.Location = new Point(10, 600);
            txtUrlHostil.Margin = new Padding(2);
            txtUrlHostil.Name = "txtUrlHostil";
            txtUrlHostil.Size = new Size(310, 27);
            txtUrlHostil.TabIndex = 16;
            // 
            // cmbAtaque
            // 
            cmbAtaque.FormattingEnabled = true;
            cmbAtaque.Items.AddRange(new object[] { "Cuerpo a cuerpo", "A distancia", "CaC y a distancia", "Explosion", "Otro" });
            cmbAtaque.Location = new Point(10, 357);
            cmbAtaque.Margin = new Padding(2);
            cmbAtaque.Name = "cmbAtaque";
            cmbAtaque.Size = new Size(317, 28);
            cmbAtaque.TabIndex = 15;
            // 
            // nudDaño
            // 
            nudDaño.Location = new Point(9, 287);
            nudDaño.Margin = new Padding(2);
            nudDaño.Name = "nudDaño";
            nudDaño.Size = new Size(318, 27);
            nudDaño.TabIndex = 14;
            // 
            // lblAtaque
            // 
            lblAtaque.AutoSize = true;
            lblAtaque.Location = new Point(10, 335);
            lblAtaque.Margin = new Padding(2, 0, 2, 0);
            lblAtaque.Name = "lblAtaque";
            lblAtaque.Size = new Size(110, 20);
            lblAtaque.TabIndex = 12;
            lblAtaque.Text = "Tipo de ataque";
            // 
            // lblDaño
            // 
            lblDaño.AutoSize = true;
            lblDaño.Location = new Point(10, 265);
            lblDaño.Margin = new Padding(2, 0, 2, 0);
            lblDaño.Name = "lblDaño";
            lblDaño.Size = new Size(45, 20);
            lblDaño.TabIndex = 11;
            lblDaño.Text = "Daño";
            // 
            // imagenHostil
            // 
            imagenHostil.Location = new Point(9, 418);
            imagenHostil.Margin = new Padding(2);
            imagenHostil.Name = "imagenHostil";
            imagenHostil.Size = new Size(177, 159);
            imagenHostil.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenHostil.TabIndex = 9;
            imagenHostil.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 396);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(59, 20);
            label2.TabIndex = 8;
            label2.Text = "Imagen";
            // 
            // nudVidaHostil
            // 
            nudVidaHostil.Location = new Point(10, 105);
            nudVidaHostil.Margin = new Padding(2);
            nudVidaHostil.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVidaHostil.Name = "nudVidaHostil";
            nudVidaHostil.Size = new Size(318, 27);
            nudVidaHostil.TabIndex = 7;
            nudVidaHostil.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtDropHostil
            // 
            txtDropHostil.Location = new Point(10, 222);
            txtDropHostil.Margin = new Padding(2);
            txtDropHostil.Name = "txtDropHostil";
            txtDropHostil.Size = new Size(319, 27);
            txtDropHostil.TabIndex = 6;
            // 
            // txtSpawnHostil
            // 
            txtSpawnHostil.Location = new Point(9, 168);
            txtSpawnHostil.Margin = new Padding(2);
            txtSpawnHostil.Name = "txtSpawnHostil";
            txtSpawnHostil.Size = new Size(319, 27);
            txtSpawnHostil.TabIndex = 5;
            // 
            // txtNombreHostil
            // 
            txtNombreHostil.Location = new Point(10, 44);
            txtNombreHostil.Margin = new Padding(2);
            txtNombreHostil.Name = "txtNombreHostil";
            txtNombreHostil.Size = new Size(319, 27);
            txtNombreHostil.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(9, 139);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 3;
            label3.Text = "Spawn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 200);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(43, 20);
            label4.TabIndex = 2;
            label4.Text = "Drop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(10, 83);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(39, 20);
            label5.TabIndex = 1;
            label5.Text = "Vida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 22);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(64, 20);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(261, 804);
            btnCancelar.Margin = new Padding(2);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(92, 29);
            btnCancelar.TabIndex = 13;
            btnCancelar.Text = "Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // frmAgregar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(818, 659);
            Controls.Add(btnCancelar);
            Controls.Add(grbHostil);
            Controls.Add(grbPasivo);
            Controls.Add(grbTipo);
            Controls.Add(btnAgregar);
            Controls.Add(lblTitulo);
            Margin = new Padding(2);
            Name = "frmAgregar";
            Text = "Agregar";
            Activated += frmAgregar_Activated;
            FormClosing += frmAgregar_FormClosing;
            grbTipo.ResumeLayout(false);
            grbTipo.PerformLayout();
            grbPasivo.ResumeLayout(false);
            grbPasivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPasivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).EndInit();
            grbHostil.ResumeLayout(false);
            grbHostil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDaño).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenHostil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVidaHostil).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Button btnAgregar;
        private GroupBox grbTipo;
        private RadioButton rdbHostil;
        private RadioButton rdbNeutral;
        private RadioButton rdbPasivo;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private GroupBox grbPasivo;
        private GroupBox grbHostil;
        private PictureBox imagenHostil;
        private Label label2;
        private NumericUpDown nudVidaHostil;
        private TextBox txtDropHostil;
        private TextBox txtSpawnHostil;
        private TextBox txtNombreHostil;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private PictureBox imagenPasivo;
        private Label label1;
        private NumericUpDown nudVida;
        private TextBox txtSpawn;
        private TextBox txtDrop;
        private TextBox txtNombre;
        private Label lblSpawn;
        private Label lblDrop;
        private Label lblVida;
        private Label lblNombre;
        private TextBox txtUrlPasivo;
        private Button agImgPasivo;
        private NumericUpDown nudDaño;
        private Label lblAtaque;
        private Label lblDaño;
        private ComboBox cmbAtaque;
        private Button btnCancelar;
        private Button agImgHostil;
        private TextBox txtUrlHostil;
        private Label lblRutaImgPasivo;
        private Label lblRutaImgHostil;
    }
}