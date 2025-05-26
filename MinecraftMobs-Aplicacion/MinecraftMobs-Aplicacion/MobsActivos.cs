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

        public void AgregarActivoBaseDeDatos(string nom, int salud, string tipo, string spawn, string drop, int danio, string ataque, string imagen)
        {
            string nombreMob = nom;
            int puntosDeSaludMob = salud;
            string biomaSpawn = spawn;
            string itemSoltadoMob = drop;
            int dañoMob = danio;
            string tipoAtaque = ataque;
            string aparienciaMob = imagen;
            string tipoMobActivo = tipo;

            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand($"INSERT INTO Mobs (Nombre, PuntosDeSalud, Tipo, Spawn, ItemSoltado, Daño, TipoDeAtaque, Apariencia) " +
            $"VALUES ('{nombreMob}', '{puntosDeSaludMob}', '{tipoMobActivo}', '{biomaSpawn}', '{itemSoltadoMob}', '{dañoMob}', '{tipoAtaque}', '{aparienciaMob}')", conexion); //consulta

            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
