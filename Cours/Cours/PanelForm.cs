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
    public partial class PanelForm : Form
    {
        public PanelForm()
        {
            InitializeComponent();
        }

        private void btMyParent_Click(object sender, EventArgs e)
        {
            MessageBox.Show("My ParentForm.Name is " + ParentForm.Name + ".");
            }
    }
}
