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
    public partial class ImprimerEmploye : MetroFramework.Forms.MetroForm
    {
        public ImprimerEmploye()
        {
            InitializeComponent();
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            CR1 cr = new CR1();
            crystalReportViewer1.ReportSource = cr;
        }

        private void EmployClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
