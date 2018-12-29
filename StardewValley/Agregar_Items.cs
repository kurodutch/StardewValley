using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;

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

        private void btn_Examinar_Imagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog BuscarImagen = new OpenFileDialog();
            BuscarImagen.Filter = "Archivos de Imagen(*.bmp; *.gif; *.jpg; *.PNG)| *.bmp; *.gif; *.jpg; *.PNG | Todos los Archivos (*.*)|*.*";
            BuscarImagen.InitialDirectory = @"C:\";
            if (BuscarImagen.ShowDialog() == DialogResult.OK)
            {
                txt_Ruta.Text = BuscarImagen.FileName;
                string Direccion = BuscarImagen.FileName;
                pbox_Imagen.ImageLocation = Direccion;
                pbox_Imagen.SizeMode = PictureBoxSizeMode.Zoom;
                // pbox_Imagen.Load(@"C:\Users\JP_51\Pictures\Katatonia.jpg");
                pbox_Imagen.Load(txt_Ruta.Text);

            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            ConexionBD cn = new ConexionBD();
            cn.Abrir();
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

            string NuevaRuta = Path.Combine(@"C:\Users\JP_51\Documents\StardewValley\Items", txt_Item.Text.ToString() + ".png");
            if (!File.Exists(NuevaRuta))
            {
                //File.Move("Manzana.png", NuevaRuta);
                File.Move(@"C:\Users\JP_51\Desktop\Manzana.png", NuevaRuta);

            }
            else
            {
                MessageBox.Show("La ruta de destino ya contiene un archivo con el mismo nombre");
            }

        }
    }
}
