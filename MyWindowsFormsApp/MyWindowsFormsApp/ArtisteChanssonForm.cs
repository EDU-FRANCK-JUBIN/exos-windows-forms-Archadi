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
    public partial class ArtisteChanssonForm : Form
    {
        public ArtisteChanssonForm()
        {
            InitializeComponent();
        }

        public class Chansson
        {
            #region Membres
            string nomArtiste;
            string titreChansson;

            public Chansson(string _nomArtiste, string _titreChansson)
            {
                nomArtiste = _nomArtiste;
                titreChansson = _titreChansson;
            }
            #endregion

            #region Propriété
            public string NomArtiste
            {
                get { return nomArtiste; }
                set { nomArtiste = value; }
            }

            public string TitreChansson
            {
                get { return titreChansson; }
                set { titreChansson = value; }
            }
            #endregion
        }
    }
}
