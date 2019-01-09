using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace StardewValley
{
    public partial class Ver_Gustos : Form
    {
        public Ver_Gustos()
        {
            InitializeComponent();
        }

        public List<string> Gusta = new List<string>();
        public List<string> Odia = new List<string>();
        public string[] A = new string[2];

        int altura = 500;
        int indice = 0;
        int indicegusta = 0;
        int indiceodia = 0;
        int itemsgusta = 0;
        int itemsodia = 0;
        int contador = 0;
        int topizquierda = 0;
        int topderecha = 0;

        private void Ver_Gustos_Load(object sender, EventArgs e)
        {

            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            string cadena = "SELECT NOMBRE_HABITANTE, IMAGEN_HABITANTE from Habitantes order by NOMBRE_HABITANTE ASC";

            SqlCommand comando = new SqlCommand(cadena, cn.conexion);

            Metodos.CargarTabla(comando);



            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            coleccion = Metodos.CargarAutoComplete("Habitantes");
            //txt_Filtrar.


            txt_Habitante.AutoCompleteCustomSource = coleccion;
            txt_Habitante.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Habitante.AutoCompleteSource = AutoCompleteSource.CustomSource;

            pbox_Habitante.BorderStyle = BorderStyle.Fixed3D;
            pbox_Habitante.SizeMode = PictureBoxSizeMode.Zoom;





            cn.Cerrar();
        }

        private void txt_Habitante_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                if (!File.Exists(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png"))
                {
                    MessageBox.Show("No existe ningún aldeano con el nombre ingresado.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png");
                }
                //MessageBox.Show("andkabsdkl");
                //this.pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png");
            }


        }

        private void txt_Habitante_Leave(object sender, EventArgs e)
        {
            //if (txt_Habitante.Text == @"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png")
            //{
            //    pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png");
            //    MessageBox.Show(txt_Habitante.Text);
            //}
            try
            {
                pbox_Habitante.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Habitante.Text.ToString() + ".png");
                MessageBox.Show("perdiendo el foco");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Buscar_Click(object sender, EventArgs e)
        {

            //----------LLENAR LA TABLA----------//

            Panel_Gusta.Controls.Clear();
            Panel_Odia.Controls.Clear();
            int topizquierda = 0;
            int topderecha = 0;

            ConexionBD cn = new ConexionBD();
            cn.Abrir();
            string[] valoresgusta = new string[3];
            string[] valoresodia = new string[3];
            bool swgusta = false;
            bool swodia =false;
            string cadenagustos = "Select H.Nombre_Habitante, I.Nombre_Item, HI.Id_Habitante, HI.Agrada, I.Imagen_Item from Items I inner join HAB_ITEM HI on I.id_Item = HI.ID_Item inner join Habitantes H on H.Id_Habitante= HI.ID_Habitante " +
                                    "and H.Nombre_Habitante =@NOMBRE_HABITANTE";
            SqlCommand cmdgustos = new SqlCommand(cadenagustos, cn.conexion);
            cmdgustos.Parameters.AddWithValue("@NOMBRE_HABITANTE", txt_Habitante.Text);
            cmdgustos.ExecuteNonQuery();

            SqlDataReader lector = cmdgustos.ExecuteReader();

            while (lector.Read())
            {
                //MessageBox.Show("primera variable es " + Convert.ToString(lector[3]) + " , segunda variable es " + Convert.ToString(1));
                bool Agrada;
                bool.TryParse(Convert.ToString(lector[3]), out Agrada);
                MessageBox.Show("primera variable es " + Agrada + " , segunda variable es " + Convert.ToString(1));
                if (Agrada == true)
                {
                    Gusta.Insert(indicegusta, String.Format("{0},{1},{2}", lector[3], lector[1], lector[4]));
                    string item = String.Format("{0}", lector[1]);
                    MessageBox.Show("A " + txt_Habitante.Text + " le gusta el item " + item);
                    //string[] valores;
                    valoresgusta = Gusta[indicegusta].Split(',');
                    indicegusta++;
                    swgusta = true;
                }
                else
                {
                    Odia.Insert(indiceodia, String.Format("{0},{1},{2}", lector[3], lector[1], lector[4])); //gusta, nombre item, ruta item//
                    string item = String.Format("{0}", lector[1]);
                    MessageBox.Show("A " + txt_Habitante.Text + " no le gusta el item " + item);
                    MessageBox.Show("elemento en numero " + indice + " es " + Odia[indice]);
                    //string[] valoresodia = new string[3];
                    valoresodia = Odia[indiceodia].Split(',');
                    indiceodia++;
                    swodia = true;

                }



                if (swgusta == true)
                {

                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("35") + topizquierda;
                    txt.Left = Convert.ToInt32("25");
                    Panel_Gusta.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = valoresgusta[1];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("25") + topizquierda;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    Panel_Gusta.Controls.Add(pbox);

                    altura += 20;
                    topizquierda += 60;

                    pbox.Load(valoresgusta[2]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

                    itemsgusta++;
                    swgusta = false;
                    //indice++;
                    //contador++;
                    //MessageBox.Show("Items izquierda " + itemsizquierda + " indice: " + indice + " contador: " + contador);
                    contador++;

                    //indice++;
                }

                if (swodia == true)
                {
                    MessageBox.Show("dentro del panel de la derecha.");
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("35") + topderecha;
                    txt.Left = Convert.ToInt32("25");
                    Panel_Odia.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = valoresodia[1];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("25") + topderecha;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    Panel_Odia.Controls.Add(pbox);

                    altura += 20;
                    topderecha += 60;

                    pbox.Load(valoresodia[2]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

                    itemsodia++;
                    swodia = false;
                    //indice++;
                    //contador++;
                    //MessageBox.Show("Items izquierda " + itemsizquierda + " indice: " + indice + " contador: " + contador);
                    contador++;
                }

                

            }
            lector.Close();
        }
    }
}
