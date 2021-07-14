using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace lastra_julian_POO_Parcial2
{
    public partial class Interfaz : Form
    {
        public int counterClientes = 0;
        public int counterMoviles = 0;
        public int counterProveedores = 0;

        public List<Clientes> listaClientes = new List<Clientes>();
        public List<Proveedor> listaProveedores = new List<Proveedor>();
        public List<Moviles> listaMoviles = new List<Moviles>();
        public List<Responsables> listaResponsables = new List<Responsables>();
        public List<Transportista> listaTransportistas = new List<Transportista>();
        public List<Paquetes> listaPaquetes = new List<Paquetes>();
        public List<Envio> listaEnvios = new List<Envio>();

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
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = listaClientes;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Agregar nuevo proveedor a la lista
            Proveedor proveedor = new Proveedor();

            counterProveedores += 1;

            proveedor.Nombre = textBox4.Text;
            proveedor.IDProveedor = counterProveedores;

            listaProveedores.Add(proveedor);
                
            comboBox2.DataSource = null;
            comboBox2.DataSource = listaProveedores;
            comboBox2.DisplayMember = "Nombre";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Agregar nuevo movil a la lista
            Moviles movil = new Moviles();

            counterMoviles += 1;

            movil.Nombre = textBox5.Text;
            movil.IDMovil = counterMoviles;

            listaMoviles.Add(movil);

            comboBox3.DataSource = null;
            comboBox3.DataSource = listaMoviles;
            comboBox3.DisplayMember = "Nombre";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //Agregar nuevo responsable a la lista
            Responsables responsable = new Responsables();

            responsable.Nombre = textBox6.Text;
            responsable.Apellido = textBox8.Text;
            responsable.DNI = Int32.Parse(textBox7.Text);

            listaResponsables.Add(responsable);

            comboBox4.DataSource = null;
            comboBox4.DataSource = listaResponsables;
            comboBox4.DisplayMember = "Apellido";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            //Agregar nuevo transportista a la lista
            Transportista transportista = new Transportista();

            transportista.Nombre = textBox11.Text;
            transportista.Apellido = textBox10.Text;
            transportista.DNI = Int32.Parse(textBox9.Text);

            listaTransportistas.Add(transportista);

            comboBox5.DataSource = null;
            comboBox5.DataSource = listaTransportistas;
            comboBox5.DisplayMember = "Apellido";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            //Agregar nuevo paquete a la lista
            Paquetes paquete = new Paquetes();

            paquete.Contenido = textBox17.Text;

            listaPaquetes.Add(paquete);

            comboBox6.DataSource = null;
            comboBox6.DataSource = listaTransportistas;
            comboBox6.DisplayMember = "Apellido";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Agregar nuevo envio a la lista
            Envio envio = new Envio();

            envio.cliente = (Clientes)comboBox1.SelectedItem;
            envio.proveedor = (Proveedor)comboBox2.SelectedItem;
            envio.movil = (Moviles)comboBox3.SelectedItem;
            envio.responsable = (Responsables)comboBox4.SelectedItem;
            envio.transportista = (Transportista)comboBox5.SelectedItem;
            envio.paquete = (Paquetes)comboBox6.SelectedItem;

            envio.FechaLLegada = envio.CalcularLLegada();
            envio.LugarSalida = textBox15.Text;
            envio.LugarDestino = textBox14.Text;
            envio.Costo = float.Parse(textBox16.Text);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            // Evento
            // Calculo la cantidad de envio por el destinatario seleccionado

            List<Envio> listaEnviosCompletados = new List<Envio>();
            listView1.Items.Clear();

            if (listaClientes.Count > 0 && listaEnvios.Count > 0)
            {
                foreach (var envio in listaEnvios)
                {
                    if (envio.cliente == (Clientes)comboBox1.SelectedItem && envio.Estado == "Recibido")
                    {
                        listaEnviosCompletados.Add(envio); 

                        listView1.Items.Add(envio.paquete.Contenido);
                    }
                }
                if (listaEnviosCompletados.Count == 0)
                    MessageBox.Show("El destinatario no recibio ningun envio todavia.", "Sistema de Envios",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("El destinatario no recibio ningun envio todavia.", "Sistema de Envios",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}