using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.Sqlite;

namespace MinecraftMobs_Aplicacion
{
    public partial class frmAgregar : Form
    {
        frmMain formularioMain; //Atributo para una instancia de frmMain
        public frmAgregar(frmMain formulario)
        {
            InitializeComponent();
            formularioMain = formulario; //Asignamos la instancia que entra desde frmMain a nuestro atributo
            //pictureBox1.Image = Image.FromFile("C:\\Users\\sanch\\Downloads\\cerdo.jpg");
        }

        private void rdbPasivo_Click(object sender, EventArgs e) //Funcion para cuando el radio de pasivo este activo
        {
            grbHostil.Visible = false; //Se oculta los datos de los hostiles
            grbPasivo.Visible = true;  //Se hace visible los datos de los pasivos
        }

        private void rdbNeutral_Click(object sender, EventArgs e) //Funcion para cuando el radio de neutral esta activo
        {
            grbHostil.Visible = true;   //Se hace visible los datos de los hostiles
            grbPasivo.Visible = false;  //Se oculta los datos de los pasivos
        }

        private void rdbHostil_Click(object sender, EventArgs e) //Funcion para cuando el radio de hostiles esta activo
        {
            grbHostil.Visible = true;  //Se hace visible los datos de los hostiles
            grbPasivo.Visible = false; //Se oculta los datos de los pasivos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string tipo;

            if (rdbPasivo.Checked)
            {
                MobsPasivos nuevoMob = new MobsPasivos();
                nuevoMob.Nombre = txtNombre.Text;
                nuevoMob.PuntosDeSalud = (int)nudVida.Value;
                nuevoMob.Spawn = txtSpawn.Text;
                nuevoMob.ItemSoltado = txtDrop.Text;
                nuevoMob.Apariencia = lblRutaImgPasivo.Text; //Asignamos la imagen del pasivo

                nuevoMob.AgregarPasivoBaseDeDatos();
                formularioMain.listaMobs.Add(nuevoMob); //Agrega el nuevo mob a la lista de mobs en frmMain
            }
            else
            {
                if (rdbHostil.Checked) { tipo = "Hostil"; } else { tipo = "Neutral"; }
                MobsActivos nuevoMob = new MobsActivos((int)nudDaño.Value, cmbAtaque.Text, tipo);
                nuevoMob.Nombre = txtNombreHostil.Text;
                nuevoMob.PuntosDeSalud = (int)nudVidaHostil.Value;
                nuevoMob.Spawn = txtSpawnHostil.Text;
                nuevoMob.ItemSoltado = txtDropHostil.Text;
                nuevoMob.Apariencia = lblRutaImgHostil.Text; //Asignamos la imagen del hostil

                nuevoMob.AgregarActivoBaseDeDatos();
                formularioMain.listaMobs.Add(nuevoMob); //Agrega el nuevo mob a la lista de mobs en frmMain

            }
            this.Hide();
            formularioMain.Show(); //Abre el frmMain
        }
        
        //Agregar imagen en mob pasivo
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
                lblRutaImgPasivo.Text = camino; //Asigna la ruta de la imagen seleccionada
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
                lblRutaImgHostil.Text = camino; //Asigna la ruta de la imagen seleccionada
            }

        }


        //SUGERENCIA DE COPILOT
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
        //SUGERENCIA DE COPILOT

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarControles(this);
            this.Hide();
            formularioMain.Show();
        }

        private void frmAgregar_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true; //Evita que el formulario se cierre
        }

        private void frmAgregar_Activated(object sender, EventArgs e)
        {
            LimpiarControles(this); //Limpia los controles al activar el formulario
        }

    }
}
