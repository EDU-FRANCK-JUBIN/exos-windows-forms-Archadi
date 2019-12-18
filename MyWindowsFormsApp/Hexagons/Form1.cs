using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hexagons
{
    public partial class Form1 : Form
    {

       

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var graphics = e.Graphics;

            Hexagon h1 = new Hexagon(panel1.Width, panel1.Height, 30);
            var shap = h1.sixPointsOfHex();

            graphics.DrawPolygon(Pens.Red, shap);
        }

    }
}
