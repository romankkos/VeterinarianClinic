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
    public partial class ServicesForm : Form
    {
        private Services services = new Services(); 
        public ServicesForm()
        {
            InitializeComponent();
            populateDataGridView();


        }

        void populateDataGridView()

        {
            servicesView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                servicesView.DataSource = db.Services.ToList();

            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            service_name.Text = "";
            prices.Text = "";

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            services.Id = 0;
            //goToButton.Enabled = false;
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

                services.ServiceName = service_name.Text.Trim();
                services.Price = Convert.ToDouble(prices.Text);

                if (services.Id == 0) db.Services.Add(services);
                else db.Services.Update(services);

                db.SaveChanges();
            }
            populateDataGridView();
            clear();
        }

        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(service_name.Text.Trim(), 50, "Название услуги"));
            validator.append(builder, validator.isValidDoubleValue(prices.Text.Trim(), "Ценник"));

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }

        private void servicesView_DoubleClick(object sender, EventArgs e)
        {
            if (servicesView.CurrentRow.Index != -1)
            {

                services.Id = Convert.ToInt32(servicesView.CurrentRow.Cells["id"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    services = db.Services.Where(x => x.Id == services.Id).FirstOrDefault();
                    Console.WriteLine(services.ServiceName);

                    service_name.Text = services.ServiceName;
                    prices.Text = services.Price.ToString();                    

                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    var entry = db.Entry(services);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                        db.Services.Attach(services);
                    db.Services.Remove(services);
                    db.SaveChanges();

                }
                populateDataGridView();
                clear();

            }
        }

        private void backButtonmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuforms = new MenusForm();
            menuforms.Show();
        }

        private void backButtonform_Click(object sender, EventArgs e)
        {
            this.Hide();
            var osforms = new OwnersServicesForm();
            osforms.Show();
        }

        private void ServicesForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
