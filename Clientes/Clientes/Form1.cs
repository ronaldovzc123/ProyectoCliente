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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc1.Text;
            cliente.txtRazon.Text = txtraz1.Text;
            cliente.ShowDialog();  
            
        } 

        private void button12_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc2.Text;
            cliente.txtRazon.Text = txtraz2.Text;
            cliente.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc3.Text;
            cliente.txtRazon.Text = txtraz3.Text;
            cliente.ShowDialog();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc4.Text;
            cliente.txtRazon.Text = txtraz4.Text;
            cliente.ShowDialog();
        }

        private void button11_Click(object sender, EventArgs e)
        {
             Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc5.Text;
            cliente.txtRazon.Text = txtraz5.Text;
            cliente.ShowDialog();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc6.Text;
            cliente.txtRazon.Text = txtraz6.Text;
            cliente.ShowDialog(); ;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Clinete_Datos cliente = new Clinete_Datos();

            cliente.txtRuc.Text = txtruc7.Text;
            cliente.txtRazon.Text = txtraz7.Text;
            cliente.ShowDialog();
        }
    }
}
