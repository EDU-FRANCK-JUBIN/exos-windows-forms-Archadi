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
    public partial class MdiLevel2Form : Form
    {
        public MdiLevel2Form()
        {
            InitializeComponent();
        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
           
            // Display the name in a message box.
            MessageBox.Show("My ParentForm.Name is " + ParentForm.Name + ".");
            MessageBox.Show("My ParentForm.Owner.Name is " + ParentForm.Owner.Name + ".");
            MessageBox.Show("My MdiParent is " + this.MdiParent + ".");
        }
    }
}
