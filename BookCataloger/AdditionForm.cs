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
using BookCataloger.Breakers;
using BookCataloger.Model;

namespace BookCataloger
{
    public partial class AdditionForm : Form
    {
        public AdditionForm()
        {
            InitializeComponent();
        }

        private void butAdd_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != string.Empty && textBox2.Text != string.Empty && textBox3.Text != string.Empty &&
                textBox4.Text != string.Empty && textBox5.Text != string.Empty && comboBox1.Text != string.Empty)
            {
                //File.AppendAllText("Books.txt", textBox1.Text + "|" + textBox2.Text + "|" + textBox3.Text + "|" + textBox4.Text
                //    + "|" + textBox5.Text + "|" + comboBox1.Text + "\r\n");
                Greeting.ListOfBooks.Add(new Book(textBox1.Text, textBox2.Text, textBox3.Text, textBox4.Text, textBox5.Text, comboBox1.Text));
                using (StreamWriter sw = new StreamWriter("Books.txt"))
                {
                    foreach (var item in Greeting.ListOfBooks)
                    {
                        sw.WriteLine(item.ToString());
                    }
                }
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

        private void butBack_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
