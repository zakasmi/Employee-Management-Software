using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmp
{
    public partial class EmployeInfo : Form
    {
        public EmployeInfo()
        {
            InitializeComponent();
        }

        private void EmployeInfo_Load(object sender, EventArgs e)
        {

        }




        private void EmployClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public static DialogResult show() {

            using (EmployeInfo Emp = new EmployeInfo()) {

                return Emp.ShowDialog(); }

                
        }

        private void Info_NomPrenom_Click(object sender, EventArgs e)
        {

        }

        private void Info_PosteNom_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            ImprimerEmploye IE = new ImprimerEmploye();
            IE.ShowDialog();

        }

        private void h(object sender, EventArgs e)
        {

        }
    }
}
