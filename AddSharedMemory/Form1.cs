using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AddSharedMemory
{
    public partial class Form1 : Form
    {
        ServiceMetier.Service1Client service=new ServiceMetier.Service1Client();
        public Form1()
        {
            service= new ServiceMetier.Service1Client();
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgJury.DataSource = service.GetJury();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ServiceMetier.jury jury =new ServiceMetier.jury();
            jury.Nom=txtNom.Text;
            jury.Prenom=txtPrenom.Text;
            jury.Grade=txtGrade.Text;
            jury.Specialite=txtSpecialite.Text;
            service.AddJury(jury);
            Effacer();
        }

        public void Effacer()
        {
            txtNom.Text = string.Empty;
            txtPrenom.Text = string.Empty;
            txtGrade.Text=string.Empty;
            txtSpecialite.Text=string.Empty;
            dgJury.DataSource = service.GetJury();
            txtNom.Focus();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            ServiceMetier.jury jury = new ServiceMetier.jury();
            jury.Nom=txtNom.Text;
            jury.Prenom=txtPrenom.Text;
            jury.Specialite=txtSpecialite.Text;
            jury.Grade = txtGrade.Text;
            service.EditJury(jury);
            Effacer();
        }

        private void dgJury_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
