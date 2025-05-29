using Microsoft.Data.Sqlite;

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
        }
        private void frmMain_Activated(object sender, EventArgs e)
        {
            ActualizarComboBox(); //Actualiza el combobox al activar el formulario
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
