using Registro.modelo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Registro
{
    public partial class Form1 : Form
    {
        List<Persona> personas;
        public Form1()
        {
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.FirstName = textBox1.Text;
            persona.LastName = textBox3.Text;
            persona.BirthDate = dateTimePicker1.Value;
            personas.Add(persona);
            ShowPersons();
            ClearTb();
        }

        private void ShowPersons()
        {
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = personas;
        }

        private void ClearTb()
        {
            textBox1.Clear();
            textBox3.Clear();
            dateTimePicker1.Value = DateTime.Now;
            textBox1.Focus();
        }
    }
}
