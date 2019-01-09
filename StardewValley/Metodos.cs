using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;
using System.Windows.Forms;
using System.Diagnostics;

namespace StardewValley
{
    class Metodos
    {


        public static SqlCommand LlamarComandoItems()
        {
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            string cadenaItem = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";
            
            SqlCommand comandoItems = new SqlCommand(cadenaItem, conexion.conexion);
            
            return comandoItems;
        }

        public static SqlCommand LlamarComandoHabitantes()
        {
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();

            string cadenaHabitanes = "SELECT NOMBRE_HABITANTE, IMAGEN_HABITANTE from HABITANTES order by NOMBRE_HABITANTE ASC";
            SqlCommand comandoHabitantes = new SqlCommand(cadenaHabitanes, conexion.conexion);
            return comandoHabitantes;

        }

        public static DataTable CargarTabla(SqlCommand comando)
        {
            DataTable tabla = new DataTable();
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);

            adaptador.Fill(tabla);
            return tabla;

        }

        public  static AutoCompleteStringCollection CargarAutoComplete(string tipo)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();

            string cadena = GetCadena(tipo);
            //if (tipo == "Items")
            //{
            //    string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";
            //} 
            //if(tipo == "Habitantes")
            //{
            //    string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";
            //}

            SqlCommand comando = new SqlCommand(cadena, conexion.conexion);

            DataTable tabla = CargarTabla(comando);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                if (tipo == "Items")
                {
                    coleccion.Add(Convert.ToString(row["NOMBRE_ITEM"]));
                }
                if (tipo == "Habitantes")
                {
                    coleccion.Add(Convert.ToString(row["NOMBRE_HABITANTE"]));
                }
            }
            return coleccion;
        }


        public static string GetCadena(string tipo)
        {
            string cadena = tipo;
            if (cadena == "Items")
            {
                cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";

            }
            if (cadena == "Habitantes")
            {
                cadena = "SELECT NOMBRE_HABITANTE, IMAGEN_HABITANTE from Habitantes order by NOMBRE_HABITANTE ASC";

            }
            return cadena;
        }

        public static int ObtenerID_Habitante(string _habitante)
        {
            string habitante = _habitante;
            //MessageBox.Show("Dentro del modulo OBTENERID_HAB. El txt de entrada es " + habitante);
            int ID_Hab=0;
            string ID_habstring = "";
            
            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            try
            {
                string SacarID_Hab = String.Format("Select ID_Habitante from Habitantes where NOMBRE_HABITANTE =@ID_Hab");



                SqlCommand cmdSacarID_Hab = new SqlCommand(SacarID_Hab, cn.conexion);

                cmdSacarID_Hab.Parameters.AddWithValue("@ID_Hab", habitante); //-----es la variable escalar-----//

                //Debugger.Break();
                ID_Hab = Convert.ToInt32(cmdSacarID_Hab.ExecuteScalar());
                //ID_Hab = cmdSacarID_Hab.ExecuteNonQuery();

                SqlDataReader reader = cmdSacarID_Hab.ExecuteReader();
                //string SacarID_Hab = String.Format("Select ID_Habitante from Habitantes where NOMBRE_HABITANTE = {0}", habitante);


                //while (reader.Read())
                //{
                //    //ID_Hab = String.Format("{0}", reader[0]);
                //    //ID_Hab = Convert.ToInt32(reader[0]);
                //    //ID_Hab = reader.GetInt32(0);
                //    //ID_habstring = String.Format("{0}",reader.GetInt32(0));
                //    ID_habstring = Convert.ToString(reader[0]);
                //    //ID_Hab = Int32.Parse(reader.GetInt32(0));
                //    //MessageBox.Show("ID del habitante" + habitante + " es " + ID_Hab);


                //}
                //reader.Close();

            }catch(Exception ex)
            {
                MessageBox.Show("Error al agregar gusto a la Base de datos " + ex.Message);
                ID_Hab = -1;
                return ID_Hab;
            }
            finally
            {
                cn.Cerrar();
            }



            
            return ID_Hab;

            //ID_Hab = Convert.ToInt32(cmdSacarID_Hab.ExecuteScalar());
            

        }

        public static int ObtenerID_Item(string _item)
        {
            int ID_Item = 0;
            string item = _item;
            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            try
            {
                string SacarID_Item = String.Format("Select ID_Item from Items where NOMBRE_ITEM =@ID_Item");
                SqlCommand cmdSacarID_Item = new SqlCommand(SacarID_Item, cn.conexion);

                cmdSacarID_Item.Parameters.AddWithValue("@ID_Item", item);
                ID_Item = Convert.ToInt32(cmdSacarID_Item.ExecuteScalar());
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al agregar gusto a la Base de datos " + ex.Message);
                ID_Item  = -1;
            }
            finally
            {
                cn.Cerrar();

            }
            return ID_Item;
        }

        public static  string Agregar_Gustos(int _ID_Hab, int _ID_Item, byte _agrada)
        {
            int ID_Hab = _ID_Hab;
            int ID_Item = _ID_Item;
            byte agrada = _agrada;
            string exito = "";

            ConexionBD cn = new ConexionBD();
            cn.Abrir();

            try
            {
                string AgregarGustosBD = String.Format("Insert into HAB_ITEM (ID_Habitante, ID_Item, Agrada) VALUES (@ID_Hab, @ID_Item, @Agrada)");
                SqlCommand cmd_AgregarGustosBD = new SqlCommand(AgregarGustosBD, cn.conexion);

                cmd_AgregarGustosBD.Parameters.AddWithValue("@ID_Hab", ID_Hab);
                cmd_AgregarGustosBD.Parameters.AddWithValue("@ID_Item", ID_Item);
                cmd_AgregarGustosBD.Parameters.AddWithValue("@Agrada", agrada);
                cmd_AgregarGustosBD.ExecuteNonQuery();


               // MessageBox.Show("Agregado con éxito a la BD!", "Confinrmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                MessageBox.Show("Agregado con éxito a la BD!", "Confinrmación", MessageBoxButtons.OK, MessageBoxIcon.Information);
                exito = "SI";
                return exito;


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar gusto a la BD " + ex.Message);
                exito = "NO";
                return exito; ;
            }
            finally
            {
                cn.Cerrar();
            }

            
        }

    }

        
    
}
