namespace Cours
{
    partial class DialogForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbReceive = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbSend = new System.Windows.Forms.TextBox();
            this.btReceive = new System.Windows.Forms.Button();
            this.btSend = new System.Windows.Forms.Button();
            this.btMyParent = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "DIALOG FORM";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(485, 271);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "TO RECEIVE";
            // 
            // tbReceive
            // 
            this.tbReceive.Location = new System.Drawing.Point(488, 287);
            this.tbReceive.Multiline = true;
            this.tbReceive.Name = "tbReceive";
            this.tbReceive.Size = new System.Drawing.Size(300, 116);
            this.tbReceive.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(485, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "TO SEND";
            // 
            // tbSend
            // 
            this.tbSend.Location = new System.Drawing.Point(488, 51);
            this.tbSend.Multiline = true;
            this.tbSend.Name = "tbSend";
            this.tbSend.Size = new System.Drawing.Size(300, 116);
            this.tbSend.TabIndex = 6;
            // 
            // btReceive
            // 
            this.btReceive.Location = new System.Drawing.Point(488, 408);
            this.btReceive.Name = "btReceive";
            this.btReceive.Size = new System.Drawing.Size(75, 23);
            this.btReceive.TabIndex = 11;
            this.btReceive.Text = "RECEIVE";
            this.btReceive.UseVisualStyleBackColor = true;
            this.btReceive.Click += new System.EventHandler(this.btReceive_Click);
            // 
            // btSend
            // 
            this.btSend.Location = new System.Drawing.Point(488, 173);
            this.btSend.Name = "btSend";
            this.btSend.Size = new System.Drawing.Size(75, 23);
            this.btSend.TabIndex = 10;
            this.btSend.Text = "SEND";
            this.btSend.UseVisualStyleBackColor = true;
            this.btSend.Click += new System.EventHandler(this.btSend_Click);
            // 
            // btMyParent
            // 
            this.btMyParent.Location = new System.Drawing.Point(210, 9);
            this.btMyParent.Name = "btMyParent";
            this.btMyParent.Size = new System.Drawing.Size(129, 23);
            this.btMyParent.TabIndex = 12;
            this.btMyParent.Text = "Mon parent";
            this.btMyParent.UseVisualStyleBackColor = true;
            this.btMyParent.Click += new System.EventHandler(this.btMyParent_Click);
            // 
            // DialogForm
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
            this.Name = "DialogForm";
            this.Text = "DialogForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbReceive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSend;
        private System.Windows.Forms.Button btReceive;
        private System.Windows.Forms.Button btSend;
        private System.Windows.Forms.Button btMyParent;
    }
}