using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace GestionAbsStudent
{
    class AdoNet
    {
        private SqlConnection cnx;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connexionString;
        private DataTable dtCompte;
        private DataTable dtAbsence;
        private DataTable dtAgent;
        private DataSet ds;



        public AdoNet()
        {
            connexionString = ConfigurationManager.ConnectionStrings["CnxSqlServer"].ConnectionString;
            cnx = new SqlConnection(connexionString);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            dtCompte = new DataTable();
            dtAbsence = new DataTable();
            dtAgent = new DataTable();
        }

        public string ConnexionString { get => connexionString; }
        public SqlConnection Cnx { get => cnx; set => cnx = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public DataTable DtCompte { get => dtCompte; set => dtCompte = value; }
        public DataTable DtAbsence { get => dtAbsence; set => dtAbsence = value; }
        public DataTable DtAgent { get => dtAgent; set => dtAgent = value; }
    }
}
