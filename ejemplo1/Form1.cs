﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = 
                new SqlConnection("Data Source=LAPTOP-GK1DJVHC\\SQLEXPRESS;Initial Catalog=Northwind;Integrated Security=True;");
            //conexion.Open();
            ////MessageBox.Show("Conectado");
            ////conexion.Close();
            ////MessageBox.Show("Gracias, Conexion finalizada");

            //string selectFrom = "SELECT * FROM [dbo].[Customers]";
            //SqlCommand comando = new SqlCommand(selectFrom, conexion);

            //conexion.Close();
            MessageBox.Show("Conexion creada");
            conexion.Open();
            string selectFrom = "SELECT * FROM [dbo].[Customers]";
            SqlCommand comando = new SqlCommand(selectFrom, conexion);
            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                var customerId = reader[0];
            }

            MessageBox.Show("Conexion cerrada");
            conexion.Close();
            


        }
    }
}
