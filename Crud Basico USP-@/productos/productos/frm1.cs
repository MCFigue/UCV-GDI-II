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

namespace productos
{
    public partial class frm1 : Form
    {
        string server = "Data Source =LAPTOP-T7UOU22V\\SQLEXPRESS; Initial Catalog=BOOKSTORE; Integrated Security = True";
        SqlConnection conectar = new SqlConnection();
        Conexion con = new Conexion();
        public frm1()
        {
            InitializeComponent();
        }

        
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int idempleadoc = Convert.ToInt32(idempleado.Text);
            //double money = Convert.ToDouble(preciode.Text);
            int cant = Convert.ToInt32(cantidad.Text);
            double descuento = Convert.ToDouble(dcto.Text);
            //double subtotale = Convert.ToDouble(subtotal.Text);
            //double impuestoe = Convert.ToDouble(impuesto.Text);
            conectar.ConnectionString = server;
            conectar.Open();
            SqlCommand cmd = new SqlCommand("USP_REGISTRAR_VENTA", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            //cmd.Parameters.AddWithValue("@IDVENTA", 0);
            cmd.Parameters.AddWithValue("@CLIENTE", cliente.Text);
            cmd.Parameters.AddWithValue("@IDEMPLEADO",idempleadoc );
            cmd.Parameters.AddWithValue("@IDPUBLICACION", idpublicacion.Text);
            cmd.Parameters.AddWithValue("@CANTIDAD", cant);
            //cmd.Parameters.AddWithValue("@PRECIODE",0);
            cmd.Parameters.AddWithValue("@DCTO", descuento);
            //cmd.Parameters.AddWithValue("@SUBOTOTAL", 0);
            //cmd.Parameters.AddWithValue("@IMPUESTO", 0);
            cmd.Parameters.AddWithValue("@CODIGO", 0);
            cmd.Parameters.AddWithValue("@MENSAJE", "0");
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException EX)
            {
                MessageBox.Show(EX.ToString());
                throw;
            }
            con.mostrar("venta", primaryGrid);
            conectar.Close();

        }

        private void BORRAR_Click(object sender, EventArgs e)
        {
            
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            con.mostrar("productos",primaryGrid);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void idpublicacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();

        }
       
    }
}
