using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookCataloger
{
    public partial class SearchForm : Form
    {
        public SearchForm()
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
            ListViewItem list;
            listView1.Items.Clear();
            bool flag = false;
            foreach (var item in Greeting.ListOfBooks)
            {
                if (item.Annotation == textBox1.Text || item.Author == textBox1.Text || item.Category == textBox1.Text ||
                    item.Name == textBox1.Text || item.Year == textBox1.Text || item.PublishingHouse == textBox1.Text)
                {
                    flag = true;
                    list = new ListViewItem(item.Author);
                    list.SubItems.Add(item.Name);
                    list.SubItems.Add(item.Year);
                    list.SubItems.Add(item.PublishingHouse);
                    list.SubItems.Add(item.Annotation);
                    list.SubItems.Add(item.Category);
                    listView1.Items.Add(list);
                }
            }
            if (flag)
            {
                FormWithPicture formWithPicture = new FormWithPicture();
                formWithPicture.Show();
            }
        }
    }
}
