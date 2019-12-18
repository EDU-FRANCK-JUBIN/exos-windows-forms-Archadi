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
    public partial class MainForm : Form
    {
        List<Form> childs = new List<Form>();

        public MainForm()
        {
            InitializeComponent();
        }

        public string toSend()
        {
            return tbSend.Text;
        }

        public void toRecive(string txt)
        {
            tbReceive.Text = txt;
        }

        int getChildIndexOfName(string name)
        {
            int index = -1;

            foreach (var chld in childs)
            {
                if (chld.Name == name)
                {
                    index = childs.IndexOf(chld);
                    break;
                }
            }

            return index;
        }

        private void btDialogForm_Click(object sender, EventArgs e)
        {
            DialogForm dialogForm = new DialogForm();
            dialogForm.ShowDialog();
        }

        private void btSend_Click(object sender, EventArgs e)
        {
            int idx = getChildIndexOfName("Level2Form");
            if (getChildIndexOfName("Level2Form") != -1)
            {
                Level2Form level2Form = (Level2Form)childs[idx];
                level2Form.toRecive(this.toSend());
            }
        }

        private void btReceive_Click(object sender, EventArgs e)
        {
            int idx = getChildIndexOfName("Level2Form");
            if (getChildIndexOfName("Level2Form") != -1)
            {
                Level2Form level2Form = (Level2Form)childs[idx];
                tbReceive.Text = level2Form.toSend();
            }
        }


        private void btLevel2_Click(object sender, EventArgs e)
        {
            Level2Form level2Form = new Level2Form() { Owner = this };
            childs.Add(level2Form);
            level2Form.Show();
        }

        private void btMdiForm_Click(object sender, EventArgs e)
        {
            MdiForm mdiForm = new MdiForm() { Owner = this };
            mdiForm.Show();
        }

        private void btPanelForm_Click(object sender, EventArgs e)
        {
            PanelForm panelForm = new PanelForm();
            panelForm.TopLevel = false;
            panelForm.AutoScroll = true;
            this.panForm.Controls.Add(panelForm);
            panelForm.Show();
        }
    }
}
