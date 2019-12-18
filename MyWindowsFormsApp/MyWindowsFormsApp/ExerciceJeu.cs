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
    public partial class ExerciceJeu : Form
    {
        //ATTRIBUTS
        int imageNullIndex;
        List<Bitmap> lstOriginalPictureList = new List<Bitmap>();
  




        /// <summary>
        /// Permet de remplir les box aléatoirement
        /// </summary>        
        private void RandomForShuffle()
        {

            lstOriginalPictureList.Clear();
            //add ressource
            lstOriginalPictureList.Add(Properties.Resources._1);
            lstOriginalPictureList.Add(Properties.Resources._2);
            lstOriginalPictureList.Add(Properties.Resources._3);
            lstOriginalPictureList.Add(Properties.Resources._4);
            lstOriginalPictureList.Add(Properties.Resources._5);
            lstOriginalPictureList.Add(Properties.Resources._6);
            lstOriginalPictureList.Add(Properties.Resources._7);
            lstOriginalPictureList.Add(Properties.Resources._8);
            lstOriginalPictureList.Add(Properties.Resources._null);



            var random = new Random();      
            int index;

            for(int i = 0; i < 9; i++)
            {
                index = random.Next(lstOriginalPictureList.Count);
                ((PictureBox)pictbPuzzelBox.Controls[i]).Image = lstOriginalPictureList[index]; 
                if(index == 9) { imageNullIndex = i; }
                lstOriginalPictureList.RemoveAt(index);
            }



        }

        /// <summary>
        /// Permet les déplacements des box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SlideImageBox(object sender, EventArgs e)
        {
            int imageBoxIndex = pictbPuzzelBox.Controls.IndexOf(sender as Control);
            if (imageNullIndex != imageBoxIndex)
            {
                List<int> slidePosition = new List<int>(new int[] { ((imageBoxIndex % 3 == 0) ? -1 : imageBoxIndex - 1), imageBoxIndex - 3, (imageBoxIndex % 3 == 2) ? -1 : imageBoxIndex + 1, imageBoxIndex + 3 });
                if (slidePosition.Contains(imageNullIndex))
                {
                    ((PictureBox)pictbPuzzelBox.Controls[imageNullIndex]).Image = ((PictureBox)pictbPuzzelBox.Controls[imageBoxIndex]).Image;
                    ((PictureBox)pictbPuzzelBox.Controls[imageBoxIndex]).Image = Properties.Resources._null;
                    imageNullIndex = imageBoxIndex;
                    /*if (Winer())
                    {
                        (pictbPuzzelBox.Controls[8] as PictureBox).Image = Properties.Resources._9;
                        MessageBox.Show("Gagné !!!", "Lapin Taquin");
                        
                    }*/
                }
            }
        }

        public ExerciceJeu()
        {
            InitializeComponent();  
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        // click button shuffle
        private void btShuffle_Click(object sender, EventArgs e)
        {
            RandomForShuffle();
        }

        /// <summary>
        /// Permet de fermer la fenetre à l'issue d'une question oui ou non
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExerciceJeu_FormClosed(Object sender, FormClosingEventArgs e)
        {
            DialogResult YorN = MessageBox.Show("Etes vous sûr de vouloir quitter ?", "Lapin Taquin", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (YorN == DialogResult.No) e.Cancel = true;
            if (YorN == DialogResult.Yes) Environment.Exit(0);
        }

        private void btQuit_Click(object sender, EventArgs e)
        {
            ExerciceJeu_FormClosed(sender, e as FormClosingEventArgs);
        }

        private void ExerciceJeu_Load(object sender, EventArgs e)
        {
            RandomForShuffle();
        }

        //Change le bouton pause en résume
        private void btPauseOrbtResume(object sender, EventArgs e)
        {
            if (btPause.Text == "Pause")
            {
                btPause.Text = "Resume";
            }
            else
            {
                btPause.Text = "Pause";
            }
        }

        /*bool Winer()
        {

            int i;
            for (i = 0; i < 8; i++)
            {
                if ((pictbPuzzelBox.Controls[i] as PictureBox).Image != lstOriginalPictureList[i]) break;
            }
            if (i == 8) return true;
            else return false;
        }*/
    }
}
