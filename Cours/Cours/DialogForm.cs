using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cours
{
    public partial class DialogForm : Form
    {
        public DialogForm()
        {
            InitializeComponent();
        }

        private void btReceive_Click(object sender, EventArgs e)
        {

        }

        private void btSend_Click(object sender, EventArgs e)
        {

        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
            string s = ParentForm.Name;
            // Display the name in a message box.
            MessageBox.Show("My ParentForm.Name is " + s + ".");
        }
    }
}
