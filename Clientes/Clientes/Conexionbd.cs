using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Clientes
{
    class Conexionbd
    {
        SqlConnection conec;

        public void Conectar()
        {
            conec = new SqlConnection("Data Source=HZC\\SQLEXPRESS;Initial Catalog=bd_Cliente;Integrated Security=True");
            conec.Open();
        }

        public void Desconectar()
        {
            conec.Close();
        }

        public void EjecutarSql(string consulta)
        {
            SqlCommand conectar = new SqlCommand(consulta, conec);

            int filasAfectadas = conectar.ExecuteNonQuery();

            if (filasAfectadas > 0)
            {
                MessageBox.Show("Operacion Realizada", "La base de datos a sido modificada", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No se conecto la base de datos", "Error del Sistema",  MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ActualizarGrid(DataGridView dg, String consulta)
        {

            this.Conectar();

            System.Data.DataSet ds = new System.Data.DataSet();
            SqlDataAdapter da = new SqlDataAdapter(consulta, conec);

            this.Conectar();

            da.Fill(ds, "tb_cliente");

            dg.DataSource = ds;
            dg.DataMember = "tb_cliente";

            this.Desconectar();

        }
    }
}
