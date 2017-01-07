using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

   /*     public static void Control_check()
        {
            foreach (Control ctrl in Form1.metroTabPage1.Controls)
            {
                if (ctrl is MetroFramework.Controls.MetroTextBox)
                {
                    if (ctrl.Text == "")
                    {
                        MessageBox.Show("Veuillez remplir tout les champs", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                        break;
                    }
                }
            }

        }*/

    }
}
