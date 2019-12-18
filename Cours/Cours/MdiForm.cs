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
    public partial class MdiForm : Form
    {
        public MdiForm()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btMdiLevel2Form_Click(object sender, EventArgs e)
        {
            MdiLevel2Form mdiLevel2Form = new MdiLevel2Form() { Owner = this };
            mdiLevel2Form.MdiParent = this; 
            mdiLevel2Form.Show();
            
        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
            string s = this.Owner.Name;
            // Display the name in a message box.
            MessageBox.Show("My Owner.Name is " + s + ".");
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }
    }
}
