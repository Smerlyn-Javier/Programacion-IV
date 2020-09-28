using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2._4
{
    public partial class Estudiante : Form
    {
        public Estudiante()
        {
            InitializeComponent();
        }

        

        class Student:Person
        {
            string college;
            string career;
            int subject;
            float average;


            public Student
                (
               string name,
               string lastName,
               string sex, 
               int age,
               string college,
               string career,
               int subject,
               float average
               ) :base(name,lastName,sex,age)
            {
                this.college = college;
                this.career = career;
                this.subject = subject;
                this.average = average;

            }
        }
        
        List<Person> Students = new List<Person>();
        private void button1_Click(object sender, EventArgs e)
        {
            Student _student = new Student(
                txtName.Text,
                txtLastName.Text,
                txtSex.Text,
               Int32.Parse(txtAge.Text),
                txtCollage.Text,
                txtCareer.Text,
                Int32.Parse(txtSubjet.Text),
                float.Parse(txtAverage.Text)
                );
            Students.Add(_student);


            int counter = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[counter].Cells[0].Value = txtName.Text;
            dataGridView1.Rows[counter].Cells[1].Value = txtLastName.Text;
            dataGridView1.Rows[counter].Cells[2].Value = txtSex.Text;
            dataGridView1.Rows[counter].Cells[3].Value = txtAge.Text;
            dataGridView1.Rows[counter].Cells[4].Value = txtCollage.Text;
            dataGridView1.Rows[counter].Cells[5].Value = txtCareer.Text;
            dataGridView1.Rows[counter].Cells[6].Value = txtSubjet.Text;
            dataGridView1.Rows[counter].Cells[7].Value = txtAverage.Text;


            MessageBox.Show($"Registro agregado correctamente en la fila no. {counter}");





            Console.WriteLine(Students);
        }
    }
}
