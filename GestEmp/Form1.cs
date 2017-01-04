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
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        
        public Form1()
        {
            InitializeComponent();
            BTN_Accueil.BackColor = Color.FromArgb(0, 174, 219);

            //afficher l'icon list 
            pictureBox8.Parent = UCAccueil.instanceUCAccueil;
            pictureBox8.BackColor = Color.Transparent;



        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //-- rounded shape for picture box
            /*
            System.Drawing.Drawing2D.GraphicsPath gp = new System.Drawing.Drawing2D.GraphicsPath();
            gp.AddEllipse(0, 0, pictureBox4.Width - 1, pictureBox4.Height - 1);
            Region rg = new Region(gp);
            pictureBox4.Region = rg;*/
            //call the click event . 
            BTN_Accueil_Click(sender, e);

            //initialise the picture in 'Modifier/supprimer'
            pictureBox3.BackgroundImage = new Bitmap(GestEmp.Properties.Resources.user4);
            pictureBox3.BackgroundImageLayout = ImageLayout.Stretch;

            //initialise the picture in 'AJouter'
            pictureBox4.BackgroundImage = new Bitmap(GestEmp.Properties.Resources.user4);
            pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
            //initialise the background picture
            if (!panel1.Controls.Contains(UCAccueil.instanceUCAccueil))
            {
                panel1.Controls.Add(UCAccueil.instanceUCAccueil);
                UCAccueil.instanceUCAccueil.Dock = DockStyle.Fill;
                UCAccueil.instanceUCAccueil.BringToFront();
            }
            else
                UCAccueil.instanceUCAccueil.BringToFront();
            //ajouter ucdepartement a panel2
            panel2.Controls.Add(UCDepartement.instanceUCDepartement);
            UCDepartement.instanceUCDepartement.Dock = DockStyle.Fill;
            // make metrotab fill the panel2
            metroTabControl1.Dock = DockStyle.Fill;

            MessageBox.Show("Fuck l3abid");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();

        }
        // drag the panel ------------------
        private bool dragging = false;
        private Point dragCursorPoint;
        private Point dragFormPoint;

        private void metroPanel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            dragging = true;
            dragCursorPoint = Cursor.Position;
            dragFormPoint = this.Location;
        }

        private void metroPanel2_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(dragCursorPoint));
                this.Location = Point.Add(dragFormPoint, new Size(dif));
            }
        }

        private void metroPanel2_MouseUp_1(object sender, MouseEventArgs e)
        {
            dragging = false;
        }
        //----------------------- finish drag
        private void metroLabel9_Click(object sender, EventArgs e)
        {

        }

        private void BTN_Accueil_Click(object sender, EventArgs e)
        {

   
            BTN_Accueil.BackColor = Color.FromArgb(0, 174, 219);
            BTN_Employe.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Departement.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Statistique.BackColor = Color.FromArgb(34, 34, 34);


            panel2.Hide();
            panel1.BringToFront();



        }

        private void BTN_Employe_Click(object sender, EventArgs e)
        {

           
            BTN_Employe.BackColor = Color.FromArgb(0, 174, 219);
            BTN_Accueil.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Departement.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Statistique.BackColor = Color.FromArgb(34, 34, 34);

            panel2.Show();
            panel2.BringToFront();
            metroTabControl1.BringToFront();


            //if you click on 'Employé' the image will be initialised
            /* if (!(pictureBox4.BackgroundImage == GestEmp.Properties.Resources.usericon))
             {
                 pictureBox4.BackgroundImage = new Bitmap(GestEmp.Properties.Resources.usericon);
                 pictureBox4.BackgroundImageLayout = ImageLayout.Stretch;
             }*/

        }

        private void BTN_Departement_Click(object sender, EventArgs e)
        {

     

            BTN_Departement.BackColor = Color.FromArgb(0, 174, 219);
            BTN_Employe.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Accueil.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Statistique.BackColor = Color.FromArgb(34, 34, 34);


            panel2.Show();
            panel2.BringToFront();
           
            UCDepartement.instanceUCDepartement.BringToFront();
         
        }

        private void BTN_Statistique_Click(object sender, EventArgs e)
        {
           
            BTN_Statistique.BackColor = Color.FromArgb(0, 174, 219);
            BTN_Departement.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Employe.BackColor = Color.FromArgb(34, 34, 34);
            BTN_Accueil.BackColor = Color.FromArgb(34, 34, 34);
            panel2.Hide();
            panel1.BringToFront();
        }

        private void pictureBox8_MouseLeave(object sender, EventArgs e)
        {
            pictureBox8.Image = Properties.Resources.list2;
            pictureBox8.Size = new Size(36, 36);

        }

        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(112, 33);
        }

        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(113, 34);
        }

        private void button2_MouseUp(object sender, MouseEventArgs e)
        {
            button2.Size = new Size(114, 35);

        }

        private void button1_MouseUp(object sender, MouseEventArgs e)
        {
            button1.Size = new Size(114, 35);
        }

        private void button6_MouseDown(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(127, 33);
        }

        private void button6_MouseUp(object sender, MouseEventArgs e)
        {
            button6.Size = new Size(128, 35);
        }

        private void metroTabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button3_MouseDown(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(120, 30);
        }

        private void button3_MouseUp(object sender, MouseEventArgs e)
        {
            button3.Size = new Size(124, 35);
        }

        private void button4_MouseDown(object sender, MouseEventArgs e)
        {
            button4.Size = new Size(120, 30);
        }

        private void button4_MouseUp(object sender, MouseEventArgs e)
        {
            button4.Size = new Size(124, 35);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* if(!panel2.Controls.Contains(UCModifier.instanceUCModifier))
             panel2.Controls.Add(UCModifier.instanceUCModifier);
             UCModifier.instanceUCModifier.Dock = DockStyle.Fill;
             UCModifier.instanceUCModifier.BringToFront();
             panel2.Location = new Point(175, 150);
             panel2.Parent = this;

             panel2.BringToFront();*/
            Form2 f = new Form2();
            f.Show(this);


            
        }

        private void metroLabel13_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel18_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
           
        }

        private void button7_MouseHover(object sender, EventArgs e)
        {
            button7.Size = new Size(30, 28);
        }

        private void button7_MouseLeave(object sender, EventArgs e)
        {
            button7.Size = new Size(27, 25);
        }

        private void button7_Click(object sender, EventArgs e)
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

        private void button5_MouseDown(object sender, MouseEventArgs e)
        {
            button5.Size = new Size(100, 27);
        }

        private void button5_MouseUp(object sender, MouseEventArgs e)
        {
            button5.Size = new Size(101, 28);
        }

        private void metroTabControl1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 f = new Form2();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            EmployeInfo f = new EmployeInfo();
            f.Show();
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
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
        private void button3_Click(object sender, EventArgs e)
        {

        }
        private void TXB_Ajouter_Nom_Click(object sender, EventArgs e)
        {

        }










        // end  of the drag -------------
    }
}
