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
                    mob = new MobsActivos(int.Parse((lector["Daño"].ToString())), lector["TipoDeAtaque"].ToString(), lector["Tipo"].ToString());
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
            if (listaMobs.Count <= 0)
            {
                return; //si la lista esta vacia, no hace nada
            }
            cmbMob.Items.Clear();
            foreach (MobsPasivos mob in listaMobs)
            {
                cmbMob.Items.Add(mob.Nombre); //Agrega los nombres de los mobs a la lista desplegable
            }
            if (cmbMob.Items.Count > 0)
            {
                cmbMob.SelectedIndex = 0;
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

        }

    }
}
