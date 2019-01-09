using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace StardewValley
{
    public partial class Agregar_Gustos : Form
    {
        public Agregar_Gustos()
        {
            InitializeComponent();
        }

       

        private void Agregar_Gustos_Load(object sender, EventArgs e)
        {

            //SqlCommand comando = new SqlCommand(ruta,)
            SqlCommand comandoItems = Metodos.LlamarComandoItems();
            SqlCommand comandoHabitantes = Metodos.LlamarComandoHabitantes();
            //Metodos.CargarTabla(comando);
            //Metodos.LlamarComando();
            AutoCompleteStringCollection coleccionItems = new AutoCompleteStringCollection();
            AutoCompleteStringCollection coleccionHabitantes = new AutoCompleteStringCollection();

            Metodos.CargarTabla(comandoItems);
            Metodos.CargarTabla(comandoHabitantes);

            coleccionItems = Metodos.CargarAutoComplete("Items");
            coleccionHabitantes = Metodos.CargarAutoComplete("Habitantes");




            txt_Item.AutoCompleteCustomSource = coleccionItems;
            txt_Item.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Item.AutoCompleteSource = AutoCompleteSource.CustomSource;



            txt_Habitante.AutoCompleteCustomSource = coleccionHabitantes;
            txt_Habitante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Habitante.AutoCompleteSource = AutoCompleteSource.CustomSource;


        }

        private void txt_Habitante_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txt_Habitante_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + this.txt_Habitante.Text.ToString() + ".png");


                    this.pbox_Habitante.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbox_Habitante.BorderStyle = BorderStyle.Fixed3D;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe aldeano con el nombre " + txt_Habitante.Text + ". " + "\n\r" + ex.Message, Environment.NewLine);


                }
                //MessageBox.Show("andkabsdkl");

            }
        }

        private void txt_Item_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    pbox_Item.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".png");


                    this.pbox_Item.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbox_Item.BorderStyle = BorderStyle.Fixed3D;

                }
                catch (Exception ex)
                {
                    MessageBox.Show("No existe item con el nombre " + txt_Item.Text + ". " + "\n\r" + ex.Message, Environment.NewLine);


                }
                //MessageBox.Show("andkabsdkl");

            }
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {

            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            bool sw = true;
            int ID_Hab=0;
            int ID_Item=0;
            byte agrada;
            string exito = "";
            //string ID_habstring = "";

            
            
            //string prueba = "Sam";
            //Verificar que hay un nombre e Imagen Seleccionada.
           // Agregar_Gustos agregar_Gustos = new Agregar_Gustos();
            //TextBox txt_Habitanteprueba = new TextBox();
            //txt_Habitanteprueba.Text = agregar_Gustos.txt_Habitante.Text;
            //---------------VALIDACIONES----------//
            if (txt_Habitante.Text == "" | txt_Item.Text == "")
            {
                MessageBox.Show("Campo Item o Habitante vacío, por favor completar antes de agregar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sw = false;
            }

            if (pbox_Habitante.Image == null | pbox_Item.Image == null)
            {
                MessageBox.Show("Imagen de Item o Habitante vacía, por favor completar antes de agregar.", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                sw = false;
            }

            if (!File.Exists(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png"))
            {
                MessageBox.Show("No existe ningún aldeano con el nombre ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sw = false;
            }
            if(!File.Exists(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".png"))
            {
                MessageBox.Show("No existe ningún item con el nombre ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                sw = false;
            }
            

            //string rutaselect = "Select ID_Habitante from Habitantes H inner join Hab_Item HI on H.ID_Habitante = HI.ID_Habitante and Nombre_Habitante =" + txt_Habitante.Text;
            //string SacarID_Hab = "Select ID_Habitante from Habitantes where Nombre_Habitante = '{0}'";


            //SqlCommand cmdSacarID_Hab = new SqlCommand(SacarID_Hab,cn.conexion );
            if (rbtn_Gusta.Checked)
            {
                agrada = 1;
            }
            else
            {
                agrada = 0;
            }

            if (sw == true)
            {
                ID_Hab = Metodos.ObtenerID_Habitante(txt_Habitante.Text);
                ID_Item = Metodos.ObtenerID_Item(txt_Item.Text);
                if (ID_Hab != -1 & ID_Item != -1)
                {
                    exito = Metodos.Agregar_Gustos(ID_Hab, ID_Item, agrada);
                    if (exito == "SI")
                    {
                        MessageBox.Show("borrando campos");
                        txt_Habitante.Text = null;
                        txt_Item.Text = null;
                        pbox_Habitante.Image = null;
                        pbox_Item.Image = null;
                        rbtn_Gusta.Checked = false;
                        rbtn_Odia.Checked = false;

                    }
                }
            }
            //MessageBox.Show("ID del habitante" + txt_Habitante.Text + " es " + ID_Hab);
            //MessageBox.Show("La ID del item " + txt_Item.Text + " es " + ID_Item);
            //ID_habstring = Convert.ToString(Metodos.ObtenerID_Habitante(txt_Habitante.Text));

            //MessageBox.Show("el numero es "+ ID_Hab);




            //MessageBox.Show("ID del habitante" + txt_Habitante.Text + " es " + ID_Hab);
            ////////////string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";

            ////////////SqlCommand comando = new SqlCommand(cadena, cn.conexion);



            ////////////SqlDataReader lector = comando.ExecuteReader();

            //ID_Hab = Convert.ToInt32(cmdSacarID_Hab.ExecuteScalar());
            //ID_Hab = (Int32)cmdSacarID_Hab.ExecuteScalar();



            //////////////////if (sw == true)
            //////////////////{
            //////////////////    string rutaInsert = "Insert INTO HAB_ITEM (ID_HABITANTE, ID_ITEM, AGRADA) VALUES (@ID_habitante, @ID_Item, @Agrada)";
            //////////////////    try
            //////////////////    {
            //////////////////        SqlCommand comandoInsert = new SqlCommand(rutaInsert, cn.conexion);
            //////////////////        comandoInsert.Parameters.AddWithValue("@ID_Habitante", txt_Habitante.Text.ToString());
            //////////////////        //comandoInsert.Parameters.AddWithValue("@Imagen_Item", txt_Ruta.Text.ToString());
            //////////////////        comandoInsert.Parameters.AddWithValue("@ID_Item", txt_Item.Text.ToString());
            //////////////////        comandoInsert.ExecuteNonQuery();
            //////////////////        pbox_Imagen.Image = null;
            //////////////////    }
            //////////////////    catch (Exception ex)
            //////////////////    {
            //////////////////        MessageBox.Show("Error al agregar Item " + ex.Message);
            //////////////////    }


            //////////////////    //COPIAR LA IMAGEN A LA CARPETA DEL SV//
            //////////////////    mypc.FileSystem.CopyFile(ruta_imagen, @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".png");
            //////////////////    MessageBox.Show("Moviendo archivo desde " + ruta_imagen + " A " + @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".png");
            //////////////////}
        }

        private void rbtn_Gusta_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txt_Habitante_Leave(object sender, EventArgs e)
        {
            try
            {
                pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png");
                pbox_Habitante.SizeMode = PictureBoxSizeMode.Zoom;
                //MessageBox.Show("perdiendo el foco");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Item_Leave(object sender, EventArgs e)
        {
            try
            {
                pbox_Item.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Item.Text.ToString() + ".png");
                //MessageBox.Show("perdiendo el foco");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
