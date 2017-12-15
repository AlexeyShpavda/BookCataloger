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
    public partial class Greeting : Form
    {
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

    }
}
