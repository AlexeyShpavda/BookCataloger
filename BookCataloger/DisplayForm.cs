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
    public partial class DisplayForm : Form
    {
        public DisplayForm()
        {
            InitializeComponent();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butBack_Click(object sender, EventArgs e)
        {
            Hide();
            Greeting greeting = new Greeting();
            greeting.Show();
        }

        private void DisplayForm_Load(object sender, EventArgs e)
        {
            ListViewItem list;
            listView1.Items.Clear();
            foreach (var item in Greeting.ListOfBooks)
            {
            list= new ListViewItem(item.Author);
            list.SubItems.Add(item.Name);
            list.SubItems.Add(item.Year);
            list.SubItems.Add(item.PublishingHouse);
            list.SubItems.Add(item.Annotation);
            list.SubItems.Add(item.Category);
            listView1.Items.Add(list);

            }
        }
    }
}
