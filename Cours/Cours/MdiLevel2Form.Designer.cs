namespace Cours
{
    partial class MdiLevel2Form
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btMyParent = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMyParent
            // 
            this.btMyParent.Location = new System.Drawing.Point(210, 18);
            this.btMyParent.Name = "btMyParent";
            this.btMyParent.Size = new System.Drawing.Size(129, 23);
            this.btMyParent.TabIndex = 14;
            this.btMyParent.Text = "Mon parent";
            this.btMyParent.UseVisualStyleBackColor = true;
            this.btMyParent.Click += new System.EventHandler(this.btMyParent_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "MDI LEVEL 2 FORM";
            // 
            // MdiLevel2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMyParent);
            this.Controls.Add(this.label1);
            this.Name = "MdiLevel2Form";
            this.Text = "MdiLevel2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMyParent;
        private System.Windows.Forms.Label label1;
    }
}