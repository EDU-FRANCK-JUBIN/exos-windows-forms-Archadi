namespace Cours
{
    partial class Level2Form
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
            this.btReceive = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReceive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btMyParent
            // 
            this.btMyParent.Location = new System.Drawing.Point(210, 14);
            this.btMyParent.Name = "btMyParent";
            this.btMyParent.Size = new System.Drawing.Size(129, 23);
            this.btMyParent.TabIndex = 20;
            this.btMyParent.Text = "Mon parent";
            this.btMyParent.UseVisualStyleBackColor = true;
            this.btMyParent.Click += new System.EventHandler(this.btMyParent_Click);
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(488, 413);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(75, 23);
            this.btReceive.TabIndex = 19;
            this.btReceive.Text = "RECEIVE";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(488, 178);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 18;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "TO RECEIVE";
            // 
            // tbReceive
            // 
            this.tbReceive.Location = new System.Drawing.Point(488, 292);
            this.tbReceive.Multiline = true;
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(300, 116);
            this.tbReceive.TabIndex = 16;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "TO SEND";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(488, 56);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(300, 116);
            this.tbSend.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "LEVEL2 FORM";
            // 
            // Level2Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btMyParent);
            this.Controls.Add(this.btReceive);
            this.Controls.Add(this.btSend);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbReceive);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbSend);
            this.Controls.Add(this.label1);
            this.Name = "Level2Form";
            this.Text = "Level2Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btMyParent;
        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Label label1;
    }
}