using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace FormExosPackages
{
    public partial class Itext7Form : Form
    {
        public Itext7Form()
        {
            InitializeComponent();
        }

        private void btGeneratPDF_Click(object sender, EventArgs e)
        {
            string monTexte = rtbWriteText.Text;
            var writter = new PdfWriter(@"D:\Csharp Projets\Documents\Test.pdf");
            var pdf = new PdfDocument(writter);
            var document = new Document(pdf);
            document.Add(new Paragraph(monTexte));
            document.Close();
        }
    }
}
