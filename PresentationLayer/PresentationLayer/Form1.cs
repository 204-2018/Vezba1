using BusinessLayer;
using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentationLayer
{
    public partial class Form1 : Form
    {
        public readonly VetBusiness vetBusiness;
        public Form1()
        {
            this.vetBusiness = new VetBusiness();
            InitializeComponent();
        }
        private void RefreshData()
        {
            List<Veterinar> results = this.vetBusiness.GetAllVets();

            listBoxVets.Items.Clear();
            foreach(Veterinar v in results)
            {
                listBoxVets.Items.Add(v.Id + " ," + v.FullName + " ," + v.Speciality + " ," + v.YearsExperience);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Veterinar v = new Veterinar();
            v.FullName = textBoxFullName.Text;
            v.Speciality = textBoxSpeciality.Text;
            v.YearsExperience = Convert.ToInt32(textBoxYearsExperince.Text);

            if(this.vetBusiness.InsertVet(v))
            {
                RefreshData();
                textBoxFullName.Clear();
                textBoxSpeciality.Clear();
                textBoxYearsExperince.Clear();
            }
            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
