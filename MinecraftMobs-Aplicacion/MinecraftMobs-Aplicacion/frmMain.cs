using Microsoft.Data.Sqlite;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace MinecraftMobs_Aplicacion
{
    public partial class frmMain : Form
    {
        frmAgregar formAgregar; //Atributo para una instancia de frmAgregar
        public List<MobsPasivos> listaMobs = new List<MobsPasivos>();
        public frmMain()
        {
            InitializeComponent();
            formAgregar = new frmAgregar(this); //Crea el formulario si no esta creado. El NEW asigna un especio en memoria
        }
        public void ActualizarListaMobs()
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand("SELECT * FROM Mobs ORDER BY Nombre ASC", conexion); //consulta
            SqliteDataReader lector = comando.ExecuteReader(); //toma el comando anterior y lo convierte en legible para c#

            //MobsActivos mob = new MobsActivos(ERROR); //creamos una variable de tipo MobsActivos para almacenar los datos de cada mob
            while (lector.Read()) //el lector para muchas filas para cuando encuentra NULL, por eso es viable con while
            {
                MobsPasivos mob;
                if (lector["Tipo"].ToString() == "Pasivo")
                {
                    mob = new MobsPasivos();
                }
                else
                {
                    mob = new MobsActivos(int.Parse((lector["Da�o"].ToString())), lector["TipoDeAtaque"].ToString(), lector["Tipo"].ToString());
                }
                mob.Nombre = lector["Nombre"].ToString();
                mob.Apariencia = lector["Apariencia"].ToString();
                mob.PuntosDeSalud = int.Parse((lector["PuntosDeSalud"].ToString()));
                mob.Spawn = lector["Spawn"].ToString();
                mob.ItemSoltado = lector["ItemSoltado"].ToString();
                //mob.Id = (int)(lector["Id"]); //Si se quiere usar el ID, descomentar esta linea
                listaMobs.Add(mob); //Agrega el mob a la lista de mobs
            }
            lector.Close();
            conexion.Close();
        }
        public void ActualizarComboBox()
        {
            //if (listaMobs.Count <= 0)
            //{
            //    return; //si la lista esta vacia, no hace nada
            //}

            cmbMob.Items.Clear();

            foreach (MobsPasivos mob in listaMobs)
            {
                cmbMob.Items.Add(mob.Nombre);
            }

            if (cmbMob.Items.Count > 0)
            {
                cmbMob.SelectedIndex = 0;
            }
            else
            {
                cmbMob.Text = ""; // Limpia si no hay mobs
                lblNombre.Text = "";
                lblDanio.Text = "";
                lblAtaque.Text = "";
                lblTipo.Text = "";
                lblSpawn.Text = "";
                lblVida.Text = "";
                lblDrop.Text = "";
                grbHostil.Visible = true;
                picbImagen.Image = null;
            }
        }
        private void frmMain_Activated(object sender, EventArgs e)
        {
            if (listaMobs.Count <= 0)
            {
                ActualizarListaMobs();
            }
            ActualizarComboBox(); //Actualiza el combobox al activar el formulario
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAgregar.Show(); //Abre el frmAgregar
            this.Hide();    //Oculta este formulario (frmMain)
        }

        private void cmbMob_SelectedIndexChanged(object sender, EventArgs e)
        {
            //if (listaMobs[cmbMob.SelectedIndex] is MobsPasivos)
            //{
            //    MobsPasivos mob = listaMobs[cmbMob.SelectedIndex];
            //    lblNombre.Text = mob.Nombre;
            //}
            //else
            //{
            //    if(listaMobs[cmbMob.SelectedIndex] is MobsActivos)
            //    {
            //        MobsActivos mob = (MobsActivos)listaMobs[cmbMob.SelectedIndex];
            //    }
            //}

            string nomMob = cmbMob.Text;
            MobsPasivos mob = null;
            foreach (MobsPasivos m in listaMobs)
            {
                if (m.Nombre == nomMob)
                {
                    mob = m;
                    break;
                }
            }
            if (mob == null)
            {
                return;
            }
            if (mob is MobsActivos)
            {
                MobsActivos mobActivo = (MobsActivos)mob;
                grbHostil.Visible = true;
                lblDanio.Text = mobActivo.Danio.ToString();
                lblAtaque.Text = mobActivo.TipoDeAtaque.ToString();
                lblTipo.Text = mobActivo.Tipo.ToString();
            }
            else
            {
                grbHostil.Visible = false;
                lblTipo.Text = "Pasivo";
            }
            lblNombre.Text = mob.Nombre;
            lblSpawn.Text = mob.Spawn;
            lblVida.Text = mob.PuntosDeSalud.ToString();
            lblDrop.Text = mob.ItemSoltado.ToString();
            picbImagen.Image = Image.FromFile(mob.Apariencia);

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (cmbMob.Items.Count == 0)
            {
                return;
            }

            DialogResult resultado = MessageBox.Show( //Muestra un cuadro de texto con dos botones
            "�Seguro que quiere eliminar este mob?",
            "Confirmacion",
            MessageBoxButtons.YesNo, //Btones
            MessageBoxIcon.Warning //Icono de advertencia :O
            );

            if (resultado != DialogResult.Yes) //Comprueba si el resultado es distinto a Si
            {
                return;
            }

            string nomMob = cmbMob.Text;

            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);
            conexion.Open();

            SqliteCommand comando = new SqliteCommand("DELETE FROM Mobs WHERE Nombre = '" + nomMob + "'", conexion);
            comando.ExecuteNonQuery();

            listaMobs.RemoveAll(m => m.Nombre == nomMob);
            ActualizarComboBox();

            conexion.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            string nombreSeleccionado = cmbMob.SelectedItem.ToString();
            MobsPasivos mobSeleccionado = listaMobs.Find(m => m.Nombre == nombreSeleccionado);

            // 4. Abrimos el formulario de modificaci�n
            formAgregar.EsModificacion = true;
            formAgregar.MobAEditar = mobSeleccionado;
            formAgregar.Show(); // No uses ShowDialog porque vos lo ocult�s, y ShowDialog lo bloquea
            this.Hide(); // Ocult�s el frmMain

            // 5. Una vez que se cierra, actualizamos el combo y la lista
            ActualizarComboBox();
        }
    }
}
