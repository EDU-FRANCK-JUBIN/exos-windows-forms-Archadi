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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btEgal_Click(object sender, EventArgs e)
        {
            
            if (tbEcranCalcul.Text.Contains("/0"))
            {
                throw new DivideByZeroException("ERR : Division par 0 impossible ! ");
            }
            else
            {
                DataTable dt = new DataTable();
                var v = dt.Compute(tbEcranCalcul.Text.Replace(',', '.'), "");
                tbEcranResult.Text = v.ToString();
            }  
    
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btDiviser_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btMultiplier_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btSubtraire_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btAditionner_Click(object sender, EventArgs e)
        {
            //affiche ecran calcul
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btCE_Click(object sender, EventArgs e)
        {
            tbEcranCalcul.Text = "";
            tbEcranResult.Text = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            tbEcranResult.Text = "";
        }

        private void btSupprimer_Click(object sender, EventArgs e)
        {
            tbEcranCalcul.Text = tbEcranCalcul.Text.Substring(0, tbEcranCalcul.Text.Length - 1);
        }

        private void btDecimale_Click(object sender, EventArgs e)
        {
            tbEcranCalcul.AppendText((sender as Button).Text);
        }

        private void btSubAdd_Click(object sender, EventArgs e)
        {
            if(tbEcranResult.Text.Substring(0,1) == "-")
            {
                tbEcranResult.Text = tbEcranResult.Text.Replace("-", "");
            }
            else
            {
                tbEcranResult.Text = "-"+tbEcranResult.Text;
            }
            
        }
    }
}
