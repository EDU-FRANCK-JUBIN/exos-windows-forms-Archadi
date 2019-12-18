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
    public partial class Level2Form : Form
    {
        public Level2Form()
        {
            InitializeComponent();
        }

        public void toRecive(string txt)
        {
            tbReceive.Text = txt;
        }
        public string toSend()
        {
            return tbSend.Text;
        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
            string s = this.Owner.Name;
            // Display the name in a message box.
            MessageBox.Show("My Owner.Name is " + s + ".");
        }

        private void btReceive_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            tbReceive.Text = mainForm.toSend();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            MainForm mainForm = (MainForm)this.Owner;
            mainForm.toRecive(this.toSend());
        }
    }
}
