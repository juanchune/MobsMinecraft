namespace MinecraftMobs_Aplicacion
{
    partial class FrmModificar
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
            grbTipo = new GroupBox();
            rdbHostil = new RadioButton();
            rdbNeutral = new RadioButton();
            rdbPasivo = new RadioButton();
            lblTitulo = new Label();
            grbHostil = new GroupBox();
            agImgHostil = new Button();
            txtRutaHostil = new TextBox();
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
            grbPasivo = new GroupBox();
            imagenPasivo = new PictureBox();
            agImgPasivo = new Button();
            label1 = new Label();
            txtRutaPasivo = new TextBox();
            nudVida = new NumericUpDown();
            txtSpawn = new TextBox();
            txtDrop = new TextBox();
            txtNombre = new TextBox();
            lblSpawn = new Label();
            lblDrop = new Label();
            lblVida = new Label();
            lblNombre = new Label();
            grbTipo.SuspendLayout();
            grbHostil.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)nudDaño).BeginInit();
            ((System.ComponentModel.ISupportInitialize)imagenHostil).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVidaHostil).BeginInit();
            grbPasivo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPasivo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).BeginInit();
            SuspendLayout();
            // 
            // grbTipo
            // 
            grbTipo.Controls.Add(rdbHostil);
            grbTipo.Controls.Add(rdbNeutral);
            grbTipo.Controls.Add(rdbPasivo);
            grbTipo.Enabled = false;
            grbTipo.Location = new Point(243, 105);
            grbTipo.Name = "grbTipo";
            grbTipo.Size = new Size(705, 82);
            grbTipo.TabIndex = 5;
            grbTipo.TabStop = false;
            // 
            // rdbHostil
            // 
            rdbHostil.AutoSize = true;
            rdbHostil.Enabled = false;
            rdbHostil.Location = new Point(535, 38);
            rdbHostil.Name = "rdbHostil";
            rdbHostil.Size = new Size(106, 36);
            rdbHostil.TabIndex = 6;
            rdbHostil.Text = "Hostil";
            rdbHostil.UseVisualStyleBackColor = true;
            // 
            // rdbNeutral
            // 
            rdbNeutral.AutoSize = true;
            rdbNeutral.Enabled = false;
            rdbNeutral.Location = new Point(280, 37);
            rdbNeutral.Name = "rdbNeutral";
            rdbNeutral.Size = new Size(124, 36);
            rdbNeutral.TabIndex = 5;
            rdbNeutral.Text = "Neutral";
            rdbNeutral.UseVisualStyleBackColor = true;
            // 
            // rdbPasivo
            // 
            rdbPasivo.AutoSize = true;
            rdbPasivo.Checked = true;
            rdbPasivo.Enabled = false;
            rdbPasivo.Location = new Point(20, 37);
            rdbPasivo.Name = "rdbPasivo";
            rdbPasivo.Size = new Size(111, 36);
            rdbPasivo.TabIndex = 4;
            rdbPasivo.TabStop = true;
            rdbPasivo.Text = "Pasivo";
            rdbPasivo.UseVisualStyleBackColor = true;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Minecrafter", 25.875F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(290, 25);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(611, 60);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "Modificar mob";
            // 
            // grbHostil
            // 
            grbHostil.Controls.Add(agImgHostil);
            grbHostil.Controls.Add(txtRutaHostil);
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
            grbHostil.Location = new Point(628, 241);
            grbHostil.Name = "grbHostil";
            grbHostil.Size = new Size(551, 1019);
            grbHostil.TabIndex = 12;
            grbHostil.TabStop = false;
            grbHostil.Visible = false;
            // 
            // agImgHostil
            // 
            agImgHostil.Location = new Point(468, 960);
            agImgHostil.Name = "agImgHostil";
            agImgHostil.Size = new Size(50, 46);
            agImgHostil.TabIndex = 17;
            agImgHostil.Text = "...";
            agImgHostil.UseVisualStyleBackColor = true;
            // 
            // txtRutaHostil
            // 
            txtRutaHostil.Location = new Point(16, 960);
            txtRutaHostil.Name = "txtRutaHostil";
            txtRutaHostil.Size = new Size(501, 39);
            txtRutaHostil.TabIndex = 16;
            // 
            // cmbAtaque
            // 
            cmbAtaque.FormattingEnabled = true;
            cmbAtaque.Items.AddRange(new object[] { "Cuerpo a cuerpo", "A distancia", "CaC y a distancia", "Explosion", "Otro" });
            cmbAtaque.Location = new Point(16, 571);
            cmbAtaque.Name = "cmbAtaque";
            cmbAtaque.Size = new Size(513, 40);
            cmbAtaque.TabIndex = 15;
            // 
            // nudDaño
            // 
            nudDaño.Location = new Point(15, 459);
            nudDaño.Name = "nudDaño";
            nudDaño.Size = new Size(517, 39);
            nudDaño.TabIndex = 14;
            // 
            // lblAtaque
            // 
            lblAtaque.AutoSize = true;
            lblAtaque.Location = new Point(16, 536);
            lblAtaque.Name = "lblAtaque";
            lblAtaque.Size = new Size(175, 32);
            lblAtaque.TabIndex = 12;
            lblAtaque.Text = "Tipo de ataque";
            // 
            // lblDaño
            // 
            lblDaño.AutoSize = true;
            lblDaño.Location = new Point(16, 424);
            lblDaño.Name = "lblDaño";
            lblDaño.Size = new Size(71, 32);
            lblDaño.TabIndex = 11;
            lblDaño.Text = "Daño";
            // 
            // imagenHostil
            // 
            imagenHostil.Location = new Point(15, 669);
            imagenHostil.Name = "imagenHostil";
            imagenHostil.Size = new Size(288, 254);
            imagenHostil.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenHostil.TabIndex = 9;
            imagenHostil.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(15, 634);
            label2.Name = "label2";
            label2.Size = new Size(94, 32);
            label2.TabIndex = 8;
            label2.Text = "Imagen";
            // 
            // nudVidaHostil
            // 
            nudVidaHostil.Location = new Point(16, 168);
            nudVidaHostil.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVidaHostil.Name = "nudVidaHostil";
            nudVidaHostil.Size = new Size(517, 39);
            nudVidaHostil.TabIndex = 7;
            nudVidaHostil.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtDropHostil
            // 
            txtDropHostil.Location = new Point(16, 355);
            txtDropHostil.Name = "txtDropHostil";
            txtDropHostil.Size = new Size(516, 39);
            txtDropHostil.TabIndex = 6;
            // 
            // txtSpawnHostil
            // 
            txtSpawnHostil.Location = new Point(15, 269);
            txtSpawnHostil.Name = "txtSpawnHostil";
            txtSpawnHostil.Size = new Size(516, 39);
            txtSpawnHostil.TabIndex = 5;
            // 
            // txtNombreHostil
            // 
            txtNombreHostil.Location = new Point(16, 70);
            txtNombreHostil.Name = "txtNombreHostil";
            txtNombreHostil.Size = new Size(516, 39);
            txtNombreHostil.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 222);
            label3.Name = "label3";
            label3.Size = new Size(84, 32);
            label3.TabIndex = 3;
            label3.Text = "Spawn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(16, 320);
            label4.Name = "label4";
            label4.Size = new Size(67, 32);
            label4.TabIndex = 2;
            label4.Text = "Drop";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(16, 133);
            label5.Name = "label5";
            label5.Size = new Size(61, 32);
            label5.TabIndex = 1;
            label5.Text = "Vida";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(16, 35);
            label6.Name = "label6";
            label6.Size = new Size(102, 32);
            label6.TabIndex = 0;
            label6.Text = "Nombre";
            // 
            // grbPasivo
            // 
            grbPasivo.Controls.Add(imagenPasivo);
            grbPasivo.Controls.Add(agImgPasivo);
            grbPasivo.Controls.Add(label1);
            grbPasivo.Controls.Add(txtRutaPasivo);
            grbPasivo.Controls.Add(nudVida);
            grbPasivo.Controls.Add(txtSpawn);
            grbPasivo.Controls.Add(txtDrop);
            grbPasivo.Controls.Add(txtNombre);
            grbPasivo.Controls.Add(lblSpawn);
            grbPasivo.Controls.Add(lblDrop);
            grbPasivo.Controls.Add(lblVida);
            grbPasivo.Controls.Add(lblNombre);
            grbPasivo.Location = new Point(40, 241);
            grbPasivo.Name = "grbPasivo";
            grbPasivo.Size = new Size(551, 829);
            grbPasivo.TabIndex = 11;
            grbPasivo.TabStop = false;
            // 
            // imagenPasivo
            // 
            imagenPasivo.Location = new Point(15, 486);
            imagenPasivo.Name = "imagenPasivo";
            imagenPasivo.Size = new Size(288, 254);
            imagenPasivo.SizeMode = PictureBoxSizeMode.StretchImage;
            imagenPasivo.TabIndex = 9;
            imagenPasivo.TabStop = false;
            // 
            // agImgPasivo
            // 
            agImgPasivo.Location = new Point(468, 757);
            agImgPasivo.Name = "agImgPasivo";
            agImgPasivo.Size = new Size(50, 46);
            agImgPasivo.TabIndex = 12;
            agImgPasivo.Text = "...";
            agImgPasivo.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 424);
            label1.Name = "label1";
            label1.Size = new Size(94, 32);
            label1.TabIndex = 8;
            label1.Text = "Imagen";
            // 
            // txtRutaPasivo
            // 
            txtRutaPasivo.Location = new Point(16, 757);
            txtRutaPasivo.Name = "txtRutaPasivo";
            txtRutaPasivo.Size = new Size(501, 39);
            txtRutaPasivo.TabIndex = 11;
            // 
            // nudVida
            // 
            nudVida.Location = new Point(16, 168);
            nudVida.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            nudVida.Name = "nudVida";
            nudVida.Size = new Size(517, 39);
            nudVida.TabIndex = 7;
            nudVida.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // txtSpawn
            // 
            txtSpawn.Location = new Point(15, 269);
            txtSpawn.Name = "txtSpawn";
            txtSpawn.Size = new Size(516, 39);
            txtSpawn.TabIndex = 6;
            // 
            // txtDrop
            // 
            txtDrop.Location = new Point(16, 355);
            txtDrop.Name = "txtDrop";
            txtDrop.Size = new Size(516, 39);
            txtDrop.TabIndex = 5;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(16, 70);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(516, 39);
            txtNombre.TabIndex = 4;
            // 
            // lblSpawn
            // 
            lblSpawn.AutoSize = true;
            lblSpawn.Location = new Point(16, 222);
            lblSpawn.Name = "lblSpawn";
            lblSpawn.Size = new Size(84, 32);
            lblSpawn.TabIndex = 3;
            lblSpawn.Text = "Spawn";
            // 
            // lblDrop
            // 
            lblDrop.AutoSize = true;
            lblDrop.Location = new Point(16, 320);
            lblDrop.Name = "lblDrop";
            lblDrop.Size = new Size(67, 32);
            lblDrop.TabIndex = 2;
            lblDrop.Text = "Drop";
            // 
            // lblVida
            // 
            lblVida.AutoSize = true;
            lblVida.Location = new Point(16, 133);
            lblVida.Name = "lblVida";
            lblVida.Size = new Size(61, 32);
            lblVida.TabIndex = 1;
            lblVida.Text = "Vida";
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(16, 35);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(102, 32);
            lblNombre.TabIndex = 0;
            lblNombre.Text = "Nombre";
            // 
            // FrmModificar
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1220, 1276);
            Controls.Add(grbHostil);
            Controls.Add(grbPasivo);
            Controls.Add(grbTipo);
            Controls.Add(lblTitulo);
            Name = "FrmModificar";
            Text = "FrmModificar";
            Activated += FrmModificar_Activated;
            grbTipo.ResumeLayout(false);
            grbTipo.PerformLayout();
            grbHostil.ResumeLayout(false);
            grbHostil.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)nudDaño).EndInit();
            ((System.ComponentModel.ISupportInitialize)imagenHostil).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVidaHostil).EndInit();
            grbPasivo.ResumeLayout(false);
            grbPasivo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)imagenPasivo).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudVida).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox grbTipo;
        private RadioButton rdbHostil;
        private RadioButton rdbNeutral;
        private RadioButton rdbPasivo;
        private Label lblTitulo;
        private GroupBox grbHostil;
        private Button agImgHostil;
        private TextBox txtRutaHostil;
        private ComboBox cmbAtaque;
        private NumericUpDown nudDaño;
        private Label lblAtaque;
        private Label lblDaño;
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
        private GroupBox grbPasivo;
        private PictureBox imagenPasivo;
        private Button agImgPasivo;
        private Label label1;
        private TextBox txtRutaPasivo;
        private NumericUpDown nudVida;
        private TextBox txtSpawn;
        private TextBox txtDrop;
        private TextBox txtNombre;
        private Label lblSpawn;
        private Label lblDrop;
        private Label lblVida;
        private Label lblNombre;
    }
}