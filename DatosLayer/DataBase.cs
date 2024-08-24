using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace DatosLayer
{

    //public class CustomerRepository
    //{
    //    public List<customers> ObtenerTodos();

    //    public customers ObtenerPorID(string id)
    //    {

    //        using (var conexion = DataBase.GetSqlConnection())
    //        {

    //            String selectForID = "";
    //            selectForID = selectForID + "SELECT [CustomerID] " + "\n";
    //            selectForID = selectForID + "      ,[CompanyName] " + "\n";
    //            selectForID = selectForID + "      ,[ContactName] " + "\n";
    //            selectForID = selectForID + "      ,[ContactTitle] " + "\n";
    //            selectForID = selectForID + "      ,[Address] " + "\n";
    //            selectForID = selectForID + "      ,[City] " + "\n";
    //            selectForID = selectForID + "      ,[Region] " + "\n";
    //            selectForID = selectForID + "      ,[PostalCode] " + "\n";
    //            selectForID = selectForID + "      ,[Country] " + "\n";
    //            selectForID = selectForID + "      ,[Phone] " + "\n";
    //            selectForID = selectForID + "      ,[Fax] " + "\n";
    //            selectForID = selectForID + "  FROM [dbo].[Customers] " + "\n";
    //            selectForID = selectForID + $"  Where CustomerID = '{id}'";


    //        }
    //    }
    //}



    //}

    public class DataBase
    {
        public static int ConnetionTimeout { get; set; }
        public static string ApplicationName { get; set; }

        public static SqlConnection GetSqlConnection()
        {

            SqlConnection conexion = new SqlConnection(ConnectionString);
            conexion.Open();
            return conexion;
        }

        public static String ConnectionString
        {
            //get
            //{
            //    return ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;
            //}
            get
            {
                String CadenaConexion = ConfigurationManager
                   .ConnectionStrings["NWConnection"]
                   .ConnectionString;

                SqlConnectionStringBuilder conexionBuilder =
                    new SqlConnectionStringBuilder(CadenaConexion);

                conexionBuilder.ApplicationName =
                ApplicationName ?? conexionBuilder.ApplicationName;
                conexionBuilder.ConnectTimeout = (ConnetionTimeout > 0)
                    ? ConnetionTimeout : conexionBuilder.ConnectTimeout;
                return conexionBuilder.ToString();
            }
        }


        public static String ConnectionString1()
        {

            return ConfigurationManager.ConnectionStrings["NWConnection"].ConnectionString;

        }

        


    }
}
