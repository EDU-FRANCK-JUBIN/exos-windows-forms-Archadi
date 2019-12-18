using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyWindowsFormsApp
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void lstCity_SelectedIndexChanged(object sender, EventArgs e)
        {
            string text = lstCity.GetItemText(lstCity.SelectedItem);
            MessageBox.Show(text);
        }

        private void btSubmit_Click(object sender, EventArgs e)
        {
            string name = tbName.Text;
            string address = tbAddress.Text;

            MessageBox.Show(name + ' ' + address);
        }
    }
}
