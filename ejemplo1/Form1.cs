using DatosLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ejemplo1
{
    public partial class Form1 : Form
    {
        CustomerRepository customerRepository = new CustomerRepository();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        /*  DatosLayer.DataBase.ApplicationName = "Programacion 2 ejemplo";
        DatosLayer.DataBase.ConnectionTimeout = 30;

        string cadenaConexion = DatosLayer.DataBase.ConnectionString;
          var conxion = DatosLayer.DataBase.GetSqlConnection();
       */

        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            var Customers = customerRepository.ObtenerTodos();
            dataGrid.DataSource = Customers;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //var filtro = Customers.FindAll(X => X.CompanyName.StartsWith(tbFiltro.Text));
            //dataGrid.DataSource = filtro;

        }

        //btnBuscar:Click:
        private void button1_Click(object sender, EventArgs e)
        {
            var cliente = customerRepository.ObtenerPorID(textBuscar.Text);
            if (cliente != null)
            {
                textBuscar.Text = cliente.CompanyName;
                MessageBox.Show(cliente.CompanyName);
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            var nuevoCliente = new customers 
            {
                CustomerID = tboxCustomerID.Text,
                CompanyName = tboxCompanyName.Text,
                ContactName = tboxContacName.Text,
                ContactTitle = tboxContactTitle.Text,
                Address = tboxAddress.Text,
                City = tboxCity.Text

            };

            var resultado = 0;
            if (validarCampoNull(nuevoCliente) == false)
            {
                resultado = customerRepository.InsertarCliente(nuevoCliente);
            }
            else
            {
                MessageBox.Show("Debe completar todos los campos por favor" + resultado);
            }

            /*
            if (nuevoCliente.CustomerID == "") {
                MessageBox.Show("El Id en el usuario debe de completarse");
               return;    
            }

            if (nuevoCliente.ContactName == "")
            {
                MessageBox.Show("El nombre de usuario debe de completarse");
                return;
            }
            
            if (nuevoCliente.ContactTitle == "")
            {
                MessageBox.Show("El contacto de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.Address == "")
            {
                MessageBox.Show("la direccion de usuario debe de completarse");
                return;
            }
            if (nuevoCliente.City == "")
            {
                MessageBox.Show("La ciudad de usuario debe de completarse");
                return;
            }

            */


        }

        // si encautnra un null enviara true de lo caontrario false
        public Boolean validarCampoNull(Object objeto)
        {

            foreach (PropertyInfo property in objeto.GetType().GetProperties())
            {
                object value = property.GetValue(objeto, null);
                if ((string)value == "")
                {
                    return true;
                }
            }
            return false;

        }




    }
}
