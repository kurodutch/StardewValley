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
    public partial class Ver_Items : Form
    {
        public Ver_Items()
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
        public int itemfinalpagina =0;
        public int  contadorderesta;

        public List<string> ListaItem = new List<string>();
        public List<string> ListaImagenes = new List<string>();

        private void Ver_Items_Load(object sender, EventArgs e)
        {

            
            string item;
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";

            SqlCommand comando = new SqlCommand(cadena, conexion.conexion);



            SqlDataReader reader = comando.ExecuteReader();

           

            while (reader.Read())
            {
                //ListaItem[i] = String.Format("{0}", reader[0]);
                ListaItem.Insert(indice, String.Format("{0}", reader[0]));
                ListaImagenes.Insert(indice, String.Format("{0}", reader[1]));

                //MessageBox.Show(String.Format("{0}", reader[0]));
                //MessageBox.Show(ListaImagenes[i]);
                ////////////for (int i=0; reader.Read(); i++)
                ////////////{
                ////////////    MessageBox.Show(String.Format("{0}", reader[0]));
                ////////////    ListaItem[i] = String.Format("{0}", reader[0]);
                ////////////    //i++;
                ////////////    MessageBox.Show(ListaItem[i]);
                ////////////}
                // item = String.Format("{0}", reader[0]);

                //Label txt = new Label();
                
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

                    txt.Text = ListaItem[contador];
                    //MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topizq += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

                    itemsizquierda++;

                    //indice++;
                    //contador++;
                    //MessageBox.Show("Items izquierda " + itemsizquierda + " indice: " + indice + " contador: " + contador);
                    contador++;

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
                    txt.Left = Convert.ToInt32("225");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaItem[contador];
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("350");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    //altura += 20;
                    topder += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

                    //itemsderecha++;
                    //indice++;
                    contador++;
                }


                //contador++;
                //anchura += 20;
                //altura += 20;
                //top += 60;
                //izquierda += 20;


                //ReadSingleRow((IDataRecord)reader, txt_Item01.Text);
                ReadSingleRow((IDataRecord)reader);
                indice++;
            }

            reader.Close();
            posfinal = ListaItem.Count();
            ListaItem.Insert(posfinal,"**");

            MessageBox.Show("ultimo item: " + ListaItem.Last());
            //MessageBox.Show("item numero 15: " + ListaItem[45]);





            //-----------LLENAR LOS txt Y LOS PICBOX (15 TOTAL)---------------//






            //MessageBox.Show("hay un total de " + ListaItem.Count + " elementos en la lista.");
            //MessageBox.Show("hay un total de " + ListaImagenes.Count + " elementos en la lista.");


            //while (txt_Item03.Text == "")
            //{
            //    //MessageBox.Show("dentro del FOR");
            //    txt_Item01.Text = ListaItem[j];

            //    pbox_Item01.Load(ListaImagenes[j]);
            //    pbox_Item01.SizeMode = PictureBoxSizeMode.CenterImage;
            //    j++;
            //}

            //for (int j = 0; txt_Item03.Text != ""; j++)
            //{
            //    MessageBox.Show("dentro del FOR");
            //    txt_Item01.Text = ListaItem[j];
            //    pbox_Item01.Load(ListaImagenes[j]);
            //    pbox_Item01.SizeMode = PictureBoxSizeMode.CenterImage;
            //}


            //tabla
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);


            //SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            //DataTable tabla = new DataTable();
            //adaptador.Fill(tabla);

            //cmbox_Filtrar.ValueMember = "IMAGEN_ITEM";
            //cmbox_Filtrar.DisplayMember = "NOMBRE_ITEM";
            //cmbox_Filtrar.DataSource = tabla;

            //AutoCompleteStringCollection coleccion = new AutoCompleteStringCollection();
            //foreach (DataRow row in tabla.Rows)
            //{
            //    coleccion.Add(Convert.ToString(row["NOMBRE_ITEM"]));
            //}
            //cmbox_Filtrar.AutoCompleteCustomSource = coleccion;
            //cmbox_Filtrar.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            //cmbox_Filtrar.AutoCompleteSource = AutoCompleteSource.CustomSource;


            Metodos.CargarTabla(comando);
            

            //CargarTabla(comando);
            AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
            coleccion2 = Metodos.CargarAutoComplete("Items");
            //txt_Filtrar.
            

            txt_Filtro.AutoCompleteCustomSource = coleccion2;
            txt_Filtro.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txt_Filtro.AutoCompleteSource = AutoCompleteSource.CustomSource;

            //if (coleccion.Contains(txt_Filtro.Text))
            //{
            //    MessageBox.Show("ESKEREE");
            //}



            //coleccion.Contains("asdasd");
            //coleccion.GetType();






        }

        //public  static DataTable CargarTabla(SqlCommand comando)
        //{
        //    DataTable tabla = new DataTable();
        //    SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            
        //    adaptador.Fill(tabla);
        //    return tabla;

        //}



        //public static AutoCompleteStringCollection CargarAutoComplete()
        //{
        //    ConexionBD conexion = new ConexionBD();
        //    conexion.Abrir();
        //    string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";

        //    SqlCommand  comando = new SqlCommand(cadena, conexion.conexion);

        //    DataTable tabla = CargarTabla(comando);

        //    AutoCompleteStringCollection coleccion2 = new AutoCompleteStringCollection();
        //    foreach (DataRow row in tabla.Rows)
        //    {
        //        coleccion2.Add(Convert.ToString(row["NOMBRE_ITEM"]));
        //    }

        //    return coleccion2;

        //}

        private static void ReadSingleRow(IDataRecord record)
        {
             //MessageBox.Show(String.Format("{0}, {1}", record[0], record[1]));
            //MessageBox.Show(String.Format("{0}, {1}, {2}", record[0], record [1], record [2]));
           //txt_Item01 =String.Format("{0}", record[0]);
        }

        private void Imagen_Item_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbox_Filtrar_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_Filtrar.Text = cmbox_Filtrar.SelectedValue.ToString();
            pbox_Filtrar.Load(cmbox_Filtrar.SelectedValue.ToString());
        }


        private void btn_siguiente_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
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
            while (ListaItem[posicion] != "**")
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

                    txt.Text = ListaItem[contador];
                    ////////////////////////MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    altura += 20;
                    topizq += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

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
                    txt.Left = Convert.ToInt32("225");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaItem[contador];
                   ////////////////////////// MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("350");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    altura += 20;
                    topder += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

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

        private void txt_Filtro_Leave(object sender, EventArgs e)
        {

            //txt_Filtrar.Text = txt_Filtro.ToString();
            //pbox_Filtrar.Load(cmbox_Filtrar.SelectedValue.ToString());
            //pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");

            //MessageBox.Show("perdiendo el foco");

            try
            {
                pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");
                MessageBox.Show("perdiendo el foco");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txt_Filtro_MouseClick(object sender, MouseEventArgs e)
        {
            //try
            //{

            //    pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        private void btn_atrás_Click(object sender, EventArgs e)
        {
            int itemprincipio = itemfinalpagina-13; //18
            MessageBox.Show("Item Principio: " + itemprincipio + " ITEM FINAL PAGINA: " + itemfinalpagina);
            panel1.Controls.Clear();
            contador = itemprincipio;
            itemsizquierda = 0;
            itemsderecha = 0;
            posicion = contador;
            topizq = 0;
            topder = 0;

            while (contador  != itemfinalpagina+1)
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

                    txt.Text = ListaItem[contador];
                   MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);

                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topizq;
                    pbox.Left = Convert.ToInt32("150");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    altura += 20;
                    topizq += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

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
                    txt.Left = Convert.ToInt32("225");
                    panel1.Controls.Add(txt);
                    //txt.AutoSize = false;
                    //txt.MaxLength = 20;

                    txt.Text = ListaItem[contador];
                    MessageBox.Show("Item en la posicion " + contador + " es " + txt.Text);
                    //txt.TextAlign = ContentAlignment.BottomCenter;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                    txt.TextAlign = HorizontalAlignment.Center;

                    PictureBox pbox = new PictureBox();
                    pbox.Name = "pbox" + contador;
                    pbox.Width = Convert.ToInt32("30");
                    pbox.Height = Convert.ToInt32("30") + altura; // la altura del primero comienza en 0px y termina en 40px
                    pbox.Top = Convert.ToInt32("0") + topder;
                    pbox.Left = Convert.ToInt32("350");
                    pbox.BorderStyle = BorderStyle.Fixed3D;
                    panel1.Controls.Add(pbox);

                    altura += 20;
                    topder += 60;

                    pbox.Load(ListaImagenes[contador]);
                    pbox.SizeMode = PictureBoxSizeMode.AutoSize;

                    //itemsderecha++;
                    //indice++;
                    contador++;
                    //posicion++;
                    //itemfinalpagina++;

                    
                }

                MessageBox.Show("El contador es: " + contador + ". El ITEMFINALDEPAGINA ES: " + itemfinalpagina);

            }
            itemfinalpagina = itemprincipio-1;
            //itemprincipio = itemfinalpagina-itemprincipio
             //itemprincipio = itemfinalpagina - 13; 
            posicion++;
        }

        private void txt_Filtro_TextChanged(object sender, EventArgs e)
        {
            ////////////////////////////if (txt_Filtro.Text == @"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png")
            ////////////////////////////{
            ////////////////////////////    MessageBox.Show(txt_Filtro.Text);
            ////////////////////////////}

            ////////////////////////////txt_Filtrar.Text = txt_Filtro.ToString();
            //////////////////////////////if () ;
            ////////////////////////////string ruta = @"C:\Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text;
            //////////////////////////////if (ruta.Contains(txt_Filtro.Text))
            //////////////////////////////{
            //////////////////////////////    MessageBox.Show("Se encontró el archivo " + txt_Filtro.Text + "dentro del directrio!");


            //////////////////////////////}

            ////////////////////////////MessageBox.Show(ruta);
            ////////////////////////////if (File.Exists(ruta))
            ////////////////////////////{
            ////////////////////////////    MessageBox.Show("EL ARCHIVO EXISTE: " + txt_Filtro.Text); 
                
            ////////////////////////////}
            //pbox_Filtrar.Load(cmbox_Filtrar.SelectedValue.ToString());
            //pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");


            //ConexionBD conexion = new ConexionBD();
            //conexion.Abrir();
            //string cadena = "SELECT IMAGEN_ITEM from Items where NOMBRE_ITEM = " + txt_Filtro.Text;

            //SqlCommand comando = new SqlCommand(cadena, conexion.conexion);
            
            //SqlDataReader lector = comando.ExecuteReader();
            //comando.ExecuteNonQuery();

           

        }

        private void txt_Filtro_Enter(object sender, EventArgs e)
        {
            if (txt_Filtro.Text == @"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png")
            {
                MessageBox.Show(txt_Filtro.Text);
            }
        }

        private void btn_siguiente_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void txt_Filtro_KeyDown(object sender, KeyEventArgs e)
        {
            //if((int) e.KeyCode == (int)Keys.Enter)
            //{

            //    MessageBox.Show("andkabsdkl");  
            //}

            if (e.KeyCode == Keys.Enter)
            {
                //MessageBox.Show("andkabsdkl");
                pbox_Filtrar.Load(@"C: \Users\JP_51\Documents\StardewValley\Items\" + txt_Filtro.Text.ToString() + ".png");
            }
        }
    }





}
    

