using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2._3
{
    public partial class Form2 : Form1
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            

            int counter= dataGridView1.Rows.Count - 1; 
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[counter].Cells[0].Value = textBox1.Text;
            dataGridView1.Rows[counter].Cells[1].Value = textBox2.Text;
            dataGridView1.Rows[counter].Cells[2].Value = textBox3.Text;
            dataGridView1.Rows[counter].Cells[3].Value = textBox4.Text;

           
            MessageBox.Show($"Registro agregado correctamente en la fila no. {counter}");

        }

        private void button6_Click(object sender, EventArgs e)
        {
           textBox1.Text = "";
           textBox2.Text = "";
           textBox3.Text = "";
           textBox4.Text = "";
           MessageBox.Show($"Campos limpiados correctamente");

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
