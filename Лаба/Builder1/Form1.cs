using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Builder1.Builder;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Builder1
{
    public partial class Form1 : Form
    {
        private PizzaDirector director;
        private PizzaBuilder builder;
        public Form1()
        {
            InitializeComponent();
            director = new PizzaDirector();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ingredient = textBox1.Text;
            builder.AddIngredient(ingredient);
            listBox1.Items.Add(ingredient);
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Pizza pizza = director.MakePizza(builder);
            
            MessageBox.Show($"Вашa {pizza.FlourType} з {string.Join(", ", pizza.Ingredients)} готовa!");
          
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }

        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
        {
            builder = new MalaPizzaBuilder();
        }

        private void radioButton2_CheckedChanged_1(object sender, EventArgs e)
        {
            builder = new SriedniaPizzaBuilder();
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            builder = new DuzaPizzaBuilder();
        }
    }
}
