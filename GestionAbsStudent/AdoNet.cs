using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace GestionAbsStudent
{
    class AdoNet
    {
        private SqlConnection cnx;
        private SqlCommand cmd;
        private SqlDataReader reader;
        private SqlDataAdapter adapter;
        private string connexionString;
        private DataTable dtD;
        private DataTable dtA;
        private DataSet ds;



        public AdoNet()
        {
            //connexionString = ConfigurationManager.ConnectionStrings["CnxSqlServer"].ConnectionString;
            cnx = new SqlConnection(connexionString);
            cmd = new SqlCommand();
            adapter = new SqlDataAdapter();
            ds = new DataSet();
            dtA = new DataTable();
            dtD = new DataTable();
        }

        public string ConnexionString { get => connexionString; }
        public SqlConnection Cnx { get => cnx; set => cnx = value; }
        public SqlCommand Cmd { get => cmd; set => cmd = value; }
        public SqlDataReader Reader { get => reader; set => reader = value; }
        public SqlDataAdapter Adapter { get => adapter; set => adapter = value; }
        public DataSet Ds { get => ds; set => ds = value; }
        public DataTable DtA { get => dtA; set => dtA = value; }
        public DataTable DtD { get => dtD; set => dtD = value; }



















    }
}
