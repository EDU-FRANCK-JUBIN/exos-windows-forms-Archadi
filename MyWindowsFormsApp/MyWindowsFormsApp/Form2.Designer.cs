namespace MyWindowsFormsApp
{
    partial class Form2
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
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Label");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Button");
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Checkbox");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Root", new System.Windows.Forms.TreeNode[] {
            treeNode9,
            treeNode10,
            treeNode11});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lstCity = new System.Windows.Forms.ListBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbFemale = new System.Windows.Forms.RadioButton();
            this.chkC = new System.Windows.Forms.CheckBox();
            this.chkASP = new System.Windows.Forms.CheckBox();
            this.btSubmit = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbAddress);
            this.groupBox1.Controls.Add(this.tbName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(27, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(327, 171);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Details";
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(113, 75);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(100, 20);
            this.tbAddress.TabIndex = 3;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(108, 24);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(100, 20);
            this.tbName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // lstCity
            // 
            this.lstCity.FormattingEnabled = true;
            this.lstCity.Items.AddRange(new object[] {
            "Mumbai",
            "Bengalore",
            "Hydrebad"});
            this.lstCity.Location = new System.Drawing.Point(27, 275);
            this.lstCity.Name = "lstCity";
            this.lstCity.Size = new System.Drawing.Size(120, 95);
            this.lstCity.TabIndex = 1;
            this.lstCity.SelectedIndexChanged += new System.EventHandler(this.lstCity_SelectedIndexChanged);
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Location = new System.Drawing.Point(444, 72);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(48, 17);
            this.rbMale.TabIndex = 2;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "Male";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbFemale
            // 
            this.rbFemale.AutoSize = true;
            this.rbFemale.Location = new System.Drawing.Point(444, 126);
            this.rbFemale.Name = "rbFemale";
            this.rbFemale.Size = new System.Drawing.Size(59, 17);
            this.rbFemale.TabIndex = 3;
            this.rbFemale.TabStop = true;
            this.rbFemale.Text = "Female";
            this.rbFemale.UseVisualStyleBackColor = true;
            // 
            // chkC
            // 
            this.chkC.AutoSize = true;
            this.chkC.Location = new System.Drawing.Point(408, 247);
            this.chkC.Name = "chkC";
            this.chkC.Size = new System.Drawing.Size(40, 17);
            this.chkC.TabIndex = 4;
            this.chkC.Text = "C#";
            this.chkC.UseVisualStyleBackColor = true;
            // 
            // chkASP
            // 
            this.chkASP.AutoSize = true;
            this.chkASP.Location = new System.Drawing.Point(408, 300);
            this.chkASP.Name = "chkASP";
            this.chkASP.Size = new System.Drawing.Size(47, 17);
            this.chkASP.TabIndex = 5;
            this.chkASP.Text = "ASP";
            this.chkASP.UseVisualStyleBackColor = true;
            // 
            // btSubmit
            // 
            this.btSubmit.Location = new System.Drawing.Point(408, 346);
            this.btSubmit.Name = "btSubmit";
            this.btSubmit.Size = new System.Drawing.Size(75, 23);
            this.btSubmit.TabIndex = 6;
            this.btSubmit.Text = "Submit";
            this.btSubmit.UseVisualStyleBackColor = true;
            this.btSubmit.Click += new System.EventHandler(this.btSubmit_Click);
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(607, 97);
            this.treeView1.Name = "treeView1";
            treeNode9.Name = "Nœud1";
            treeNode9.Text = "Label";
            treeNode10.Name = "Nœud2";
            treeNode10.Text = "Button";
            treeNode11.Name = "Nœud3";
            treeNode11.Text = "Checkbox";
            treeNode12.Name = "Nœud0";
            treeNode12.Text = "Root";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode12});
            this.treeView1.Size = new System.Drawing.Size(121, 97);
            this.treeView1.TabIndex = 7;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(591, 266);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(176, 104);
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btSubmit);
            this.Controls.Add(this.chkASP);
            this.Controls.Add(this.chkC);
            this.Controls.Add(this.rbFemale);
            this.Controls.Add(this.rbMale);
            this.Controls.Add(this.lstCity);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ListBox lstCity;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbFemale;
        private System.Windows.Forms.CheckBox chkC;
        private System.Windows.Forms.CheckBox chkASP;
        private System.Windows.Forms.Button btSubmit;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}