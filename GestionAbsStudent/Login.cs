using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace GestionAbsStudent
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        AdoNet Ado;
        private void Login_Load(object sender, EventArgs e)
        {
            Ado = new AdoNet();
            FillAdmin();
            FillCompte();
            Ado.DtAdmin = Ado.Ds.Tables[0];
            Ado.DtAdmin.TableName = "Admin";
            Ado.DtCompte = Ado.Ds.Tables[1];
            Ado.DtCompte.TableName = "Compte";
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
           // string pseudo = this.inputPseudo.Text.Trim();
            //string password = this.inputPassword.Text.Trim();

            if (this.loginType.Checked)
            {
                foreach(DataRow row in Ado.DtAdmin.Rows)
                {
                    if(row[5].ToString() == this.inputPseudo.Text.Trim() && row[4].ToString() == this.inputPassword.Text.Trim())
                    {
                        this.Hide();
                        Admin f = new Admin();
                        f.Show();
                        return;
                    }
                    MessageBox.Show("Invalid Information");
                }
            }
        }










        private void FillAdmin()
        {
            string query = string.Empty + "select * from Admin ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Admin");
        }

        private void FillCompte()
        {
            string query = string.Empty + "select * from Compte ;";
            Ado.Cmd.CommandText = query;
            Ado.Cmd.Connection = Ado.Cnx;
            Ado.Adapter.SelectCommand = Ado.Cmd;
            Ado.Adapter.Fill(Ado.Ds, "Compte");
        }
    }
}
