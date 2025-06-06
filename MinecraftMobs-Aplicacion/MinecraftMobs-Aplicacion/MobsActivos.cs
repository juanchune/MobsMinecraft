using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

public enum Categoria
{ //declaramos las posibles categorias
    Neutral,
    Hostil
}

namespace MinecraftMobs_Aplicacion
{
    internal class MobsActivos : MobsPasivos
    {
        protected int daño;
        protected string tipoDeAtaque;
        protected string tipoActivo;
        public MobsActivos(int dan, string ataq, string tipo)
        {
            daño = dan; //baja los valores de los atributos
            tipoDeAtaque = ataq;
            tipoActivo = tipo;
        }
        public int Danio { get { return daño; } set { daño = value; } } //obtiene todos los valores
        public string TipoDeAtaque { get { return tipoDeAtaque; } set { tipoDeAtaque = value; } }    //de los atributos propios y los asigna
        public string Tipo { get { return tipoActivo; } set { tipoActivo = value; } }

        public void AgregarActivoBaseDeDatos()
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand($"INSERT INTO Mobs (Nombre, PuntosDeSalud, Tipo, Spawn, ItemSoltado, Daño, TipoDeAtaque, Apariencia) " +
            $"VALUES ('{nombre}', '{puntosDeSalud}', '{tipoActivo}', '{spawn}', '{itemSoltado}', '{daño}', '{tipoDeAtaque}', '{apariencia}')", conexion); //consulta

            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarActivoBaseDeDatos()
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand($"UPDATE Mobs SET Nombre = '{nombre}', PuntosDeSalud = '{puntosDeSalud}'," +
                $"Spawn = '{spawn}', ItemSoltado = '{itemSoltado}', Daño = {daño}, TipoDeAtaque = '{tipoDeAtaque}', Apariencia = '{apariencia}' WHERE idMob = {id}", conexion); //consulta
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
