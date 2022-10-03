using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace t2_grupo_19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Lista lista = new Lista();
     
        private void panel2_Paint(object sender, PaintEventArgs e)
        {
        }
        private void button1_Click(object sender, EventArgs e)
        {
           try
            {
                lista.insertar("" + codigotxt.Text, nombretxt.Text, double.Parse(preciotxt.Text)
                                   , double.Parse(cantidadtxt.Text));
                button2_Click(sender, e);
        
                codigotxt.Clear();
                nombretxt.Clear();
                preciotxt.Clear();
                cantidadtxt.Clear();
            }

            catch (Exception)
            {
                MessageBox.Show("ingrese sus datos",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label2_Click(object sender, EventArgs e)
            {

            }

        private void button2_Click(object sender, EventArgs e)
        { 
                
                lista.desplegar(dgvregistro);

        }

        private void ordenarbtn_Click(object sender, EventArgs e)
        {
            {
                dgvregistro.Sort(dgvregistro.Columns[1], ListSortDirection.Ascending);
            }

        }

        private void buscarbtn_Click(object sender, EventArgs e)
        {
            try
            {
                string c = datotxt.Text;
                lista.buscar(c, dgvregistro);
                datotxt.Clear();
                if (datotxt.Text== " ")
                {
                    MessageBox.Show("El campo Nombres es obligatorio",
                      "Contactos");
                    nombretxt.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("El nombre del medicamento no fue encontrado",
               "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void eliminarbtn_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Está seguro?", "Eliminar", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question) == DialogResult.Yes)
            {
                lista.eliminar(datotxt.Text);
                datotxt.Clear();
                button2_Click(sender, e);
            }
        }

        private void datotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    } }
