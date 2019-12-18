namespace MyWindowsFormsApp
{
    partial class Personnes_Form
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
            this.components = new System.ComponentModel.Container();
            this.personneBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.personneBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.personneBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prenomDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naissanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listBox1 = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // personneBindingSource
            // 
            this.personneBindingSource.DataSource = typeof(MyWindowsFormsApp.Personne);
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.personneBindingSource, "Prenom", true));
            this.textBox1.Location = new System.Drawing.Point(288, 257);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // personneBindingSource1
            // 
            this.personneBindingSource1.DataSource = typeof(MyWindowsFormsApp.Personne);
            // 
            // personneBindingSource2
            // 
            this.personneBindingSource2.DataSource = typeof(MyWindowsFormsApp.Personne);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomDataGridViewTextBoxColumn,
            this.prenomDataGridViewTextBoxColumn,
            this.naissanceDataGridViewTextBoxColumn,
            this.ageDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.personneBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(696, 150);
            this.dataGridView1.TabIndex = 3;
            // 
            // nomDataGridViewTextBoxColumn
            // 
            this.nomDataGridViewTextBoxColumn.DataPropertyName = "Nom";
            this.nomDataGridViewTextBoxColumn.HeaderText = "Nom";
            this.nomDataGridViewTextBoxColumn.Name = "nomDataGridViewTextBoxColumn";
            // 
            // prenomDataGridViewTextBoxColumn
            // 
            this.prenomDataGridViewTextBoxColumn.DataPropertyName = "Prenom";
            this.prenomDataGridViewTextBoxColumn.HeaderText = "Prenom";
            this.prenomDataGridViewTextBoxColumn.Name = "prenomDataGridViewTextBoxColumn";
            // 
            // naissanceDataGridViewTextBoxColumn
            // 
            this.naissanceDataGridViewTextBoxColumn.DataPropertyName = "Naissance";
            this.naissanceDataGridViewTextBoxColumn.HeaderText = "Naissance";
            this.naissanceDataGridViewTextBoxColumn.Name = "naissanceDataGridViewTextBoxColumn";
            // 
            // ageDataGridViewTextBoxColumn
            // 
            this.ageDataGridViewTextBoxColumn.DataPropertyName = "Age";
            this.ageDataGridViewTextBoxColumn.HeaderText = "Age";
            this.ageDataGridViewTextBoxColumn.Name = "ageDataGridViewTextBoxColumn";
            // 
            // listBox1
            // 
            this.listBox1.DataSource = this.personneBindingSource;
            this.listBox1.DisplayMember = "Nom";
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(12, 257);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 95);
            this.listBox1.TabIndex = 4;
            // 
            // Personnes_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Name = "Personnes_Form";
            this.Text = "Personnes_Form";
            this.Load += new System.EventHandler(this.Personnes_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.personneBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.BindingSource personneBindingSource;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource personneBindingSource1;
        private System.Windows.Forms.BindingSource personneBindingSource2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn prenomDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn naissanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ageDataGridViewTextBoxColumn;
        private System.Windows.Forms.ListBox listBox1;
    }
}