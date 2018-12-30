using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using Microsoft.VisualBasic.Devices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace StardewValley
{
    public partial class Agregar_Items : Form
    {
        public Agregar_Items()
        {
            InitializeComponent();
        }

        Computer mypc = new Computer();
        string ruta_imagen;
        bool sw = true;

        private void btn_Examinar_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen(*.bmp; *.gif; *.jpg; *.png;)| *.bmp; *.gif; *.jpg; *.png; | Todos los Archivos (*.*)|*.*";
            BuscarImagen.InitialDirectory = @"C:\";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Ruta.Text = BuscarImagen.FileName;
                    ruta_imagen = BuscarImagen.FileName;
                    //MessageBox.Show(BuscarImagen.FileName);
                    string Direccion = BuscarImagen.FileName;
                    pbox_Imagen.ImageLocation = Direccion;
                    pbox_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                    // pbox_Imagen.Load(@"C:\Users\JP_51\Pictures\Katatonia.jpg");
                    pbox_Imagen.Load(txt_Ruta.Text);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("El Archivo Seleccionado no es una imagen " + ex.Message);
                }
                

            }
            
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            //Verificar que hay un nombre e Imagen Seleccionada.
            if (txt_Item.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el Item");
                sw = false;
            }

            //verificar que carpeta ITEMS existe.
            string StardewValleyItems = @"C:\Users\JP_51\Documents\StardewValley\Items";
            try
            {
                if (Directory.Exists(StardewValleyItems))
                {
                    //MessageBox.Show("La carpeta  ya existe");
                }
                else
                {
                    DialogResult Resultado;
                    Resultado = MessageBox.Show("La Carpeta Items no existe. Creando", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //MessageBox.Show("La carpeta no existe. Creando.");
                    Directory.CreateDirectory(StardewValleyItems);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

            //AGREGAR A LA BD//

            if (sw == true)
            {
                string rutaInsert = "Insert INTO ITEMS (Nombre_Item, Imagen_Item) VALUES (@Nombre_Item, @Imagen_Item)";
                try
                {
                    SqlCommand comandoInsert = new SqlCommand(rutaInsert, cn.conexion);
                    comandoInsert.Parameters.AddWithValue("@Nombre_Item", txt_Item.Text.ToString());
                    //comandoInsert.Parameters.AddWithValue("@Imagen_Item", txt_Ruta.Text.ToString());
                    comandoInsert.Parameters.AddWithValue("@Imagen_Item", @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".jpg");
                    comandoInsert.ExecuteNonQuery();
                    pbox_Imagen.Load(@"C:\Users\JP_51\Pictures\Katatonia.jpg");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Item " + ex.Message);
                }


                //COPIAR LA IMAGEN A LA CARPETA DEL SV//
                mypc.FileSystem.CopyFile(ruta_imagen, @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".jpg");
                MessageBox.Show("Moviendo archivo desde " + ruta_imagen + " A " + @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".jpg");
            }
           

            //COPIAR LA IMAGEN A LA CARPETA DEL SV//

            //string NuevaRuta = Path.Combine(@"C:\Users\JP_51\Documents\StardewValley\Items", txt_Item.Text.ToString() + ".png");
            //if (!File.Exists(NuevaRuta))
            //{
            //    //File.Move("Manzana.png", NuevaRuta);
            //    File.Move(@"C:\Users\JP_51\Desktop\Manzana.png", NuevaRuta);

            //}
            //else
            //{
            //    MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre");
            //}

            

        }


        private void Agregar_Items_Load(object sender, EventArgs e)
        {
            //MessageBox.Show("Dentro del formulario AGREGAR ITEM");
        }
    }
}
