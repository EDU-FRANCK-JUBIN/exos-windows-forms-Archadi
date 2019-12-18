namespace PckQrCoder
{
    partial class Itext7Form
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
            this.btGeneratPDF = new System.Windows.Forms.Button();
            this.rtbWriteText = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btGeneratPDF
            // 
            this.btGeneratPDF.Location = new System.Drawing.Point(12, 389);
            this.btGeneratPDF.Name = "btGeneratPDF";
            this.btGeneratPDF.Size = new System.Drawing.Size(136, 36);
            this.btGeneratPDF.TabIndex = 1;
            this.btGeneratPDF.Text = "Générer en PDF";
            this.btGeneratPDF.UseVisualStyleBackColor = true;
            this.btGeneratPDF.Click += new System.EventHandler(this.btGeneratPDF_Click);
            // 
            // rtbWriteText
            // 
            this.rtbWriteText.Location = new System.Drawing.Point(12, 12);
            this.rtbWriteText.Name = "rtbWriteText";
            this.rtbWriteText.Size = new System.Drawing.Size(776, 353);
            this.rtbWriteText.TabIndex = 2;
            this.rtbWriteText.Text = "";
            // 
            // Itext7Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbWriteText);
            this.Controls.Add(this.btGeneratPDF);
            this.Name = "Itext7Form";
            this.Text = "itext7Form";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btGeneratPDF;
        private System.Windows.Forms.RichTextBox rtbWriteText;
    }
}