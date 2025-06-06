﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;
using System.Windows.Forms;

namespace MinecraftMobs_Aplicacion
{
    public class MobsPasivos
    {
        protected int id;
        protected string nombre;
        protected int puntosDeSalud;
        protected string spawn;  //creamos los atributos
        protected string itemSoltado;
        protected string apariencia;

        public string Nombre //creamos un procedimiento
        {
            get
            {
                return nombre; //se obtiene el valor y luego se asigna
            }
            set
            {
                nombre = value;
            }
        }
        public int Id { get { return id; } set { id = value; } }
        public int PuntosDeSalud { get { return puntosDeSalud; } set { puntosDeSalud = value; } }  //lo mismo en todos los demas atributos
        public string Spawn { get { return spawn; } set { spawn = value; } }
        public string ItemSoltado { get { return itemSoltado; } set { itemSoltado = value; } }
        public string Apariencia { get { return apariencia; } set { apariencia = value; } }

        public void AgregarPasivoBaseDeDatos()
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand($"INSERT INTO Mobs (Nombre, PuntosDeSalud, Tipo, Spawn, ItemSoltado, Apariencia) " +
            $"VALUES ('{nombre}', '{puntosDeSalud}', 'Pasivo', '{spawn}', '{itemSoltado}', '{apariencia}')", conexion); //consulta
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void ModificarPasivoBaseDeDatos()
        {
            string strDeConexion = "Data Source = Minecraft.sqlite";
            SqliteConnection conexion = new SqliteConnection(strDeConexion);   //puntero

            conexion.Open();

            SqliteCommand comando = new SqliteCommand();
            comando = new SqliteCommand($"UPDATE Mobs SET Nombre = '{nombre}', PuntosDeSalud = '{puntosDeSalud}'," +
                $"Spawn = '{spawn}', ItemSoltado = '{itemSoltado}', Apariencia = '{apariencia}' WHERE idMob = {id}", conexion); //consulta
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}
