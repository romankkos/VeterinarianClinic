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
    public partial class AnimalsForms : Form
    {

        private Animals animals = new Animals();
        public AnimalsForms()
        {
            InitializeComponent();

            populateDataGridView();

        }

        void populateDataGridView()

        {
            animalsView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                animalsView.DataSource = db.Animals.ToList();

            }

            veterinarianView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                veterinarianView.DataSource = db.Veterinarian.ToList();

            }

            ownerView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                ownerView.DataSource = db.Owners.ToList();

            }
        }

        private void clear()
        {
            AnimalName.Text = "";
            AnimalGender.Text = "";
            AnimalBreed.Text = "";
            AnimalAge.Text = "";
            owner_id.Text = "";
            veterinarian_id.Text = "";

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            animals.Id = 0;
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

                animals.AnimalName = AnimalName.Text.Trim();
                animals.Breed = AnimalBreed.Text.Trim();
                animals.Gender = AnimalGender.Text.Trim();
                animals.Age = Convert.ToInt32(AnimalAge.Text);
                animals.OwnerId = Convert.ToInt32(owner_id.Text);
                animals.VeterinarianId = Convert.ToInt32(veterinarian_id.Text);

                if (animals.Id == 0) db.Animals.Add(animals);
                else db.Animals.Update(animals);

                //db.SaveChanges();
                try
                {
                    db.SaveChanges();

                }
                catch (Microsoft.EntityFrameworkCore.DbUpdateException)
                {
                    MessageBox.Show("Ошибка, Проверьте слуществует ли такой Id", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
            populateDataGridView();
            clear();
        }

        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(AnimalName.Text.Trim(), 50, "Имя животного"));
            validator.append(builder, validator.checkValidLength(AnimalBreed.Text.Trim(), 50, "Порода животного"));
            validator.append(builder, validator.checkValidLength(AnimalGender.Text.Trim(), 50, "Пол животного"));
            validator.append(builder, validator.checkValidLength(AnimalAge.Text.Trim(), 10, "Возраст животного"));
            validator.append(builder, validator.checkValidLength(AnimalAge.Text.Trim(), 10, "Id Ветеринара"));
            validator.append(builder, validator.checkValidLength(AnimalAge.Text.Trim(), 10, "Id Владельца"));


            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }

        private void animalsView_DoubleClick(object sender, EventArgs e)
        {
            if (animalsView.CurrentRow.Index != -1)
            {

                animals.Id = Convert.ToInt32(animalsView.CurrentRow.Cells["Id"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    animals = db.Animals.Where(x => x.Id == animals.Id).FirstOrDefault();
                    AnimalName.Text = animals.AnimalName.ToString();
                    AnimalBreed.Text = animals.Breed.ToString();
                    AnimalGender.Text = animals.Gender.ToString();
                    AnimalAge.Text = animals.Age.ToString();
                    veterinarian_id.Text = animals.VeterinarianId.ToString();
                    owner_id.Text = animals.OwnerId.ToString();

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

        private void AnimalsForms_Load(object sender, EventArgs e)
        {

        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Вы действительно хотите удалить запись?", "Удалить", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    var entry = db.Entry(animals);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                        db.Animals.Attach(animals);
                    db.Animals.Remove(animals);
                    db.SaveChanges();

                }
                populateDataGridView();
                clear();

            }
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var veterinarianforms = new VeterinarianForm();
            veterinarianforms.Show();
        }

        private void oButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ownersforms = new OwnersForm();
            ownersforms.Show();
        }

        private void AnimalsForms_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
