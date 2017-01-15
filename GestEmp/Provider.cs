using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace GestEmp
{
    public static class Provider
    {//Data Source=.\sqlexpress;Initial Catalog=GestEmp;Integrated Security=True
        public static SqlConnection cnx = new SqlConnection(@"Data Source=DELL;Initial Catalog=GestEmp;Integrated Security=True");
        public static SqlDataAdapter da = new SqlDataAdapter(); 
        public static DataSet ds = new DataSet();
        public static SqlCommandBuilder Cmb = new SqlCommandBuilder();
        public static  DataTable dt2 = new DataTable();
        public static DataTable dt1 = new DataTable();
        public static DataRow[] datarow; 







        public static string GetNewID_EMP()
        {

            cnx.Open();
            SqlCommand cmd = new SqlCommand("select max(ID_EMP)+1 from Employee", cnx);
            string k = cmd.ExecuteScalar().ToString();
            if (k == "") k = "1";
            cnx.Close();
            return k;
        }
    }




}
