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

        private void FrmModificar_Activated(object sender, EventArgs e)
        {
            
        }
        public void MostrarModificar(MobsPasivos mobEditar)
        {
            this.Show();
            mobAEditar= mobEditar;
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
            }
        }
    }
}
//        // Llenar los controles para mobs activos
//        txtNombreHostil.Text = mobActivo.Nombre;
//        nudVidaHostil.Value = mobActivo.PuntosDeSalud;
//        txtSpawnHostil.Text = mobActivo.Spawn;
//        txtDropHostil.Text = mobActivo.ItemSoltado;
//        nudDaño.Value = mobActivo.Danio;
//        cmbAtaque.Text = mobActivo.TipoDeAtaque;

//        if (File.Exists(mobActivo.Apariencia))
//            imagenHostil.Image = Image.FromFile(mobActivo.Apariencia);
//        else
//            imagenHostil.Image = null;
//    }
//    else if (MobAEditar is MobsPasivos mobPasivo)
//    {
//        // Mostrar solo el grupo de mobs pasivos
//        grbPasivo.Visible = true;
//        grbHostil.Visible = false;

//        rdbPasivo.Checked = true;
//        rdbHostil.Checked = false;
//        rdbNeutral.Checked = false;

//        // Llenar los controles para mobs pasivos
//        txtNombre.Text = mobPasivo.Nombre;
//        nudVida.Value = mobPasivo.PuntosDeSalud;
//        txtSpawn.Text = mobPasivo.Spawn;
//        txtDrop.Text = mobPasivo.ItemSoltado;

//        if (File.Exists(mobPasivo.Apariencia))
//            imagenPasivo.Image = Image.FromFile(mobPasivo.Apariencia);
//        else
//            imagenPasivo.Image = null;
//    }

//    btnAgregar.Text = "Modificar"; // Cambia texto botón
//}