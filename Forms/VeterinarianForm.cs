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
    public partial class VeterinarianForm : Form
    {
        private Veterinarian veterinarian = new Veterinarian();
        public VeterinarianForm()
        {
            InitializeComponent();
            populateDataGridView();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
        void populateDataGridView()

        {
            veterinarianView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                veterinarianView.DataSource = db.Veterinarian.ToList();

            }
        }       
        private void clear()
        {
            veterinarian_name.Text = "";
            veterinarian_surname.Text = "";
            veterinarian_lastname.Text = "";
            email.Text = "";
            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            veterinarian.Id = 0;
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

                veterinarian.VeterinarianName = veterinarian_name.Text.Trim();
                veterinarian.VeterinarianSurname = veterinarian_surname.Text.Trim();
                veterinarian.VeterinarianLastname = veterinarian_lastname.Text.Trim();
                veterinarian.Email = email.Text.Trim();

                if (veterinarian.Id == 0) db.Veterinarian.Add(veterinarian);
                else db.Veterinarian.Update(veterinarian);

                db.SaveChanges();
            }
            populateDataGridView();
            clear();
        }
        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(veterinarian_name.Text.Trim(), 50, "Имя"));
            validator.append(builder, validator.checkValidLength(veterinarian_surname.Text.Trim(), 50, "Фамилия"));
            validator.append(builder, validator.checkValidLength(veterinarian_lastname.Text.Trim(), 50, "Отчество"));
            validator.append(builder, validator.checkValidLength(email.Text.Trim(), 25, "Email"));

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    var entry = db.Entry(veterinarian);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                    db.Veterinarian.Attach(veterinarian);
                    db.Veterinarian.Remove(veterinarian);
                    db.SaveChanges();
                    
                }
                populateDataGridView();
                clear();

            }
        }

        private void veterinarianView_DoubleClick(object sender, EventArgs e)
        {
            if (veterinarianView.CurrentRow.Index != -1)
            {

                veterinarian.Id = Convert.ToInt32(veterinarianView.CurrentRow.Cells["id"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    veterinarian = db.Veterinarian.Where(x => x.Id == veterinarian.Id).FirstOrDefault();
                    Console.WriteLine(veterinarian.VeterinarianName);                    

                    veterinarian_name.Text = veterinarian.VeterinarianName.ToString();
                    veterinarian_surname.Text = veterinarian.VeterinarianSurname.ToString();
                    veterinarian_lastname.Text = veterinarian.VeterinarianLastname.ToString();
                    email.Text = veterinarian.Email.ToString();

                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
        }

        private void backButtonmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuforms = new MenusForm();
            menuforms.Show();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var aforms = new AnimalsForms();
            aforms.Show();
        }

        private void VeterinarianForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
