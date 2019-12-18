using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExosPackages
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btQRCoderForm_Click(object sender, EventArgs e)
        {
            QRCoderForm qrCoderForm = new QRCoderForm();
            qrCoderForm.Show();
        }

        private void btItext7Form_Click(object sender, EventArgs e)
        {
            Itext7Form itext7Form = new Itext7Form();
            itext7Form.Show();
        }
    }
}
