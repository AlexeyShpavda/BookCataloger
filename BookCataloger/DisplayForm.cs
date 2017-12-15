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
            string str;
            ListViewItem list;
            using (StreamReader reader = new StreamReader("Books.txt"))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr('|', str, 0);
                    list= new ListViewItem(words[0]);
                    list.SubItems.Add(words[1]);
                    list.SubItems.Add(words[2]);
                    list.SubItems.Add(words[3]);
                    list.SubItems.Add(words[4]);
                    list.SubItems.Add(words[5]);
                    listView1.Items.Add(list);
                    //Book.Add(new Candy(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            }
        }
    }
}
