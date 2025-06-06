using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MinecraftMobs_Aplicacion;

namespace MinecraftMobs_Aplicacion
{
    public partial class FrmModificar : Form
    {
        MobsPasivos mobAEditar;
        frmMain formularioMain;

        public FrmModificar(frmMain formulario)
        {
            formularioMain = formulario;
            InitializeComponent();
        }
        public void MostrarModificar(MobsPasivos mobEditar)
        {
            this.Show();
            mobAEditar = mobEditar;
            if (mobEditar is MobsActivos mobActivo)
            {
                // Mostrar solo el grupo de mobs activos
                grbHostil.Visible = true;
                grbPasivo.Visible = false;

                // Checkbox según tipo
                if (mobActivo.Tipo == "Hostil")
                {
                    rdbHostil.Checked = true;
                    rdbNeutral.Checked = false;
                    rdbPasivo.Checked = false;
                }
                else if (mobActivo.Tipo == "Neutral")
                {
                    rdbNeutral.Checked = true;
                    rdbHostil.Checked = false;
                    rdbPasivo.Checked = false;
                }
                txtNombre.Text = mobEditar.Nombre;
                // Llenar los controles para mobs activos
                txtNombreHostil.Text = mobActivo.Nombre;
                nudVidaHostil.Value = mobActivo.PuntosDeSalud;
                txtSpawnHostil.Text = mobActivo.Spawn;
                txtDropHostil.Text = mobActivo.ItemSoltado;
                nudDaño.Value = mobActivo.Danio;
                cmbAtaque.Text = mobActivo.TipoDeAtaque;

                label7.Text = mobActivo.Id.ToString(); // Mostrar el ID del mob activo

                if (File.Exists(mobActivo.Apariencia))
                    imagenHostil.Image = Image.FromFile(mobActivo.Apariencia);
                else
                    imagenHostil.Image = null;
            }
            else if (mobEditar is MobsPasivos mobPasivo)
            {
                // Mostrar solo el grupo de mobs pasivos
                grbPasivo.Visible = true;
                grbHostil.Visible = false;

                rdbPasivo.Checked = true;
                rdbHostil.Checked = false;
                rdbNeutral.Checked = false;

                // Llenar los controles para mobs pasivos
                txtNombre.Text = mobPasivo.Nombre;
                nudVida.Value = mobPasivo.PuntosDeSalud;
                txtSpawn.Text = mobPasivo.Spawn;
                txtDrop.Text = mobPasivo.ItemSoltado;

                label7.Text = mobPasivo.Id.ToString(); // Mostrar el ID del mob pasivo

                if (File.Exists(mobPasivo.Apariencia))
                    imagenPasivo.Image = Image.FromFile(mobPasivo.Apariencia);
                else
                    imagenPasivo.Image = null;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            string tipo;

            if (rdbPasivo.Checked)
            {
                MobsPasivos nuevoMob = new MobsPasivos();
                nuevoMob.Id = int.Parse(label7.Text); //Convierte en entero 
                nuevoMob.Nombre = txtNombre.Text;
                nuevoMob.PuntosDeSalud = (int)nudVida.Value;
                nuevoMob.Spawn = txtSpawn.Text;
                nuevoMob.ItemSoltado = txtDrop.Text;
                nuevoMob.Apariencia = txtRutaPasivo.Text; //Asignamos la imagen del pasivo

                nuevoMob.ModificarPasivoBaseDeDatos();
                formularioMain.ActualizarListaMobs();
            }
            else
            {
                if (rdbHostil.Checked) { tipo = "Hostil"; } else { tipo = "Neutral"; }
                MobsActivos nuevoMob = new MobsActivos((int)nudDaño.Value, cmbAtaque.Text, tipo);
                nuevoMob.Id = int.Parse(label7.Text); //Convierte en entero 
                nuevoMob.Nombre = txtNombreHostil.Text;
                nuevoMob.PuntosDeSalud = (int)nudVidaHostil.Value;
                nuevoMob.Spawn = txtSpawnHostil.Text;
                nuevoMob.ItemSoltado = txtDropHostil.Text;
                nuevoMob.Apariencia = txtRutaHostil.Text; //Asignamos la imagen del hostil

                nuevoMob.ModificarActivoBaseDeDatos();
                formularioMain.ActualizarListaMobs();

            }
            this.Hide();
            formularioMain.Show(); //Abre el frmMain
        }
        private void agImgPasivo_Click(object sender, EventArgs e)
        {
            OpenFileDialog lectorDeArchivos = new OpenFileDialog();
            lectorDeArchivos.FileName = "Seleccione la imagen";
            lectorDeArchivos.Filter = "Archivo jpg (*.jpg)|*jpg";
            lectorDeArchivos.Title = "Abrir camino a imagen";
            if (lectorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                string camino = lectorDeArchivos.FileName;
                if (camino == "Seleccione la imagen" || camino == "")
                    return;
                imagenPasivo.Image = Image.FromFile(camino);
                txtRutaPasivo.Text = camino; //Asigna la ruta de la imagen seleccionada
            }
        }

        //Agregar imagen en mob neutral y hostil 
        private void agImgHostil_Click(object sender, EventArgs e)
        {
            OpenFileDialog lectorDeArchivos = new OpenFileDialog();
            lectorDeArchivos.FileName = "Seleccione la imagen";
            lectorDeArchivos.Filter = "Archivo jpg (*.jpg)|*jpg";
            lectorDeArchivos.Title = "Abrir camino a imagen";
            if (lectorDeArchivos.ShowDialog() == DialogResult.OK)
            {
                string camino = lectorDeArchivos.FileName;
                if (camino == "Seleccione la imagen" || camino == "")
                    return;
                imagenHostil.Image = Image.FromFile(camino);
                txtRutaHostil.Text = camino; //Asigna la ruta de la imagen seleccionada
            }

        }
        private void LimpiarControles(Control control)
        {
            foreach (Control c in control.Controls)
            {
                if (c is TextBox tb)
                    tb.Text = "";               //vacía todos los textbox
                else if (c is NumericUpDown nud)
                    nud.Value = nud.Minimum;    //reduce el valor ingresado en el nud a su minimo (en este caso, 2)
                else if (c is PictureBox pb)
                    pb.Image = null;            //elimina la imagen del picturebox
                else if (c is ComboBox cb)
                    cb.SelectedIndex = -1;      //desmarca el combobox

                // Llamada recursiva para limpiar controles hijos
                if (c.HasChildren)
                    LimpiarControles(c);
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            this.Hide();
            formularioMain.Show();
        }
        private void FrmModificar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Evita que el formulario se cierre
        }

        //private void FrmModificar_Activated(object sender, EventArgs e)
        //{
        //    LimpiarControles(this); //Limpia los controles al activar el formulario
        //}
    }
}