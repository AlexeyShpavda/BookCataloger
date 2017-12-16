using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace BookCataloger
{
    public partial class EditingForm : Form
    {
        public EditingForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty &&
                textBox4.Text != string.Empty && textBox5.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                Greeting.ListOfBooks[DisplayForm._id].Author = textBox1.Text;
                Greeting.ListOfBooks[DisplayForm._id].Name = textBox2.Text;
                Greeting.ListOfBooks[DisplayForm._id].Year = textBox3.Text;
                Greeting.ListOfBooks[DisplayForm._id].PublishingHouse = textBox4.Text;
                Greeting.ListOfBooks[DisplayForm._id].Annotation = textBox5.Text;
                Greeting.ListOfBooks[DisplayForm._id].Category = comboBox1.Text;

                Writers.Writer.WriteToFiles("Books.txt");

                MessageBox.Show("Сохранение!", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                Greeting greeting = new Greeting();
                greeting.Show();
            }
            else
            {
                string lineFour = "Не заполнены следущие поля:\r\n";
                if (textBox1.Text == string.Empty) { lineFour += "- Автор\r\n"; textBox1.BackColor = Color.DarkRed; }
                else textBox1.BackColor = Color.White;
                if (textBox2.Text == string.Empty) { lineFour += "- Название\r\n"; textBox2.BackColor = Color.DarkRed; }
                else textBox2.BackColor = Color.White;
                if (textBox3.Text == string.Empty) { lineFour += "- Год издания\r\n"; textBox3.BackColor = Color.DarkRed; }
                else textBox3.BackColor = Color.White;
                if (textBox4.Text == string.Empty) { lineFour += "- Издание\r\n"; textBox4.BackColor = Color.DarkRed; }
                else textBox4.BackColor = Color.White;
                if (textBox5.Text == string.Empty) { lineFour += "- Аннотация\r\n"; textBox5.BackColor = Color.DarkRed; }
                else textBox5.BackColor = Color.White;
                if (comboBox1.Text == string.Empty) { lineFour += "- Категория\r\n"; comboBox1.BackColor = Color.DarkRed; }
                else comboBox1.BackColor = Color.White;

                MessageBox.Show(lineFour, "Не заполнены поля!", MessageBoxButtons.OK);
            }
        }

        private void EditingForm_Load(object sender, EventArgs e)
        {
            textBox1.Text = Greeting.ListOfBooks[DisplayForm._id].Author;
            textBox2.Text = Greeting.ListOfBooks[DisplayForm._id].Name;
            textBox3.Text = Greeting.ListOfBooks[DisplayForm._id].Year;
            textBox4.Text = Greeting.ListOfBooks[DisplayForm._id].PublishingHouse;
            textBox5.Text = Greeting.ListOfBooks[DisplayForm._id].Annotation;
            comboBox1.Text = Greeting.ListOfBooks[DisplayForm._id].Category;
        }
    }
}
