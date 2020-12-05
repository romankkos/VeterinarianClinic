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
    public partial class AnimalsVactinationForm : Form
    {
        private AnimalsVactination animals_vactination = new AnimalsVactination();
        public AnimalsVactinationForm()
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

            vactinationView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                vactinationView.DataSource = db.Vactination.ToList();

            }

            animalsVactinationView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                animalsVactinationView.DataSource = db.AnimalsVactination.ToList();

            }
        }
        private void backButtonmenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            var menuforms = new MenusForm();
            menuforms.Show();
        }

        private void clear()
        {
            animal_id.Text = "";
            vactination_id.Text = "";

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            animals_vactination.Id = 0;
            //goToButton.Enabled = false;
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }

        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(animal_id.Text.Trim(), 10, "Id Животного"));
            validator.append(builder, validator.checkValidLength(vactination_id.Text.Trim(), 10, "Id вакцины"));

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

                animals_vactination.AnimalId = Convert.ToInt32(animal_id.Text);
                animals_vactination.VactinationId = Convert.ToInt32(vactination_id.Text);             

                if (animals_vactination.Id == 0) db.AnimalsVactination.Add(animals_vactination);
                else db.AnimalsVactination.Update(animals_vactination);

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
            populateDataGridView();
            clear();
        }

        private void animalsVactinationView_DoubleClick(object sender, EventArgs e)
        {
            if (animalsVactinationView.CurrentRow.Index != -1)
            {

                animals_vactination.Id = Convert.ToInt32(animalsVactinationView.CurrentRow.Cells["avId"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    animals_vactination = db.AnimalsVactination.Where(x => x.Id == animals_vactination.Id).FirstOrDefault();
                    animal_id.Text = animals_vactination.AnimalId.ToString();
                    vactination_id.Text = animals_vactination.VactinationId.ToString();

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
                    var entry = db.Entry(animals_vactination);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                        db.AnimalsVactination.Attach(animals_vactination);
                    db.AnimalsVactination.Remove(animals_vactination);
                    db.SaveChanges();

                }
                populateDataGridView();
                clear();

            }
        }

        private void vButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var vforms = new VactinationForm();
            vforms.Show();
        }

        private void aButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var aforms = new AnimalsForms();
            aforms.Show();
        }

        private void AnimalsVactinationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
