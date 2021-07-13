using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lastra_julian_POO_Parcial2
{
    public partial class Interfaz : Form
    {
        public int counterClientes = 0;

        public List<Clientes> listaClientes = new List<Clientes>();

        public Interfaz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Agregar nuevo cliente a la lista

            // Obtengo el ID de cliente
            counterClientes += 1;
            
            Clientes cliente = new Clientes(textBox1.Text, textBox2.Text,
                Int32.Parse(textBox3.Text), counterClientes);

            listaClientes.Add(cliente);

            comboBox1.DataSource = null;
            comboBox1.DataSource = listaClientes;
            comboBox1.DisplayMember = "Apellido";
        }
    }
}
