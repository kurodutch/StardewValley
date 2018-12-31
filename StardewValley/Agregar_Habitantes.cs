using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using System.Data.SqlClient;
using System.IO;

namespace StardewValley
{
    public partial class Agregar_Habitantes : Form
    {
        public Agregar_Habitantes()
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
            BuscarImagen.InitialDirectory = @"C:\Users\JP_51\Desktop\Imagenes_StardewValley";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    txt_Ruta.Text = BuscarImagen.FileName;
                    ruta_imagen = BuscarImagen.FileName; // SE PASA LA RUTA DE LA IMAGEN A ruta_imgaen.
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
            if (txt_Habitante.Text == "")
            {
                MessageBox.Show("Debe ingresar un nombre para el Item");
                sw = false;
            }
            if (pbox_Imagen.Image == null)
            {
                MessageBox.Show("Debe ingresar una imagen antes de guardar.");
                sw = false;
            }

            //verificar que carpeta HABITANTES existe.
            string StardewValleyHabitantes = @"C:\Users\JP_51\Documents\StardewValley\Habitantes";
            if (sw == true)
            {
                try
                {
                    if (!Directory.Exists(StardewValleyHabitantes))
                    {
                        //MessageBox.Show("La carpeta  ya existe");
                        DialogResult Resultado;
                        Resultado = MessageBox.Show("La Carpeta Habitantes no existe. Creando", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        //MessageBox.Show("La carpeta no existe. Creando.");
                        Directory.CreateDirectory(StardewValleyHabitantes);
                    }
                    //else
                    //{
                    //    DialogResult Resultado;
                    //    Resultado = MessageBox.Show("La Carpeta Habitantes no existe. Creando", "Confirmación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    //    //MessageBox.Show("La carpeta no existe. Creando.");
                    //    Directory.CreateDirectory(StardewValleyHabitantes);
                    //}
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
            
            //AGREGAR A LA BD//

            if (sw == true)
            {
                string rutaInsert = "Insert INTO Habitantes (Nombre_Habitante, Imagen_Habitante) VALUES (@Nombre_Habitante, @Imagen_Habitante)";
                try
                {
                    SqlCommand comandoInsert = new SqlCommand(rutaInsert, cn.conexion);
                    comandoInsert.Parameters.AddWithValue("@Nombre_Habitante", txt_Habitante.Text.ToString());
                    //comandoInsert.Parameters.AddWithValue("@Imagen_Item", txt_Ruta.Text.ToString());
                    comandoInsert.Parameters.AddWithValue("@Imagen_Habitante", @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Habitante.Text.ToString() + ".jpg");
                    comandoInsert.ExecuteNonQuery();
                    //pbox_Imagen.Load(@"C:\Users\JP_51\Pictures\Katatonia.jpg");
                    pbox_Imagen.Image = null;
                    MessageBox.Show("Habitante agregado con éxito.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al agregar Item " + ex.Message);
                }


                //COPIAR LA IMAGEN A LA CARPETA DEL SV//
                mypc.FileSystem.CopyFile(ruta_imagen, @"C:\Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".jpg");
                MessageBox.Show("Moviendo archivo desde " + ruta_imagen + " A " + @"C:\Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".jpg");
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

    }
    
}
