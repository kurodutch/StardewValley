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
            ConexionBD conexion = new ConexionBD();
            string cadena = "SELECT NOMBRE_ITEM from Items";

            SqlCommand comando = new SqlCommand(cadena, conexion.conexion);
            SqlDataAdapter adaptador = new SqlDataAdapter(comando);
            DataTable tabla = new DataTable();
            adaptador.Fill(tabla);
            dataGridView1.DataSource = tabla;
            //tabla
            //dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader);
           
        }

        private void Imagen_Item_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
