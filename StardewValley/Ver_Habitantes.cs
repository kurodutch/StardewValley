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
    public partial class Ver_Habitantes : Form
    {
        public Ver_Habitantes()
        {
            InitializeComponent();
        }

        public int indice = 0;
        public int contador = 0;
        public int izquierda = 25;
        public int altura = 12;
        public int anchura = 90;
        public int topizq = 0;
        public int topder = 0;
        public int itemsizquierda = 0;
        public int itemsderecha = 0;
        public int posfinal;
        public int posicion;
        public int itemfinalpagina = 0;
        public int contadorderesta;

        public List<string> ListaHabitantes = new List<string>();
        public List<string> ListaRetratos = new List<string>();

        private void Ver_Habitantes_Load(object sender, EventArgs e)
        {
            string item;
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            string CadenaSelect = "SELECT NOMBRE_HABITANTE, IMAGEN_HABITANTE from Habitantes order by NOMBRE_HABITANTE ASC";

            SqlCommand comando = new SqlCommand(CadenaSelect, conexion.conexion);

            SqlDataReader reader = comando.ExecuteReader();

            while (reader.Read())
            {
                ListaHabitantes.Insert(indice, String.Format("{0}", reader[0]));
                ListaRetratos.Insert(indice, String.Format("{0}", reader[1]));

                if(itemsizquierda < 7)
                {
                    //MessageBox.Show("Item: " + ListaItem[indice]);
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("30") + topizq;
                    txt.Left = Convert.ToInt32("25");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topizq += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    itemsizquierda++;

                    //indice++;
                    //contador++;
                    //MessageBox.Show("Items izquierda " + itemsizquierda + " indice: " + indice + " contador: " + contador);
                    contador++;

                }
                itemsderecha++;

                if(itemsderecha >= 8 && itemsderecha < 15)
                {
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("30") + topder;
                    txt.Left = Convert.ToInt32("250");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("375");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topder += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    //itemsderecha++;
                    //indice++;
                    contador++;



                }
                //ReadSingleRow((IDataRecord)reader);
                indice++;

            }
            reader.Close();
            posfinal = ListaHabitantes.Count();
            ListaHabitantes.Insert(posfinal, "**");

            MessageBox.Show("ultimo item: " + ListaHabitantes.Last());

            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);

            AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            foreach (DataRow row in tabla.Rows)
            {
                coleccion.Add(Convert.ToString(row["NOMBRE_HABITANTE"]));
            }

            this.txt_Filtro.AutoCompleteCustomSource = coleccion;
            this.txt_Filtro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            this.txt_Filtro.AutoCompleteSource = AutoCompleteSource.CustomSource;













        }

        private void pbox_Filtrar_Click(object sender, EventArgs e)
        {

        }

        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Clear();
            itemsizquierda = 0;
            itemsderecha = 0;
            topizq = 0;
            contadorderesta = 0;
            topder = 0;
            int sww = 0;
            posicion = contador;
            //int posfinal = ListaItem.Count();
            //MessageBox.Show("posfinal: " + posfinal);
            //ListaItem[posfinal] = "**";
            //MessageBox.Show("Posición :" + ListaItem[posfinal]);
            //MessageBox.Show("indice: " + indice);
            //MessageBox.Show("Contador: " + contador);
            //MessageBox.Show(ListaItem.Count().ToString());


            // ENTRA EN 14 - TOMATE
            while (ListaHabitantes[posicion] != "**")
            {
                if (itemsizquierda < 7)
                {
                    //MessageBox.Show("Item: " + ListaItem[indice]);
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("12") + topizq;
                    txt.Left = Convert.ToInt32("25");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    ////////////////////////MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topizq += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    itemsizquierda++;

                    //indice++;
                    //MessageBox.Show("CONTADOR " + ListaItem[contador]);
                    contador++;
                    //posicion++;
                    // MessageBox.Show("posición es: " + posicion);

                    itemfinalpagina++;
                    contadorderesta++;
                }

                itemsderecha++;

                if (itemsderecha >= 8 && itemsderecha < 15)
                {
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("12") + topder;
                    txt.Left = Convert.ToInt32("250");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    ////////////////////////// MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("375");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topder += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    //itemsderecha++;
                    //indice++;
                    contador++;
                    //posicion++;
                    itemfinalpagina++;
                    contadorderesta++;

                }


                posicion++;
                //MessageBox.Show("posicion es: " + posicion + " Item en ListaItem[" + posicion + "] es " + ListaItem[posicion]);
                //indice++;



                //MessageBox.Show("Items izquierda " + itemsizquierda + " indice: " + indice + " contador: " + contador);


            }

            itemfinalpagina = contador - contadorderesta;
            itemfinalpagina -= 1;

            MessageBox.Show("cONTADOR: " + contador);
            MessageBox.Show("Itemfinalpagina: " + itemfinalpagina);




        }

        private void txt_Filtro_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                try
                {
                    pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + this.txt_Filtro.Text.ToString() + ".png");


                    this.pbox_Filtrar.SizeMode = PictureBoxSizeMode.Zoom;
                    this.pbox_Filtrar.BorderStyle = BorderStyle.Fixed3D;

                }
                catch(Exception ex)
                {
                    MessageBox.Show("No existe aldeano con el nombre " + txt_Filtro.Text + ". " + "\n\r" + ex.Message, Environment.NewLine);
                   

                }
                //MessageBox.Show("andkabsdkl");
                
            }
        }

        private void txt_Filtro_Leave(object sender, EventArgs e)
        {
            //if (txt_Filtro.Text == @"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Filtro.Text.ToString() + ".png")
            //{
            //    MessageBox.Show(this.txt_Filtro.Text);
            //    this.pbox_Filtrar.SizeMode = PictureBoxSizeMode.Zoom;
            //    this.pbox_Filtrar.BorderStyle = BorderStyle.Fixed3D;
            //}
            try
            {
                pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Filtro.Text.ToString() + ".png");
                MessageBox.Show("perdiendo el foco");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
            //pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");
            //MessageBox.Show("perdiendo el foco");

        }

        private void txt_Filtro_Enter(object sender, EventArgs e)
        {
            if (txt_Filtro.Text == @"C: \Users\JP_51\Documents\StardewValley\Habitantes\" + txt_Filtro.Text.ToString() + ".png")
            {
                MessageBox.Show(this.txt_Filtro.Text);
                this.pbox_Filtrar.SizeMode = PictureBoxSizeMode.Zoom;
                this.pbox_Filtrar.BorderStyle = BorderStyle.Fixed3D;
            }
        }

        private void btn_atras_Click(object sender, EventArgs e)
        {
            int itemprincipio = itemfinalpagina - 13; //18
            MessageBox.Show("Item Principio: " + itemprincipio + " ITEM FINAL PAGINA: " + itemfinalpagina);
            panel1.Controls.Clear();
            contador = itemprincipio;
            itemsizquierda = 0;
            itemsderecha = 0;
            posicion = contador;
            topizq = 0;
            topder = 0;

            while (contador != itemfinalpagina + 1)
            {

                if (itemsizquierda < 7)
                {
                    //MessageBox.Show("Item: " + ListaItem[indice]);
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("12") + topizq;
                    txt.Left = Convert.ToInt32("25");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topizq += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    itemsizquierda++;

                    //indice++;
                    //MessageBox.Show("CONTADOR " + ListaItem[contador]);
                    contador++;
                    //posicion++;
                    // MessageBox.Show("posición es: " + posicion);

                    //itemfinalpagina++;
                }
                itemsderecha++;

                if (itemsderecha >= 8 && itemsderecha < 15)
                {
                    TextBox txt = new TextBox();
                    txt.Name = "txt" + contador;
                    txt.Enabled = false;
                    txt.Width = Convert.ToInt32("115");
                    txt.Height = Convert.ToInt32("20"); // la altura del primero comienza en 15px y termina en 25px
                    txt.Top = Convert.ToInt32("12") + topder;
                    txt.Left = Convert.ToInt32("250");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaHabitantes[contador];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("65");
                    pbox.Height = Convert.ToInt32("65") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("375");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                   // altura += 20;
                    topder += 105;

                    pbox.Load(ListaRetratos[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.Zoom;

                    //itemsderecha++;
                    //indice++;
                    contador++;
                    //posicion++;
                    //itemfinalpagina++;


                }

                MessageBox.Show("El contador es: " + contador + ". El ITEMFINALDEPAGINA ES: " + itemfinalpagina);

            }
            itemfinalpagina = itemprincipio - 1;
            //itemprincipio = itemfinalpagina-itemprincipio
            //itemprincipio = itemfinalpagina - 13; 
            posicion++;
        }
    }
}
