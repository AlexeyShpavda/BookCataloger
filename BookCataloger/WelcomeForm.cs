using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookCataloger.Model;
using System.IO;
using BookCataloger.Breakers;

namespace BookCataloger
{
    public partial class Greeting : Form
    {
        private static List<Book> listOfBooks = new List<Book>();
        internal static List<Book> ListOfBooks { get => listOfBooks; set => listOfBooks = value; }

        public Greeting()
        {
            InitializeComponent();
        }


        private void butAdd_Click(object sender, EventArgs e)
        {
            Hide();
            AdditionForm additionForm = new AdditionForm();
            additionForm.Show();
        }

        private void butExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void butView_Click(object sender, EventArgs e)
        {
            Hide();
            DisplayForm displayForm = new DisplayForm();
            displayForm.Show();
        }

        private void Greeting_Load(object sender, EventArgs e)
        {
            listOfBooks.Clear();
            string str;
            using (StreamReader reader = new StreamReader("Books.txt"))
            {
                while ((str = reader.ReadLine()) != null)
                {
                    string[] words = LineBreaker.ReturnWordArr('|', str, 0);
                    ListOfBooks.Add(new Book(words[0], words[1], words[2], words[3], words[4], words[5]));
                }
            }

        }

        private void butSearch_Click(object sender, EventArgs e)
        {
            Hide();
            SearchForm search = new SearchForm();
            search.Show();
        }
    }
}
