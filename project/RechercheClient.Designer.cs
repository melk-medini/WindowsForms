namespace project
{
    partial class RechercheClient
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
            this.ClientRechClient = new System.Windows.Forms.Label();
            this.RueRechClient = new System.Windows.Forms.Label();
            this.VilleRechClient = new System.Windows.Forms.Label();
            this.CodePostalRechClient = new System.Windows.Forms.Label();
            this.ClientTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.RueTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.VilleTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.CodePostalTextBoxRechClient = new System.Windows.Forms.TextBox();
            this.ClientExbtn = new System.Windows.Forms.Button();
            this.AnnulerRechClientbtn = new System.Windows.Forms.Button();
            this.ValiderRechClientbtn = new System.Windows.Forms.Button();
            this.dataRechClient = new System.Windows.Forms.DataGridView();
            this.Client = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ville = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CodePostal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telephone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RechClient = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).BeginInit();
            this.SuspendLayout();
            // 
            // ClientRechClient
            // 
            this.ClientRechClient.AutoSize = true;
            this.ClientRechClient.Location = new System.Drawing.Point(33, 104);
            this.ClientRechClient.Name = "ClientRechClient";
            this.ClientRechClient.Size = new System.Drawing.Size(33, 13);
            this.ClientRechClient.TabIndex = 0;
            this.ClientRechClient.Text = "Client";
            // 
            // RueRechClient
            // 
            this.RueRechClient.AutoSize = true;
            this.RueRechClient.Location = new System.Drawing.Point(39, 140);
            this.RueRechClient.Name = "RueRechClient";
            this.RueRechClient.Size = new System.Drawing.Size(27, 13);
            this.RueRechClient.TabIndex = 1;
            this.RueRechClient.Text = "Rue";
            this.RueRechClient.Click += new System.EventHandler(this.label2_Click);
            // 
            // VilleRechClient
            // 
            this.VilleRechClient.AutoSize = true;
            this.VilleRechClient.Location = new System.Drawing.Point(40, 176);
            this.VilleRechClient.Name = "VilleRechClient";
            this.VilleRechClient.Size = new System.Drawing.Size(26, 13);
            this.VilleRechClient.TabIndex = 2;
            this.VilleRechClient.Text = "Ville";
            this.VilleRechClient.Click += new System.EventHandler(this.label3_Click);
            // 
            // CodePostalRechClient
            // 
            this.CodePostalRechClient.AutoSize = true;
            this.CodePostalRechClient.Location = new System.Drawing.Point(2, 207);
            this.CodePostalRechClient.Name = "CodePostalRechClient";
            this.CodePostalRechClient.Size = new System.Drawing.Size(64, 13);
            this.CodePostalRechClient.TabIndex = 3;
            this.CodePostalRechClient.Text = "Code Postal";
            this.CodePostalRechClient.Click += new System.EventHandler(this.label4_Click);
            // 
            // ClientTextBoxRechClient
            // 
            this.ClientTextBoxRechClient.Location = new System.Drawing.Point(72, 100);
            this.ClientTextBoxRechClient.Name = "ClientTextBoxRechClient";
            this.ClientTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.ClientTextBoxRechClient.TabIndex = 4;
            // 
            // RueTextBoxRechClient
            // 
            this.RueTextBoxRechClient.Location = new System.Drawing.Point(72, 137);
            this.RueTextBoxRechClient.Name = "RueTextBoxRechClient";
            this.RueTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.RueTextBoxRechClient.TabIndex = 5;
            // 
            // VilleTextBoxRechClient
            // 
            this.VilleTextBoxRechClient.Location = new System.Drawing.Point(72, 173);
            this.VilleTextBoxRechClient.Name = "VilleTextBoxRechClient";
            this.VilleTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.VilleTextBoxRechClient.TabIndex = 6;
            // 
            // CodePostalTextBoxRechClient
            // 
            this.CodePostalTextBoxRechClient.Location = new System.Drawing.Point(72, 204);
            this.CodePostalTextBoxRechClient.Name = "CodePostalTextBoxRechClient";
            this.CodePostalTextBoxRechClient.Size = new System.Drawing.Size(100, 20);
            this.CodePostalTextBoxRechClient.TabIndex = 7;
            // 
            // ClientExbtn
            // 
            this.ClientExbtn.Location = new System.Drawing.Point(722, 178);
            this.ClientExbtn.Name = "ClientExbtn";
            this.ClientExbtn.Size = new System.Drawing.Size(75, 46);
            this.ClientExbtn.TabIndex = 8;
            this.ClientExbtn.Tag = "Client in";
            this.ClientExbtn.Text = "Client inexistant";
            this.ClientExbtn.UseVisualStyleBackColor = true;
            this.ClientExbtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // AnnulerRechClientbtn
            // 
            this.AnnulerRechClientbtn.Location = new System.Drawing.Point(722, 123);
            this.AnnulerRechClientbtn.Name = "AnnulerRechClientbtn";
            this.AnnulerRechClientbtn.Size = new System.Drawing.Size(75, 46);
            this.AnnulerRechClientbtn.TabIndex = 9;
            this.AnnulerRechClientbtn.Text = "Annuler";
            this.AnnulerRechClientbtn.UseVisualStyleBackColor = true;
            // 
            // ValiderRechClientbtn
            // 
            this.ValiderRechClientbtn.Location = new System.Drawing.Point(722, 71);
            this.ValiderRechClientbtn.Name = "ValiderRechClientbtn";
            this.ValiderRechClientbtn.Size = new System.Drawing.Size(75, 46);
            this.ValiderRechClientbtn.TabIndex = 10;
            this.ValiderRechClientbtn.Text = "Valider\r\n";
            this.ValiderRechClientbtn.UseVisualStyleBackColor = true;
            // 
            // dataRechClient
            // 
            this.dataRechClient.AllowUserToAddRows = false;
            this.dataRechClient.AllowUserToDeleteRows = false;
            this.dataRechClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataRechClient.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Client,
            this.Rue,
            this.Ville,
            this.CodePostal,
            this.Telephone});
            this.dataRechClient.Location = new System.Drawing.Point(178, 12);
            this.dataRechClient.Name = "dataRechClient";
            this.dataRechClient.ReadOnly = true;
            this.dataRechClient.Size = new System.Drawing.Size(538, 393);
            this.dataRechClient.TabIndex = 11;
            this.dataRechClient.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Client
            // 
            this.Client.HeaderText = "Clinet";
            this.Client.Name = "Client";
            this.Client.ReadOnly = true;
            // 
            // Rue
            // 
            this.Rue.HeaderText = "Rue";
            this.Rue.Name = "Rue";
            this.Rue.ReadOnly = true;
            // 
            // Ville
            // 
            this.Ville.HeaderText = "Ville";
            this.Ville.Name = "Ville";
            this.Ville.ReadOnly = true;
            // 
            // CodePostal
            // 
            this.CodePostal.HeaderText = "Code Postal";
            this.CodePostal.Name = "CodePostal";
            this.CodePostal.ReadOnly = true;
            // 
            // Telephone
            // 
            this.Telephone.HeaderText = "Télléphone";
            this.Telephone.Name = "Telephone";
            this.Telephone.ReadOnly = true;
            // 
            // RechClient
            // 
            this.RechClient.AutoSize = true;
            this.RechClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RechClient.Location = new System.Drawing.Point(24, 52);
            this.RechClient.Name = "RechClient";
            this.RechClient.Size = new System.Drawing.Size(132, 17);
            this.RechClient.TabIndex = 12;
            this.RechClient.Text = "Recherche Client";
            this.RechClient.Click += new System.EventHandler(this.RechClient_Click);
            // 
            // RechercheClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RechClient);
            this.Controls.Add(this.dataRechClient);
            this.Controls.Add(this.ValiderRechClientbtn);
            this.Controls.Add(this.AnnulerRechClientbtn);
            this.Controls.Add(this.ClientExbtn);
            this.Controls.Add(this.CodePostalTextBoxRechClient);
            this.Controls.Add(this.VilleTextBoxRechClient);
            this.Controls.Add(this.RueTextBoxRechClient);
            this.Controls.Add(this.ClientTextBoxRechClient);
            this.Controls.Add(this.CodePostalRechClient);
            this.Controls.Add(this.VilleRechClient);
            this.Controls.Add(this.RueRechClient);
            this.Controls.Add(this.ClientRechClient);
            this.Name = "RechercheClient";
            this.Text = "RechercheClient";
            ((System.ComponentModel.ISupportInitialize)(this.dataRechClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ClientRechClient;
        private System.Windows.Forms.Label RueRechClient;
        private System.Windows.Forms.Label VilleRechClient;
        private System.Windows.Forms.Label CodePostalRechClient;
        private System.Windows.Forms.TextBox ClientTextBoxRechClient;
        private System.Windows.Forms.TextBox RueTextBoxRechClient;
        private System.Windows.Forms.TextBox VilleTextBoxRechClient;
        private System.Windows.Forms.TextBox CodePostalTextBoxRechClient;
        private System.Windows.Forms.Button ClientExbtn;
        private System.Windows.Forms.Button AnnulerRechClientbtn;
        private System.Windows.Forms.Button ValiderRechClientbtn;
        private System.Windows.Forms.DataGridView dataRechClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rue;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ville;
        private System.Windows.Forms.DataGridViewTextBoxColumn CodePostal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telephone;
        private System.Windows.Forms.Label RechClient;
    }
}