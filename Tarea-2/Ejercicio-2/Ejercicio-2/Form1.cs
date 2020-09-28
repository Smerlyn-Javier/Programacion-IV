using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

       public class Product
        {
            private float price;
            private long code;
            private string name;
            private string brand;
            
            protected float Price { get; set; }
            protected long Code { get; set; }
            protected string Brand { get; set; }
            protected string Name { get; set; }
            

            public string to_stock(string name, string brand, long code, float price)
            {
                this.name = name;
                this.brand = brand;
                this.code = code;
                this.price = price;

                return $"Hemos almacenado El producto: {this.name} de la marca: {this.brand} en bodega con el codigo: {this.code} y el precio: {this.price}";
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Product product = new Product();
            string Cproduct = product.to_stock(txtName.Text,txtBrand.Text, Int32.Parse(txtCode.Text), Int32.Parse(txtPrice.Text));
            //CLEAN TEXTBOX
            txtBrand.Text = "";
            txtCode.Text = "";
            txtName.Text = "";
            txtPrice.Text = "";
            MessageBox.Show(Cproduct);
        }


       public class Papers : Product
        {
           private string type;
           private string color;
           private string size;

            protected string Type { get; set; }
            protected string Color { get; set; }
            protected string Size { get; set; }

            public string selectPaper(string type, string color, string size)
            {
                this.type = type;
                this.color = color;
                this.size = size;

                return $"Esto es un papel de tipo: {this.type} con el color: {this.color}, de tamano: {this.size}";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Papers papers = new Papers();
            string Cpaper = papers.selectPaper(txtType.Text, txtColor.Text, txtSize.Text);
            //CLEAN TEXTBOX
            txtType.Text = ""; 
            txtColor.Text = ""; 
            txtSize.Text = "";
            MessageBox.Show(Cpaper);
        }


        public class Utensils : Product
        {
            private string category;
            private string weight;
            private string material;

            protected string Category { get; set; }
            protected string Wight { get; set; }
            protected string Material { get; set; }

            public string selectUtensils(string category, string weight, string material)
            {
                this.category = category;
                this.weight = weight;
                this.material = material;

                return $"Esto es de la categoria: {this.category} de material: {this.material}, de peso: {this.weight}";
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Utensils utensils = new Utensils();
            string Cutensils = utensils.selectUtensils(txtCategory.Text, txtWeight.Text, txtMaterial.Text);
            //CLEAN TEXTBOX
            txtCategory.Text = "";
            txtWeight.Text = "";
            txtMaterial.Text = "";
            MessageBox.Show(Cutensils);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Papers papers = new Papers();
            string Cpaper = papers.selectPaper(txtType.Text, txtColor.Text, txtSize.Text);
            MessageBox.Show(Cpaper);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Utensils utensils = new Utensils();
            string Cutensils = utensils.selectUtensils(txtCategory.Text, txtWeight.Text, txtMaterial.Text);
            MessageBox.Show(Cutensils);
        }
    }
}
