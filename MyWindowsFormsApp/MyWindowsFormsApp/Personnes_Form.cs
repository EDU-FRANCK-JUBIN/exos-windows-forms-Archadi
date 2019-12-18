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
    public partial class Personnes_Form : Form
    {
        //Binding
        public Personnes_Form()
        {
            InitializeComponent();
        }

        private void Personnes_Form_Load(object sender, EventArgs e)
        {
            List<Personne> persos = new List<Personne>(){
            new Personne("Ali", "Toto", "01/02/2000", 19),
            new Personne("Tom", "Harry", "01/02/2000", 19),
            new Personne("Léo", "Jhon", "01/02/2000", 19),
            new Personne("Izac", "Ben", "01/02/2000", 19),
            };

            personneBindingSource.DataSource = persos;
        }
    }
}
