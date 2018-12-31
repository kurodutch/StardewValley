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

namespace StardewValley
{
    public partial class Ver_Items : Form
    {
        public Ver_Items()
        {
            InitializeComponent();
        }

        
        private void Ver_Items_Load(object sender, EventArgs e)
        {

            List<string> ListaItem = new List<string>();
            List<string> ListaImagenes = new List<string>();   
            string item;
            ConexionBD conexion = new ConexionBD();
            conexion.Abrir();
            string cadena = "SELECT NOMBRE_ITEM, IMAGEN_ITEM from Items order by NOMBRE_ITEM ASC";

            SqlCommand comando = new SqlCommand(cadena, conexion.conexion);

            //CODIGO PARA LLENAR UNA GRID CON LOS DATOS DE LOS ITMES
            ////////SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            ////////DataTable tabla = new DataTable();
            ////////adaptador.Fill(tabla);
            ////////dataGridView1.DataSource = tabla;

            //MessageBox.Show(tabla.ToString());


            SqlDataReader reader = comando.ExecuteReader();
            int i = 0;
            int j = 0;

            while (reader.Read())
            {
                //ListaItem[i] = String.Format("{0}", reader[0]);
                ListaItem.Insert(i, String.Format("{0}", reader[0]));
                ListaImagenes.Insert(i, String.Format("{0}", reader[1]));
                //MessageBox.Show(String.Format("{0}", reader[0]));
                //MessageBox.Show(ListaImagenes[i]);
                ////////////for (int i=0; reader.Read(); i++)
                ////////////{
                ////////////    MessageBox.Show(String.Format("{0}", reader[0]));
                ////////////    ListaItem[i] = String.Format("{0}", reader[0]);
                ////////////    //i++;
                ////////////    MessageBox.Show(ListaItem[i]);
                ////////////}
                item = String.Format("{0}", reader[0]);

                


                //ReadSingleRow((IDataRecord)reader, txt_Item01.Text);
                ReadSingleRow((IDataRecord)reader);
                i++;
            }

            //-----------LLENAR LOS TXT Y LOS PICBOX (15 TOTAL)---------------//

            txt_Item01.Text = ListaItem[0];
            pbox_Item01.Load(ListaImagenes[0]);
            pbox_Item01.SizeMode = PictureBoxSizeMode.CenterImage;
            //MessageBox.Show("Lista Item 1:" + ListaItem[1]);
            txt_Item02.Text = ListaItem[1];
            pbox_Item02.Load(ListaImagenes[1]);
            pbox_Item02.SizeMode = PictureBoxSizeMode.CenterImage;
            txt_Item03.Text = ListaItem[2];
            pbox_Item03.Load(ListaImagenes[2]);
            pbox_Item03.SizeMode = PictureBoxSizeMode.CenterImage;
            txt_Item04.Text = ListaItem[3];
            pbox_Item04.Load(ListaImagenes[3]);
            pbox_Item04.SizeMode = PictureBoxSizeMode.CenterImage;
            txt_Item05.Text = ListaItem[4];
            pbox_Item05.Load(ListaImagenes[4]);
            pbox_Item05.SizeMode = PictureBoxSizeMode.CenterImage;
            txt_Item06.Text = ListaItem[5];
            pbox_Item06.Load(ListaImagenes[5]);
            pbox_Item06.SizeMode = PictureBoxSizeMode.AutoSize;
            txt_Item07.Text = ListaItem[6];
            pbox_Item07.Load(ListaImagenes[6]);
            pbox_Item07.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_Item07.Text = ListaItem[7];
            pbox_Item07.Load(ListaImagenes[7]);
            pbox_Item07.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_Item07.Text = ListaItem[8];
            pbox_Item07.Load(ListaImagenes[8]);
            pbox_Item07.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_Item07.Text = ListaItem[9];
            pbox_Item07.Load(ListaImagenes[9]);
            pbox_Item07.SizeMode = PictureBoxSizeMode.StretchImage;
            txt_Item07.Text = ListaItem[10];
            pbox_Item07.Load(ListaImagenes[10]);
            pbox_Item07.SizeMode = PictureBoxSizeMode.StretchImage;




            MessageBox.Show("hay un total de " + ListaItem.Count + " elementos en la lista.");
            MessageBox.Show("hay un total de " + ListaImagenes.Count + " elementos en la lista.");
            reader.Close();
            MessageBox.Show(ListaItem.Last());

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

        }

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
    }
}
