using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestEmp
{
    public partial class UCDepartement : UserControl
    {
        private static UCDepartement _instanceUCDepartement;
        public static UCDepartement instanceUCDepartement
        {

            get { if (_instanceUCDepartement == null)
                    _instanceUCDepartement = new UCDepartement();
                return _instanceUCDepartement;
            }

        }
        public UCDepartement()
        {
            InitializeComponent();
        }

        private void UCDepartement_Load(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(127, 33);

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(129, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(127, 33);
        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(129, 35);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(127, 33);
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(129, 35);
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(127, 33);
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(129, 35);
        }

        private void button6_Click(object sender, EventArgs e)
        {

        }
    }
}
