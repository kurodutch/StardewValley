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
    public partial class Menu_Principal : Form
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        private void Btn_CrearCarpeta_Click(object sender, EventArgs e)
        {
           

            string StardewValley = @"C:\Users\JP_51\Documents\StardewValley";
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

            //CODIGO PARA COPIAR LA RUTA DEL ARCHIVO QUE SELECICIONAS

            //FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            //var resultado = fbd1.ShowDialog();
            //if(resultado == DialogResult.OK)
            //{
            //    txt_1.Text = fbd1.SelectedPath;
            //}



        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            
            
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Ver_Habitantes ver_habitantes = new Ver_Habitantes();
            ver_habitantes.Show();
        }

        private void Ver_Items_Click(object sender, EventArgs e)
        {
            //Ver_Items.Visible = true;
            Ver_Items ver_items = new Ver_Items();
            ver_items.Show();
            //Ver_Items
            //MessageBox.Show("PEAZO E LONGI");
        }

        private void Agregar_Items_Click(object sender, EventArgs e)
        {
            Agregar_Items agregar_Items = new Agregar_Items();
            agregar_Items.Show();
            ////Menu_Principal menu_principal = new Menu_Principal();
            ////menu_principal.Hide();

        }

        private void btn_Destino_Click(object sender, EventArgs e)
        {
            //FolderBrowserDialog fbd1 = new FolderBrowserDialog();
            //var resultado = fbd1.ShowDialog();
            //if (resultado == DialogResult.OK)
            //{
            //    txt_1.Text = fbd1.SelectedPath;
            //}


            //FolderBrowserDialog fbd2 = new FolderBrowserDialog();
            //var resultado2 = fbd2.ShowDialog();
            //if (resultado2 == DialogResult.OK)
            //{
            //    txt_2.Text = fbd2.SelectedPath + txt_1.Text.Substring(txt_1.Text.LastIndexOf(@"\"));
            //}
            //MessageBox.Show(txt_1.Text.Substring(txt_1.Text.LastIndexOf(@"\")));
        }

        private void Agregar_Habitantes_Click(object sender, EventArgs e)
        {
            Agregar_Habitantes agregar_habitantes = new Agregar_Habitantes();
            agregar_habitantes.Show();
        }

        private void Ver_Gustos_Click(object sender, EventArgs e)
        {
            Ver_Gustos ver_gustos = new Ver_Gustos();
            ver_gustos.Show();

        }

        private void Agregar_Gustos_Click(object sender, EventArgs e)
        {
            Agregar_Gustos agregar_gustos = new Agregar_Gustos();
            agregar_gustos.Show();
        }
        // C:\Users\JP_51\Documents


    }

}
