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
            grbHostil.Visible = true;   //Se hace visible los datos de los hostiles
            grbPasivo.Visible = false; //Se oculta los datos de los pasivos
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            string tipo;
            if (rdbPasivo.Checked)
            {
                comando = new SqliteCommand($"INSERT INTO Mobs (Nombre, PuntosDeSalud, Tipo, Spawn, ItemSoltado, Daño, TipoDeAtaque, Apariencia) " +
                    $"VALUES ('{txtNombre.Text}', '{nudVida.Value}', 'Pasivo', '{txtSpawn.Text}', '{txtDrop.Text}', '', '', '{pictureBox1.Image}')", conexion); //consulta
            }
            else
            {
                if (rdbHostil.Checked) { tipo = "Hostil"; } else { tipo = "Neutral"; }
                comando = new SqliteCommand($"INSERT INTO Mobs (Nombre, PuntosDeSalud, Tipo, Spawn, ItemSoltado, Daño, TipoDeAtaque, Apariencia) " +
                    $"VALUES ('{txtNombreHostil.Text}', '{nudVidaHostil.Value}', '{tipo}', '{txtSpawnHostil.Text}', '{txtDropHostil.Text}', '{nudDaño.Value}', '{cmbAtaque.Text}', '{pictureBox2.Image}')", conexion); //consulta

            }
            comando.ExecuteNonQuery();
            conexion.Close();
            this.Hide();
            formularioMain.Show(); //Abre el frmMain
        }

        private void button1_Click(object sender, EventArgs e)
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
                if (rdbPasivo.Checked) { pictureBox1.Image = Image.FromFile(camino); }
                else { pictureBox2.Image = Image.FromFile(camino); }
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
    }
}
