using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
//using System.Data.SqlServerCe;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StardewValley
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Btn_CrearCarpeta_Click(object sender, EventArgs e)
        {
           

            string StardewValley = @"C:\Users\JP_51\Documents/StardewValley";
            try
            {
                if (Directory.Exists(StardewValley))
                {
                    MessageBox.Show("La carpeta  ya existe");
                }
                else
                {
                    MessageBox.Show("La carpeta no existe. Creando.");
                    Directory.CreateDirectory(StardewValley);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }


        } //@"\C:\Users\JP_51\Desktop\StardewValley\StardewValley\bin\Debug

        private void Form1_Load(object sender, EventArgs e)
        {
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            //string cadena = "SELECT * FROM Habitantes";
            //try
            //{
            //    SqlCommand comando = new SqlCommand(cadena, conexion.conexion); 
            // el primer conexion es el objeto de tipo ConexionBD, y el segundo es un objeto del tipo SqlConnection que obviamente es parte del obj conexion
            //primero conexion es el objero del tipo Conexion BD y el segundo es el obejto del tipo SqlConnection declarado con anterioridad en la clase ConexionBD
            //    SqlDataReader lector = comando.ExecuteReader();
            //    while (lector.Read())
            //    {
            //        MessageBox.Show(lector.GetValue(0).ToString() + " " + lector.GetValue(1).ToString() + " " + lector.GetValue(2).ToString());
            //    }
            //}
            //catch(Exception ex)
            //{

            //    MessageBox.Show("Error al tratar de ejecutar la consulta. " + ex.Message);
            //}

    
           // conexion.Cerrar();

            string CadenaInsert = "INSERT INTO ITEMS VALUES (@Nombre_Item, @Imagen_Item)"; //(Manzana, c://USER//COSO)"
            try
            {
                //SqlCommand comandoInsert = new SqlCommand(CadenaInsert, conexion.conexion);
                //comandoInsert.Parameters.AddWithValue("@Nombre_Item", "Pera");
                //comandoInsert.Parameters.AddWithValue("@Imagen_Item", "C://User/Coso");
                //comandoInsert.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al tratar de ejecutar consulta INSERT " + ex.Message);
            }
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {

        }

        private void Ver_Items_Click(object sender, EventArgs e)
        {
            //Ver_Items.Visible = true;
            Ver_Items ver_items = new Ver_Items();
            ver_items.Show();
            //Ver_Items
            MessageBox.Show("PEAZO E LONGI");
        }

        private void Agregar_Items_Click(object sender, EventArgs e)
        {
            Agregar_Items agregar_Items = new Agregar_Items();
            agregar_Items.Show();
            MessageBox.Show("Dentro del formulario AGREGAR ITEM");

        }
        // C:\Users\JP_51\Documents


    }

}
