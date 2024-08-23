using DatosLayer;
using System;
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
        //List<customers> Customers = new List<customers>();
        CustomerRepository customerRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ////string cadenaConexion = DatosLayer.DataBase.ConnectionString;
            ////MessageBox.Show(cadenaConexion);

            //DatosLayer.DataBase.ApplicationName = "Programación 2; ejemplo";
            //DatosLayer.DataBase.ConnetionTimeout = 30;


            //string cadenaConexion = DatosLayer.DataBase.ConnectionString;

            ////var conectarDB = DatosLayer.DataBase.GetSqlConnection();
            //var conexion = DatosLayer.DataBase.GetSqlConnection();


            /*  DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
        DatosLayer.DataBase.ConnectionTimeout = 30;

        string cadenaConexion = DatosLayer.DataBase.ConnectionString;
          var conxion = DatosLayer.DataBase.GetSqlConnection();
       */

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            //////dataGrid.DataSource = Customers;
            var Customers = customerRepository.ObtenerTodos();
            dataGrid.DataSource = Customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var filtro = Customers.FindAll(X => X.CompanyName.StartsWith(tbFiltro.Text));
            //dataGrid.DataSource = filtro;

        }
    }
}
