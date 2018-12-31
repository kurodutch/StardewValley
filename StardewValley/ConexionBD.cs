using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StardewValley
{
    class ConexionBD
    {
        string ruta = @"Data SOurce=DESKTOP-0K1GA54\SQLEXPRESS; Initial Catalog = StardewValley; Integrated Security = True";

        //DESKTOP-0K1GA54
        //DESKTOP-0K1GA54\SQLEXPRESS

        public SqlConnection conexion = new SqlConnection();

        public ConexionBD ()
        {
            conexion.ConnectionString = ruta;

        }
        
        public void Abrir()
        {
            try
            {
                conexion.Open();
                //MessageBox.Show("Conexión Abierta");

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al abrir la BD " + ex.Message);
            }
        }
        
        public void Cerrar()
        {
            conexion.Close();


        }

    }
    
}
