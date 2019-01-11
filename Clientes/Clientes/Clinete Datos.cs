using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clientes
{
    public partial class Clinete_Datos : Form
    {

        Conexionbd conec = new Conexionbd();

        long Ruc;

        Boolean editar;

        public Clinete_Datos()
        {
            InitializeComponent();
        }

        public void ActualizarGrid()
        {
            conec.ActualizarGrid(this.dataGridView1, "select * from tb_cliente ");
        }

        private void Clinete_Datos_Load(object sender, EventArgs e)
        {
            editar = false;
            this.ActualizarGrid();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (editar)
            {
                conec.Conectar();
                string consulta = "update tb_cliente set ruc = '" + txtRuc.Text + "', razonSocial = '" + txtRazon.Text + "', enviar = '" + txtEnviar.Text + "', conCopia = '" + txtCopia.Text + "', dias = '" + txtDias.Text + "', agregarGlosa = '" + txtAgregar.Text + "', observaciones = '" + txtObservacion.Text + "' where ruc =" + Ruc + ";";

                conec.EjecutarSql(consulta);

                this.ActualizarGrid();

                conec.Desconectar();

                this.Limpiar();

                editar = false;

            }
            else
            {
                conec.Conectar();
                if (txtDias.Text.Trim().Length == 0) { txtDias.Text = "0"; }

                string consulta = "insert into tb_cliente (ruc, razonSocial, enviar, conCopia, dias, agregarGlosa,observaciones) values ('" + txtRuc.Text.Trim() + "','" + txtRazon.Text + "','" + txtEnviar.Text + "','" + txtCopia.Text + "','" + txtDias.Text + "','" + txtAgregar.Text + "','" + txtObservacion.Text + "');";

                conec.EjecutarSql(consulta);

                this.ActualizarGrid();

                conec.Desconectar();

                this.Limpiar();
            }

            
        }

        public void Limpiar()
        {
            txtRuc.Text = "";
            txtRazon.Text = "";
            txtObservacion.Text = "";
            txtEnviar.Text = "";
            txtDias.Text = "";
            txtCopia.Text = "";
            txtAgregar.Text = "";

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            editar = true;

            Ruc =long.Parse( this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            txtRuc.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            txtRazon.Text = this.dataGridView1.CurrentRow.Cells[1].Value.ToString();
            txtObservacion.Text = this.dataGridView1.CurrentRow.Cells[2].Value.ToString();
            txtEnviar.Text = this.dataGridView1.CurrentRow.Cells[3].Value.ToString();
            txtDias.Text = this.dataGridView1.CurrentRow.Cells[4].Value.ToString();
            txtCopia.Text = this.dataGridView1.CurrentRow.Cells[5].Value.ToString();
            txtAgregar.Text = this.dataGridView1.CurrentRow.Cells[6].Value.ToString();

        }

        private void TxtBuscar_KeyUp(object sender, KeyEventArgs e)
        {
            conec.ActualizarGrid(this.dataGridView1, "select * from  tb_cliente where ruc like '" + TxtBuscar.Text + "%';");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            Ruc = long.Parse(this.dataGridView1.CurrentRow.Cells[0].Value.ToString());

            var resultado = MessageBox.Show("Desea Borrar el Archivo?","Confirme si desea Borrar", MessageBoxButtons.YesNo,MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                conec.Conectar();
                String consulta = "delete from tb_cliente where ruc ='" + Ruc + "';";

                conec.EjecutarSql(consulta);

                this.ActualizarGrid();

                conec.Desconectar();
            }
            else 
            {
                return;
            }
        }
    }

       
    }
