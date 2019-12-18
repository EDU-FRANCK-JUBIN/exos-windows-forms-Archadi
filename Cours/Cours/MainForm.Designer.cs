namespace Cours
{
    partial class MainForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.btDialogForm = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReceive = new System.Windows.Forms.TextBox();
            this.btSend = new System.Windows.Forms.Button();
            this.btReceive = new System.Windows.Forms.Button();
            this.btLevel2Form = new System.Windows.Forms.Button();
            this.btMdiForm = new System.Windows.Forms.Button();
            this.btPanelForm = new System.Windows.Forms.Button();
            this.panForm = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // btDialogForm
            // 
            this.btDialogForm.Location = new System.Drawing.Point(12, 54);
            this.btDialogForm.Name = "btDialogForm";
            this.btDialogForm.Size = new System.Drawing.Size(201, 82);
            this.btDialogForm.TabIndex = 0;
            this.btDialogForm.Text = "DIALOG FORM";
            this.btDialogForm.UseVisualStyleBackColor = true;
            this.btDialogForm.Click += new System.EventHandler(this.btDialogForm_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "MAIN FORM";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(857, 37);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(300, 116);
            this.tbSend.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(854, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "TO SEND";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(854, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "TO RECEIVE";
            // 
            // tbReceive
            // 
            this.tbReceive.Location = new System.Drawing.Point(857, 273);
            this.tbReceive.Multiline = true;
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(300, 116);
            this.tbReceive.TabIndex = 4;
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(857, 160);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 6;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(857, 395);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(75, 23);
            this.btReceive.TabIndex = 7;
            this.btReceive.Text = "RECEIVE";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // btLevel2Form
            // 
            this.btLevel2Form.Location = new System.Drawing.Point(12, 143);
            this.btLevel2Form.Name = "btLevel2Form";
            this.btLevel2Form.Size = new System.Drawing.Size(201, 82);
            this.btLevel2Form.TabIndex = 8;
            this.btLevel2Form.Text = "LEVEL 2 FORM";
            this.btLevel2Form.UseVisualStyleBackColor = true;
            this.btLevel2Form.Click += new System.EventHandler(this.btLevel2_Click);
            // 
            // btMdiForm
            // 
            this.btMdiForm.Location = new System.Drawing.Point(12, 231);
            this.btMdiForm.Name = "btMdiForm";
            this.btMdiForm.Size = new System.Drawing.Size(201, 82);
            this.btMdiForm.TabIndex = 9;
            this.btMdiForm.Text = "MDI FORM";
            this.btMdiForm.UseVisualStyleBackColor = true;
            this.btMdiForm.Click += new System.EventHandler(this.btMdiForm_Click);
            // 
            // btPanelForm
            // 
            this.btPanelForm.Location = new System.Drawing.Point(12, 319);
            this.btPanelForm.Name = "btPanelForm";
            this.btPanelForm.Size = new System.Drawing.Size(201, 82);
            this.btPanelForm.TabIndex = 10;
            this.btPanelForm.Text = "PANEL FORM";
            this.btPanelForm.UseVisualStyleBackColor = true;
            this.btPanelForm.Click += new System.EventHandler(this.btPanelForm_Click);
            // 
            // panForm
            // 
            this.panForm.Location = new System.Drawing.Point(238, 54);
            this.panForm.Name = "panForm";
            this.panForm.Size = new System.Drawing.Size(585, 347);
            this.panForm.TabIndex = 11;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.panForm);
            this.Controls.Add(this.btPanelForm);
            this.Controls.Add(this.btMdiForm);
            this.Controls.Add(this.btLevel2Form);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReceive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btDialogForm);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btDialogForm;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReceive;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.Button btLevel2Form;
        private System.Windows.Forms.Button btMdiForm;
        private System.Windows.Forms.Button btPanelForm;
        private System.Windows.Forms.Panel panForm;
    }
}

