namespace FormExosPackages
{
    partial class MainForm
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
            this.btQRCoderForm = new System.Windows.Forms.Button();
            this.btItext7Form = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btQRCoderForm
            // 
            this.btQRCoderForm.Location = new System.Drawing.Point(12, 12);
            this.btQRCoderForm.Name = "btQRCoderForm";
            this.btQRCoderForm.Size = new System.Drawing.Size(131, 69);
            this.btQRCoderForm.TabIndex = 0;
            this.btQRCoderForm.Text = "QRCoderForm";
            this.btQRCoderForm.UseVisualStyleBackColor = true;
            this.btQRCoderForm.Click += new System.EventHandler(this.btQRCoderForm_Click);
            // 
            // btItext7Form
            // 
            this.btItext7Form.Location = new System.Drawing.Point(12, 87);
            this.btItext7Form.Name = "btItext7Form";
            this.btItext7Form.Size = new System.Drawing.Size(131, 69);
            this.btItext7Form.TabIndex = 1;
            this.btItext7Form.Text = "Itext7Form";
            this.btItext7Form.UseVisualStyleBackColor = true;
            this.btItext7Form.Click += new System.EventHandler(this.btItext7Form_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btItext7Form);
            this.Controls.Add(this.btQRCoderForm);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btQRCoderForm;
        private System.Windows.Forms.Button btItext7Form;
    }
}