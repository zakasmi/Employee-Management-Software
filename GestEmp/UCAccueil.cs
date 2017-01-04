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
    public partial class UCAccueil : UserControl
    {
        private static UCAccueil _instanceUCAccueil;
        public static UCAccueil instanceUCAccueil {
            
            get {
                if (_instanceUCAccueil == null)
                    _instanceUCAccueil = new UCAccueil();
                return _instanceUCAccueil;
                 }
            
            } 
        public UCAccueil()
        {
            InitializeComponent();
        }

        private void UCAccueil_Load(object sender, EventArgs e)
        {

        }
    }
}
