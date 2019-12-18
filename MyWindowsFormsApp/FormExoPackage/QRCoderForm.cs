using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;

namespace FormExosPackages
{
    public partial class QRCoderForm : Form
    {
        public QRCoderForm()
        {
            InitializeComponent();
        }

        private void QRCoderForm_Load(object sender, EventArgs e)
        {
            QRCodeGenerator monQrCodeGenerator = new QRCodeGenerator();
            QRCodeData monQrCodeData = monQrCodeGenerator.CreateQrCode("http://www.facebook.com", QRCodeGenerator.ECCLevel.Q);
            QRCode monQrCode = new QRCode(monQrCodeData);
            Bitmap monImage = monQrCode.GetGraphic(5, Color.Black, Color.White, true);
            PictureBox maPictureBox = new PictureBox();
            maPictureBox.Width = 350;
            maPictureBox.Height = 350;
            maPictureBox.Image = monImage;
            this.Controls.Add(maPictureBox);
        }
    }
}
