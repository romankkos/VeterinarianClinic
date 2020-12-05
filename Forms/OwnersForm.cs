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
    public partial class OwnersForm : Form
    {
        private Owners owners = new Owners();
        public OwnersForm()
        {
            InitializeComponent();
            populateDataGridView();                      
        }

        void populateDataGridView()

        {
            ownerView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                ownerView.DataSource = db.Owners.ToList();

            }
        }
        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(owner_name.Text.Trim(), 50, "Имя владельца"));
            validator.append(builder, validator.checkValidLength(owner_surname.Text.Trim(), 50, "Фамилия владельца"));
            validator.append(builder, validator.checkValidLength(owner_lastname.Text.Trim(), 50, "Отчество владельца"));            
            validator.append(builder, validator.PhoneNumberValidate(phone.Text.Trim()));

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }
        private void clear()
        {
            owner_name.Text = "";
            owner_surname.Text = "";
            owner_lastname.Text = "";
            phone.Text = "";

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            owners.Id = 0;
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

                owners.OwnerName = owner_name.Text.Trim();
                owners.OwnerSurname = owner_surname.Text.Trim();
                owners.OwnerLastname = owner_lastname.Text.Trim();
                owners.Phone = phone.Text.Trim();                

                if (owners.Id == 0) db.Owners.Add(owners);
                else db.Owners.Update(owners);

                db.SaveChanges();
            }
            populateDataGridView();
            clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    var entry = db.Entry(owners);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                        db.Owners.Attach(owners);
                    db.Owners.Remove(owners);
                    db.SaveChanges();

                }
                populateDataGridView();
                clear();

            }
        }

        private void ownerView_DoubleClick(object sender, EventArgs e)
        {
            if (ownerView.CurrentRow.Index != -1)
            {

                owners.Id = Convert.ToInt32(ownerView.CurrentRow.Cells["id"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    owners = db.Owners.Where(x => x.Id == owners.Id).FirstOrDefault();
                    Console.WriteLine(owners.OwnerName);

                    owner_name.Text = owners.OwnerName;
                    owner_surname.Text = owners.OwnerSurname;
                    owner_lastname.Text = owners.OwnerLastname;
                    phone.Text = owners.Phone;                    

                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
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

        private void aButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var aforms = new AnimalsForms();
            aforms.Show();
        }

        private void OwnersForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
    


}
