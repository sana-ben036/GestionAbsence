using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GestionAbsStudent
{
    public partial class Admin : Form
    {
        public Admin()
        {
            InitializeComponent();
        }
        AdoNet Ado;
        private void Admin_Load(object sender, EventArgs e)
        {
            Ado = new AdoNet();
            FillAgent();
            FillCompte();
            FillRole();
            Ado.DtAgent = Ado.Ds.Tables[0];
            Ado.DtAgent.TableName = "Agent";
            Ado.DtCompte = Ado.Ds.Tables[1];
            Ado.DtCompte.TableName = "Compte";
            Ado.DtRole = Ado.Ds.Tables[2];
            Ado.DtRole.TableName = "Role";
            this.dgvCompte.DataSource = Ado.DtCompte;
            this.listAgent.DataSource = Ado.DtAgent;
            this.listAgent.DisplayMember = Ado.DtAgent.Columns[1].ColumnName; // "agent detail"
            this.listAgent.ValueMember = Ado.DtAgent.Columns[0].ColumnName;  //"id"
            this.listRole.DataSource = Ado.DtRole;
            this.listRole.DisplayMember = Ado.DtRole.Columns[1].ColumnName; // "role"
            this.listRole.ValueMember = Ado.DtRole.Columns[0].ColumnName;  //"id"
            this.listAgent.SelectedIndex = -1;
            this.listRole.SelectedIndex = -1;
        }













        private bool CheckInput()
        {
            if (this.inputAgentPseudo.Text.Trim().Equals(string.Empty) ||
               this.inputAgentPassword.Text.Trim().Equals(string.Empty) ||
               (this.listAgent.SelectedIndex < 0) || (this.listRole.SelectedIndex < 0)
               )
                return false;
            return true;

        }

        private void FillAgent()
        {
            string query = string.Empty + "select Id_Agent, Prenom +' '+Nom + ' '+Profil as Agent from Agent  ; ";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Agent");
        }

        private void FillCompte()
        {
            string query = string.Empty + "select * from Compte ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Compte");
        }

        private void FillRole()
        {
            string query = string.Empty + "select * from Role ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Role");
        }

        private void btnAddCompte_Click(object sender, EventArgs e)
        {
            if (CheckInput())
            {
                DataRow Compte = Ado.DtCompte.NewRow();
                
                Compte[1] = this.inputAgentPseudo.Text.Trim();
                Compte[2] = this.inputAgentPassword.Text.Trim();
                Compte[3] = DateTime.Now;
                Compte[4] = this.listAgent.SelectedValue;
                Compte[5] = this.listRole.SelectedValue;
                foreach (DataRow row in Ado.DtCompte.Rows)
                {
                    if(row[4].ToString() == this.listAgent.SelectedValue.ToString())
                    {
                        MessageBox.Show("Cet Agent a déja un compte");
                        return;
                    }
                    
                }
                Ado.DtCompte.Rows.Add(Compte);

                foreach (Control item in Controls) // vider les input
                {
                    if (item is TextBox)
                    {
                        item.Text = string.Empty;
                    }
                    this.listAgent.SelectedIndex = -1;
                    this.listRole.SelectedIndex = -1;
                }


            }
            else
            {
                MessageBox.Show("Il faut remplir toutes les cases!!");
            }

        }

        private void btnDeleteCompte_Click(object sender, EventArgs e)
        {
           
            foreach(DataRow row in Ado.DtCompte.Rows)
            {
                if(row[4].ToString() == this.listAgent.SelectedValue.ToString())
                {
                    DialogResult result = MessageBox.Show("Voullez vous supprimer le compte ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (result == DialogResult.Yes)
                    {
                        row.Delete();
                        MessageBox.Show("le compte est bien supprimé");
                        return;
                    }
                    break;
                }
                MessageBox.Show("le compte est introuvable");
            }
        }
        private void btnUpdateCompte_Click(object sender, EventArgs e)
        {
            if (btnModifier == true)
            {
                int id_Agent = int.Parse(this.listAgent.SelectedValue.ToString());
                foreach (DataRow row in Ado.DtCompte.Rows)
                {
                    if (row[4].ToString() == id_Agent.ToString())
                    {
                        if (CheckInput())
                        {
                            row[1] = this.inputAgentPseudo.Text.Trim();
                            row[2] = this.inputAgentPassword.Text.Trim();
                            row[3] = DateTime.Now;
                            row[4] = this.listAgent.SelectedValue;
                            row[5] = this.listRole.SelectedValue;

                            MessageBox.Show("le compte est bien Modifié");
                        }
                        else
                        {
                            MessageBox.Show("svp modifer les champs");
                        }
                        break;
                    }
                }
            }

        }
        bool btnModifier = false;

        private void listAgent_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnModifier = true;
            if (this.listAgent.SelectedIndex < 0)
            {
                MessageBox.Show("SVP choisir un Agent de la list");
            }
            else
            {
                int id_Agent = int.Parse(this.listAgent.SelectedValue.ToString());

                foreach (DataRow row in Ado.DtCompte.Rows)
                {

                    if (row[4].ToString() == id_Agent.ToString())
                    {

                        this.inputAgentPseudo.Text = row[1].ToString();
                        this.inputAgentPassword.Text = row[2].ToString();
                        this.listRole.SelectedValue = row[5].ToString();
                    }

                }

            }
        }

        private void btnSaveCompte_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommandBuilder builder = new SqlCommandBuilder(Ado.Adapter);
                Ado.Adapter.Update(Ado.Ds, Ado.DtCompte.ToString());
                MessageBox.Show("les modification sur DB est bien enregistées !!!!");


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Voullez vous Quitter ??","Confirmation",MessageBoxButtons.YesNo)== DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
