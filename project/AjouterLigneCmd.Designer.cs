namespace project
{
    partial class AjoutLignecmd
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
            this.ProduitComboAjoutLigCmd = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ProduitAjoutLigne = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TypeTextBoxAjoutLigCmd = new System.Windows.Forms.TextBox();
            this.DesTextBoxAjoutLig = new System.Windows.Forms.TextBox();
            this.QuantiteTextBoxAjoutLigcmd = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.PrixTextBoxAjoutLigCmd = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.AnnulerAjoutLigCmdbtn = new System.Windows.Forms.Button();
            this.ValiderAjoutLigCmdbtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.PrixTextBoxAjoutLigCmd);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.QuantiteTextBoxAjoutLigcmd);
            this.groupBox1.Controls.Add(this.DesTextBoxAjoutLig);
            this.groupBox1.Controls.Add(this.TypeTextBoxAjoutLigCmd);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.ProduitComboAjoutLigCmd);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.ProduitAjoutLigne);
            this.groupBox1.Location = new System.Drawing.Point(11, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(416, 105);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // ProduitComboAjoutLigCmd
            // 
            this.ProduitComboAjoutLigCmd.FormattingEnabled = true;
            this.ProduitComboAjoutLigCmd.Location = new System.Drawing.Point(81, 18);
            this.ProduitComboAjoutLigCmd.Name = "ProduitComboAjoutLigCmd";
            this.ProduitComboAjoutLigCmd.Size = new System.Drawing.Size(137, 21);
            this.ProduitComboAjoutLigCmd.TabIndex = 3;
            this.ProduitComboAjoutLigCmd.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 77);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Quantité";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Désingnation";
            // 
            // ProduitAjoutLigne
            // 
            this.ProduitAjoutLigne.AutoSize = true;
            this.ProduitAjoutLigne.Location = new System.Drawing.Point(10, 22);
            this.ProduitAjoutLigne.Name = "ProduitAjoutLigne";
            this.ProduitAjoutLigne.Size = new System.Drawing.Size(40, 13);
            this.ProduitAjoutLigne.TabIndex = 0;
            this.ProduitAjoutLigne.Text = "Produit";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(232, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "type";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // TypeTextBoxAjoutLigCmd
            // 
            this.TypeTextBoxAjoutLigCmd.Location = new System.Drawing.Point(265, 19);
            this.TypeTextBoxAjoutLigCmd.Name = "TypeTextBoxAjoutLigCmd";
            this.TypeTextBoxAjoutLigCmd.Size = new System.Drawing.Size(134, 20);
            this.TypeTextBoxAjoutLigCmd.TabIndex = 5;
            // 
            // DesTextBoxAjoutLig
            // 
            this.DesTextBoxAjoutLig.Location = new System.Drawing.Point(81, 45);
            this.DesTextBoxAjoutLig.Name = "DesTextBoxAjoutLig";
            this.DesTextBoxAjoutLig.Size = new System.Drawing.Size(318, 20);
            this.DesTextBoxAjoutLig.TabIndex = 6;
            // 
            // QuantiteTextBoxAjoutLigcmd
            // 
            this.QuantiteTextBoxAjoutLigcmd.Location = new System.Drawing.Point(81, 70);
            this.QuantiteTextBoxAjoutLigcmd.Name = "QuantiteTextBoxAjoutLigcmd";
            this.QuantiteTextBoxAjoutLigcmd.Size = new System.Drawing.Size(124, 20);
            this.QuantiteTextBoxAjoutLigcmd.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(218, 73);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Prix";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // PrixTextBoxAjoutLigCmd
            // 
            this.PrixTextBoxAjoutLigCmd.Location = new System.Drawing.Point(248, 70);
            this.PrixTextBoxAjoutLigCmd.Name = "PrixTextBoxAjoutLigCmd";
            this.PrixTextBoxAjoutLigCmd.Size = new System.Drawing.Size(99, 20);
            this.PrixTextBoxAjoutLigCmd.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ValiderAjoutLigCmdbtn);
            this.groupBox2.Controls.Add(this.AnnulerAjoutLigCmdbtn);
            this.groupBox2.Location = new System.Drawing.Point(11, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(416, 53);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // AnnulerAjoutLigCmdbtn
            // 
            this.AnnulerAjoutLigCmdbtn.Location = new System.Drawing.Point(299, 10);
            this.AnnulerAjoutLigCmdbtn.Name = "AnnulerAjoutLigCmdbtn";
            this.AnnulerAjoutLigCmdbtn.Size = new System.Drawing.Size(75, 37);
            this.AnnulerAjoutLigCmdbtn.TabIndex = 0;
            this.AnnulerAjoutLigCmdbtn.Text = "Annuler";
            this.AnnulerAjoutLigCmdbtn.UseVisualStyleBackColor = true;
            // 
            // ValiderAjoutLigCmdbtn
            // 
            this.ValiderAjoutLigCmdbtn.Location = new System.Drawing.Point(218, 10);
            this.ValiderAjoutLigCmdbtn.Name = "ValiderAjoutLigCmdbtn";
            this.ValiderAjoutLigCmdbtn.Size = new System.Drawing.Size(75, 37);
            this.ValiderAjoutLigCmdbtn.TabIndex = 1;
            this.ValiderAjoutLigCmdbtn.Text = "Valider";
            this.ValiderAjoutLigCmdbtn.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(364, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(22, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "DT";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // AjoutLignecmd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 193);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AjoutLignecmd";
            this.Text = "Ajouter une nouvelle ligne commande";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox ProduitComboAjoutLigCmd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label ProduitAjoutLigne;
        private System.Windows.Forms.TextBox PrixTextBoxAjoutLigCmd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox QuantiteTextBoxAjoutLigcmd;
        private System.Windows.Forms.TextBox DesTextBoxAjoutLig;
        private System.Windows.Forms.TextBox TypeTextBoxAjoutLigCmd;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button ValiderAjoutLigCmdbtn;
        private System.Windows.Forms.Button AnnulerAjoutLigCmdbtn;
    }
}