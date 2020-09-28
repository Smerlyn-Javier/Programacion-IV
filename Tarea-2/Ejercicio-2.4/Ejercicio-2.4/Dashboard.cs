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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        class countStudent : Students
        {
            int students;
            public countStudent(int students) : base(students)
            {
                this.students = students;
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            countStudent countS = new countStudent(6);
            label4.Text = "12";
            label5.Text = "2";
            label6.Text = "1";
                
           }
    }
}
