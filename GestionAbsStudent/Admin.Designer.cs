
namespace GestionAbsStudent
{
    partial class Admin
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
            this.btnAddCompte = new System.Windows.Forms.Button();
            this.btnUpdateCompte = new System.Windows.Forms.Button();
            this.btnDeleteCompte = new System.Windows.Forms.Button();
            this.btnSaveCompte = new System.Windows.Forms.Button();
            this.listAgent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inputAgentPseudo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.inputAgentPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.listRole = new System.Windows.Forms.ComboBox();
            this.dgvCompte = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOut = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnOut);
            this.groupBox1.Controls.Add(this.btnSaveCompte);
            this.groupBox1.Controls.Add(this.btnDeleteCompte);
            this.groupBox1.Controls.Add(this.btnUpdateCompte);
            this.groupBox1.Controls.Add(this.btnAddCompte);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(229, 627);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Les operations";
            // 
            // btnAddCompte
            // 
            this.btnAddCompte.Location = new System.Drawing.Point(37, 75);
            this.btnAddCompte.Name = "btnAddCompte";
            this.btnAddCompte.Size = new System.Drawing.Size(151, 38);
            this.btnAddCompte.TabIndex = 0;
            this.btnAddCompte.Text = "Nouveau Compte";
            this.btnAddCompte.UseVisualStyleBackColor = true;
            this.btnAddCompte.Click += new System.EventHandler(this.btnAddCompte_Click);
            // 
            // btnUpdateCompte
            // 
            this.btnUpdateCompte.Location = new System.Drawing.Point(37, 120);
            this.btnUpdateCompte.Name = "btnUpdateCompte";
            this.btnUpdateCompte.Size = new System.Drawing.Size(151, 38);
            this.btnUpdateCompte.TabIndex = 1;
            this.btnUpdateCompte.Text = "Modifier";
            this.btnUpdateCompte.UseVisualStyleBackColor = true;
            this.btnUpdateCompte.Click += new System.EventHandler(this.btnUpdateCompte_Click);
            // 
            // btnDeleteCompte
            // 
            this.btnDeleteCompte.Location = new System.Drawing.Point(37, 164);
            this.btnDeleteCompte.Name = "btnDeleteCompte";
            this.btnDeleteCompte.Size = new System.Drawing.Size(151, 38);
            this.btnDeleteCompte.TabIndex = 2;
            this.btnDeleteCompte.Text = "Supprimer";
            this.btnDeleteCompte.UseVisualStyleBackColor = true;
            this.btnDeleteCompte.Click += new System.EventHandler(this.btnDeleteCompte_Click);
            // 
            // btnSaveCompte
            // 
            this.btnSaveCompte.Location = new System.Drawing.Point(37, 428);
            this.btnSaveCompte.Name = "btnSaveCompte";
            this.btnSaveCompte.Size = new System.Drawing.Size(151, 38);
            this.btnSaveCompte.TabIndex = 3;
            this.btnSaveCompte.Text = "Enregister ";
            this.btnSaveCompte.UseVisualStyleBackColor = true;
            this.btnSaveCompte.Click += new System.EventHandler(this.btnSaveCompte_Click);
            // 
            // listAgent
            // 
            this.listAgent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listAgent.FormattingEnabled = true;
            this.listAgent.Location = new System.Drawing.Point(509, 57);
            this.listAgent.Name = "listAgent";
            this.listAgent.Size = new System.Drawing.Size(346, 24);
            this.listAgent.TabIndex = 1;
            this.listAgent.SelectedIndexChanged += new System.EventHandler(this.listAgent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(342, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(148, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Selectionner un Agent";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(359, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Saisir un Pseudo";
            // 
            // inputAgentPseudo
            // 
            this.inputAgentPseudo.Location = new System.Drawing.Point(509, 140);
            this.inputAgentPseudo.Name = "inputAgentPseudo";
            this.inputAgentPseudo.Size = new System.Drawing.Size(264, 22);
            this.inputAgentPseudo.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(359, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(128, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Saisir un Password";
            // 
            // inputAgentPassword
            // 
            this.inputAgentPassword.Location = new System.Drawing.Point(509, 193);
            this.inputAgentPassword.Name = "inputAgentPassword";
            this.inputAgentPassword.Size = new System.Drawing.Size(264, 22);
            this.inputAgentPassword.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(359, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Choisir le role";
            // 
            // listRole
            // 
            this.listRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.listRole.FormattingEnabled = true;
            this.listRole.Location = new System.Drawing.Point(509, 245);
            this.listRole.Name = "listRole";
            this.listRole.Size = new System.Drawing.Size(264, 24);
            this.listRole.TabIndex = 8;
            // 
            // dgvCompte
            // 
            this.dgvCompte.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCompte.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompte.Location = new System.Drawing.Point(258, 346);
            this.dgvCompte.Name = "dgvCompte";
            this.dgvCompte.ReadOnly = true;
            this.dgvCompte.RowHeadersWidth = 51;
            this.dgvCompte.RowTemplate.Height = 24;
            this.dgvCompte.Size = new System.Drawing.Size(764, 285);
            this.dgvCompte.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(255, 316);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(114, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "List des comptes";
            // 
            // btnOut
            // 
            this.btnOut.Location = new System.Drawing.Point(37, 481);
            this.btnOut.Name = "btnOut";
            this.btnOut.Size = new System.Drawing.Size(151, 38);
            this.btnOut.TabIndex = 4;
            this.btnOut.Text = "Quitter";
            this.btnOut.UseVisualStyleBackColor = true;
            this.btnOut.Click += new System.EventHandler(this.btnOut_Click);
            // 
            // Admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 643);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvCompte);
            this.Controls.Add(this.listRole);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inputAgentPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.inputAgentPseudo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listAgent);
            this.Controls.Add(this.groupBox1);
            this.Name = "Admin";
            this.Text = "Admin";
            this.Load += new System.EventHandler(this.Admin_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompte)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveCompte;
        private System.Windows.Forms.Button btnDeleteCompte;
        private System.Windows.Forms.Button btnUpdateCompte;
        private System.Windows.Forms.Button btnAddCompte;
        private System.Windows.Forms.ComboBox listAgent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox inputAgentPseudo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox inputAgentPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox listRole;
        private System.Windows.Forms.DataGridView dgvCompte;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnOut;
    }
}