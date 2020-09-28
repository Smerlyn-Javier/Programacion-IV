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
    public partial class Empleados : Form
    {
        public Empleados()
        {
            InitializeComponent();
        }

        class Employee : Person
        {
            string collage;
            string schedule;
            float salary;
            string ocupation;


            public Employee
                (
               string name,
               string lastName,
               string sex,
               int age,
               string collage,
               string ocupation,
               float salary,
               string schedule
               ) : base(name, lastName, sex, age)
            {
                this.collage = collage;
                this.schedule = schedule;
                this.salary = salary;
                this.ocupation = ocupation;

            }
        }

        List<Person> Employees = new List<Person>();
        private void button1_Click(object sender, EventArgs e)
        {
            Employee _student = new Employee(
        txtName.Text,
        txtLastName.Text,
        txtSex.Text,
       Int32.Parse(txtAge.Text),
        txtCollage.Text,
        txtOcupation.Text,
        Int32.Parse(txtSalary.Text),
        txtSchedule.Text
        );
            Employees.Add(_student);


            int counter = dataGridView1.Rows.Count - 1;
            dataGridView1.Rows.Add(1);
            dataGridView1.Rows[counter].Cells[0].Value = txtName.Text;
            dataGridView1.Rows[counter].Cells[1].Value = txtLastName.Text;
            dataGridView1.Rows[counter].Cells[2].Value = txtSex.Text;
            dataGridView1.Rows[counter].Cells[3].Value = txtAge.Text;
            dataGridView1.Rows[counter].Cells[4].Value = txtCollage.Text;
            dataGridView1.Rows[counter].Cells[5].Value = txtOcupation.Text;
            dataGridView1.Rows[counter].Cells[6].Value = txtSchedule.Text;
            dataGridView1.Rows[counter].Cells[7].Value = txtSalary.Text;


            MessageBox.Show($"Registro agregado correctamente en la fila no. {counter}");
        }
    }
}
