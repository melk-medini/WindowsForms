namespace project
{
    partial class ListeProduits
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.CodeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeProduitDataView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ValiderProduitsbtn = new System.Windows.Forms.Button();
            this.AnnulerProduitsbtn = new System.Windows.Forms.Button();
            this.ProduitInexbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.RechProduitTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.RechProduitTextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 55);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(183, 119);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CodeProduitDataView,
            this.ProduitDataView,
            this.TypeProduitDataView});
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.Location = new System.Drawing.Point(201, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(502, 322);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ProduitInexbtn);
            this.groupBox2.Controls.Add(this.AnnulerProduitsbtn);
            this.groupBox2.Controls.Add(this.ValiderProduitsbtn);
            this.groupBox2.Location = new System.Drawing.Point(709, 94);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(88, 154);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // CodeProduitDataView
            // 
            this.CodeProduitDataView.HeaderText = "Code Produit";
            this.CodeProduitDataView.Name = "CodeProduitDataView";
            this.CodeProduitDataView.ReadOnly = true;
            // 
            // ProduitDataView
            // 
            this.ProduitDataView.HeaderText = "Produit";
            this.ProduitDataView.Name = "ProduitDataView";
            this.ProduitDataView.ReadOnly = true;
            // 
            // TypeProduitDataView
            // 
            this.TypeProduitDataView.HeaderText = "Type Produit";
            this.TypeProduitDataView.Name = "TypeProduitDataView";
            this.TypeProduitDataView.ReadOnly = true;
            // 
            // ValiderProduitsbtn
            // 
            this.ValiderProduitsbtn.Location = new System.Drawing.Point(6, 19);
            this.ValiderProduitsbtn.Name = "ValiderProduitsbtn";
            this.ValiderProduitsbtn.Size = new System.Drawing.Size(75, 35);
            this.ValiderProduitsbtn.TabIndex = 0;
            this.ValiderProduitsbtn.Text = "Valider";
            this.ValiderProduitsbtn.UseVisualStyleBackColor = true;
            // 
            // AnnulerProduitsbtn
            // 
            this.AnnulerProduitsbtn.Location = new System.Drawing.Point(6, 60);
            this.AnnulerProduitsbtn.Name = "AnnulerProduitsbtn";
            this.AnnulerProduitsbtn.Size = new System.Drawing.Size(75, 35);
            this.AnnulerProduitsbtn.TabIndex = 1;
            this.AnnulerProduitsbtn.Text = "Annuler";
            this.AnnulerProduitsbtn.UseVisualStyleBackColor = true;
            // 
            // ProduitInexbtn
            // 
            this.ProduitInexbtn.Location = new System.Drawing.Point(6, 101);
            this.ProduitInexbtn.Name = "ProduitInexbtn";
            this.ProduitInexbtn.Size = new System.Drawing.Size(75, 36);
            this.ProduitInexbtn.TabIndex = 2;
            this.ProduitInexbtn.Text = "Produit inexistant";
            this.ProduitInexbtn.UseVisualStyleBackColor = true;
            this.ProduitInexbtn.Click += new System.EventHandler(this.button3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Designation";
            // 
            // RechProduitTextBox
            // 
            this.RechProduitTextBox.Location = new System.Drawing.Point(75, 55);
            this.RechProduitTextBox.Name = "RechProduitTextBox";
            this.RechProduitTextBox.Size = new System.Drawing.Size(100, 20);
            this.RechProduitTextBox.TabIndex = 1;
            this.RechProduitTextBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // ListeProduits
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "ListeProduits";
            this.Text = "ListeProduits";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodeProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProduitDataView;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeProduitDataView;
        private System.Windows.Forms.Button ProduitInexbtn;
        private System.Windows.Forms.Button AnnulerProduitsbtn;
        private System.Windows.Forms.Button ValiderProduitsbtn;
        private System.Windows.Forms.TextBox RechProduitTextBox;
        private System.Windows.Forms.Label label1;
    }
}