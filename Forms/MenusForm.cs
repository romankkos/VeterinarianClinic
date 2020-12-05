using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicApp.DbContexts;
using ClinicApp.util;
using ClinicApp.Models;

namespace ClinicApp.Forms
{
    public partial class MenusForm : Form
    {        
        public MenusForm()
        {
            InitializeComponent();            
        }       

        private void OSForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var osform = new OwnersServicesForm();
            osform.Show();
        }

        private void ownersBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ownersforms = new OwnersForm();
            ownersforms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var servicesforms = new ServicesForm();
            servicesforms.Show();
        }

        private void vForm_Click(object sender, EventArgs e)
        {
            this.Hide();
            var veterinarianforms = new VeterinarianForm();
            veterinarianforms.Show();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var aforms = new AnimalsForms();
            aforms.Show();
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vforms = new VactinationForm();
            vforms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var avforms = new AnimalsVactinationForm();
            avforms.Show();
        }

        private void MenusForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
