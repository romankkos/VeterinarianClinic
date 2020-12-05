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
    public partial class OwnersServicesForm : Form
    {
        private OwnersServices owners_services = new OwnersServices();
        //private readonly int ownerId;
        //private readonly int serviceId;
        //private Owners owners = new Owners();
        //private Services services = new Services();
        public OwnersServicesForm()
        {
            InitializeComponent();
            populateDataGridView();
            populateDataGridView2();
            populateDataGridView3();
        }

        void populateDataGridView()

        {
            ownerView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                ownerView.DataSource = db.Owners.ToList();

            }
        }

        void populateDataGridView2()
        {
            servicesView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                servicesView.DataSource = db.Services.ToList();

            }
        }

        void populateDataGridView3()
        {
            ownersServicesView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                ownersServicesView.DataSource = db.OwnersServices.ToList();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            owner_id.Text = "";
            service_id.Text = "";

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            owners_services.Id = 0;
            //goToButton.Enabled = false;
        }
        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(owner_id.Text.Trim(), 10, "Id Владельца"));
            validator.append(builder, validator.checkValidLength(service_id.Text.Trim(), 10, "Id услуги"));

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            using (vet_clinicContext db = new vet_clinicContext())
            {
                String validateMessages = validate();
                if (validateMessages != null)
                {
                    MessageBox.Show(validateMessages, "Ошибка",
                     MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
               
                owners_services.OwnerId = Convert.ToInt32(owner_id.Text);
                owners_services.ServiceId = Convert.ToInt32(service_id.Text);
                //owners_services.OwnerId = ownerId;
                //WindowsFormsApp3.Models.Owners owners = db.Owners.Where(x => x.Id == ownerId).FirstOrDefault();
                //WindowsFormsApp3.Models.Services services = db.Services.Where(x => x.Id == serviceId).FirstOrDefault();

                if (owners_services.Id == 0) db.OwnersServices.Add(owners_services);
                else db.OwnersServices.Update(owners_services);

                //db.SaveChanges();
                try
                {
                    db.SaveChanges();

                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    MessageBox.Show("Ошибка,такого Id Не существует", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            populateDataGridView3();
            clear();
        }

        private void ownersServicesView_DoubleClick(object sender, EventArgs e)
        {
            if (ownersServicesView.CurrentRow.Index != -1)
            {

                owners_services.Id = Convert.ToInt32(ownersServicesView.CurrentRow.Cells["osId"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    owners_services = db.OwnersServices.Where(x => x.Id == owners_services.Id).FirstOrDefault();                    
                    owner_id.Text = owners_services.OwnerId.ToString();
                    service_id.Text = owners_services.ServiceId.ToString();

                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void clearButton_Click_1(object sender, EventArgs e)
        {
            clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    var entry = db.Entry(owners_services);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                    db.OwnersServices.Attach(owners_services);
                    db.OwnersServices.Remove(owners_services);
                    db.SaveChanges();

                }
                populateDataGridView3();
                clear();

            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {               
            this.Hide();
            var menuforms = new MenusForm();
            menuforms.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ownersforms = new OwnersForm();
            ownersforms.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            var servicesforms = new ServicesForm();
            servicesforms.Show();
        }

        private void OwnersServicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
