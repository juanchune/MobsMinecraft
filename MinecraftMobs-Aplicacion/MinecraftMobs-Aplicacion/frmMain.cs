using Microsoft.Data.Sqlite;

namespace MinecraftMobs_Aplicacion
{
    public partial class frmMain : Form
    {
        frmAgregar formAgregar; //Atributo para una instancia de frmAgregar
        public frmMain()
        {
            InitializeComponent();
            formAgregar = new frmAgregar(this); //Crea el formulario si no esta creado. El NEW asigna un especio en memoria
        }

        private void frmMain_Activated(object sender, EventArgs e)
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand("SELECT * FROM Mobs", conexion);
            SqliteDataReader lector = comando.ExecuteReader(); //toma el comando anterior y lo convierte en legible para c#

            while (lector.Read()) //el lector para muchas filas para cuando encuentra NULL, por eso es viable con while
            {
                cmbMob.Items.Add(lector["Nombre"].ToString());
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            formAgregar.Show(); //Abre el frmAgregar
            this.Hide();    //Oculta este formulario (frmMain)
        }

        private void cmbMob_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

    }
}
