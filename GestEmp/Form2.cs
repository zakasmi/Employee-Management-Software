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
using Microsoft.VisualBasic;

namespace GestEmp
{
    public partial class Form2 : Form
    {
        public int Paysid, Regionid, Villeid, Departementid, Posteid;
        


        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            Fill_CB();
            initialiser_Combobox();



        }

        private void metroLabel19_Click(object sender, EventArgs e)
        {

        }
        private void initialiser_Combobox()
        {
            CB_Modifier_Pays.SelectedValue = Paysid;
            CB_Modifier_Region.SelectedValue = Regionid;
            CB_Modifier_Ville.SelectedValue = Villeid;
            CB_Modifier_Departement.SelectedValue = Departementid;
            CB_Modifier_Poste.SelectedValue = Posteid;
            LBL_Mofdifier_NomPrenom.Text = TXB_Modifier_Nom.Text + " " + TXB_Modifier_Prenom.Text;

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            using (OpenFileDialog dlg = new OpenFileDialog())
            {
                dlg.Title = "Open Image";
                dlg.Filter = "image files (*.png)|*.png";

                if (dlg.ShowDialog() == DialogResult.OK)
                {
                    PictureBox PictureBox1 = new PictureBox();

                    // Create a new Bitmap object from the picture file on disk,
                    // and assign that to the PictureBox.Image property
                    pictureBox4.BackgroundImage = new Bitmap(dlg.FileName);
                    pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;


                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void CB_Ajouter_Pays_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void CB_Ajouter_Region_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void TXB_Ajouter_Nom_Click(object sender, EventArgs e)
        {

        }

        private void Form2_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
        private void Fill_CB()
        {

            this.CB_Modifier_Pays.SelectedValueChanged -= new EventHandler(CB_Modifier_Pays_SelectedValueChanged);
            CB_Modifier_Pays.DataSource = Provider.ds.Tables["Pays"];
            CB_Modifier_Pays.ValueMember = "ID_PAYS";
            CB_Modifier_Pays.DisplayMember = "Nom_pays";
            this.CB_Modifier_Pays.SelectedValueChanged += new EventHandler(CB_Modifier_Pays_SelectedValueChanged);
       
            CB_Modifier_Pays.SelectedIndex = -1;
           
            this.CB_Modifier_Departement.SelectedValueChanged -= new EventHandler(CB_Modifier_Departement_SelectedValueChanged);
            CB_Modifier_Departement.DataSource = Provider.ds.Tables["Departement"];
            CB_Modifier_Departement.ValueMember = "ID_DEPT";
            CB_Modifier_Departement.DisplayMember = "Dept_Nom";
            this.CB_Modifier_Departement.SelectedValueChanged += new EventHandler(CB_Modifier_Departement_SelectedValueChanged);
        
            CB_Modifier_Departement.SelectedIndex = -1;

        }

        private void CB_Modifier_Pays_SelectedIndexChanged(object sender, EventArgs e)
        {

           

        }

        private void CB_Modifier_Pays_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Modifier_Pays.SelectedIndex !=-1) {
                Fill_CB_Modifier_Region(CB_Modifier_Pays.SelectedValue.ToString());
                //to make Selectedvalue changed of region launched ou must set the 
                //index to -1 , so the value will be null and when you change the index .the 
                // event will be handled . 
                CB_Modifier_Region.SelectedIndex = -1;
                CB_Modifier_Ville.SelectedIndex = -1;
            } }
        private void Fill_CB_Modifier_Region(string s)
        {
            DataRow[] datarow = Provider.ds.Tables["Region"].Select("id_pays=" + s);
            DataTable dt = Provider.ds.Tables["Region"].Clone();
            foreach (DataRow row in datarow)
                dt.ImportRow(row);
            
            this.CB_Modifier_Region.SelectedValueChanged -= new EventHandler(CB_Modifier_Region_SelectedValueChanged);
            CB_Modifier_Region.DataSource = dt;
            CB_Modifier_Region.ValueMember = "ID_Region";
            CB_Modifier_Region.DisplayMember = "Nom_region";
            this.CB_Modifier_Region.SelectedValueChanged += new EventHandler(CB_Modifier_Region_SelectedValueChanged);
            

        
        }

        private void CB_Modifier_Region_SelectedValueChanged(object sender, EventArgs e)
        {

            if (CB_Modifier_Region.SelectedIndex !=-1)
            {
                Fill_CB_Modifier_Ville(CB_Modifier_Region.SelectedValue.ToString());
                CB_Modifier_Ville.SelectedIndex = -1;
            } 
        }

       

        private void Fill_CB_Modifier_Ville(string s)
        {


            DataRow[] datarow = Provider.ds.Tables["Ville"].Select("id_region =" + s);
            DataTable dt = Provider.ds.Tables["Ville"].Clone();
            foreach (DataRow row in datarow)
                dt.ImportRow(row);

            CB_Modifier_Ville.DataSource = dt;
            CB_Modifier_Ville.ValueMember = "ID_VILLE";
            CB_Modifier_Ville.DisplayMember = "Nom_ville";



        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Vider();
           
        }
        private void Vider()
        {
            TXB_Modifier_Nom.Text ="";
            TXB_Modifier_Prenom.Text = "";
            TXB_Modifier_Tel.Text = "";
            TXB_Modifier_Email.Text = "";
            DTP_Modifier_DateN.Value = DateTime.Now;
            DTP_Modifier_DateE.Value = DateTime.Now;
             RB_Modifier_F.Checked = false;
             RB_Modifier_M.Checked = false;
            TXB_Modifier_Salaire.Text = "";
            TXB_Modifier_Adresse.Text = "";
            CB_Modifier_Pays.SelectedIndex = -1;
            CB_Modifier_Region.SelectedIndex = -1;
            CB_Modifier_Ville.SelectedIndex = -1;
            CB_Modifier_Departement.SelectedIndex = -1;
            CB_Modifier_Poste.SelectedIndex = -1;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Provider.da = new SqlDataAdapter("select *from Employee", Provider.cnx);
            Provider.Cmb = new SqlCommandBuilder(Provider.da);
            DataRow[] drow = Provider.ds.Tables["Employee"].Select("ID_EMP= " + LBL_Modifier_IdEmp2.Text);
            drow[0]["Nom"] = TXB_Modifier_Nom.Text;
            drow[0]["Prenom"] = TXB_Modifier_Prenom.Text;
            drow[0]["Tel"] = TXB_Modifier_Tel.Text;
            drow[0]["Email"] = TXB_Modifier_Email.Text;
            drow[0]["DateN"] = DateTime.Parse(DTP_Modifier_DateN.Value.ToString());
            drow[0]["Date_Emb"] = DateTime.Parse(DTP_Modifier_DateE.Value.ToString());
            if (RB_Modifier_F.Checked) drow[0]["sexe"] = "F";
            else drow[0]["sexe"] = "M";

            drow[0]["Salaire"] = TXB_Modifier_Salaire.Text;
            drow[0]["Adress"] = TXB_Modifier_Adresse.Text;
            drow[0]["Id_pays"] = CB_Modifier_Pays.SelectedValue;
            drow[0]["id_region"] = CB_Modifier_Region.SelectedValue;
            drow[0]["id_ville"] = CB_Modifier_Ville.SelectedValue;
            drow[0]["id_dept"] = CB_Modifier_Departement.SelectedValue;
            drow[0]["id_poste"] = CB_Modifier_Poste.SelectedValue;
            string s = TXB_Modifier_Nom.Text +" "+ TXB_Modifier_Prenom.Text;
            LBL_Mofdifier_NomPrenom.Text = s.ToUpper();

           

            if (MessageBox.Show("etes vous sur de vouloir modifier", "Modifier", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                Provider.da.Update(Provider.ds, "Employee");
                MessageBox.Show("la modification a bien été effectuée");
            }

        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.undo2;
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.Undo;
        }

        private void button2_MouseDown_1(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.undo2;
        }

        private void button2_MouseUp_1(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.Undo;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            TXB_Modifier_Nom.Text = Provider.datarow[0][1].ToString();
            TXB_Modifier_Prenom.Text = Provider.datarow[0][2].ToString();
            TXB_Modifier_Tel.Text = Provider.datarow[0][3].ToString();
            TXB_Modifier_Email.Text = Provider.datarow[0][4].ToString();
            DTP_Modifier_DateN.Value = DateTime.Parse(Provider.datarow[0][5].ToString());
            DTP_Modifier_DateE.Value = DateTime.Parse(Provider.datarow[0][6].ToString());
            if (Provider.datarow[0][7].ToString() == "F") RB_Modifier_F.Checked = true;
            else RB_Modifier_M.Checked = true;
            TXB_Modifier_Salaire.Text = Provider.datarow[0][8].ToString();
            TXB_Modifier_Adresse.Text = Provider.datarow[0][9].ToString();
            initialiser_Combobox();
        }

        private void CB_Modifier_Departement_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Modifier_Departement.SelectedIndex != -1)
            {
                Fill_CB_Modifier_Poste(CB_Modifier_Departement.SelectedValue.ToString());
                CB_Modifier_Poste.SelectedValue = -1;
            }
        }
        private void Fill_CB_Modifier_Poste(string s ) {

            DataRow[] datarow = Provider.ds.Tables["Poste"].Select("id_dept=" + s);
            DataTable dt = Provider.ds.Tables["Poste"].Clone();
            foreach(DataRow row in datarow)
            dt.ImportRow(row);


            CB_Modifier_Poste.DataSource = dt;
            CB_Modifier_Poste.ValueMember = "ID_POSTE";
            CB_Modifier_Poste.DisplayMember = "Post_nom";




        }
        private void CB_Modifier_Poste_SelectedValueChanged(object sender, EventArgs e)
        {
            if (CB_Modifier_Poste.SelectedIndex != -1)
            {
                LBL_Modifier_Poste2.Text = CB_Modifier_Poste.Text;
            }
        }

        private void CB_Modifier_Ville_SelectedValueChanged(object sender, EventArgs e)
        {
         
            
            
        }
       
    }
}
