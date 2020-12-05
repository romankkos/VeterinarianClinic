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
    public partial class VactinationForm : Form
    {
        private Vactination vactination = new Vactination();
        public VactinationForm()
        {
            InitializeComponent();
            populateDataGridView();
        }

        void populateDataGridView()

        {
            vactinationView.AutoGenerateColumns = false;
            using (vet_clinicContext db = new vet_clinicContext())
            {
                vactinationView.DataSource = db.Vactination.ToList();

            }
        }

        private string validate()
        {
            StringBuilder builder = new StringBuilder();
            TextBoxValidator validator = new TextBoxValidator();
            validator.append(builder, validator.checkValidLength(vactination_name.Text.Trim(), 50, "Название вакцины"));           

            if (String.IsNullOrEmpty(builder.ToString()))
            {
                return null;
            }

            return builder.ToString();
        }

        private void clear()
        {
            vactination_name.Text = "";           

            saveButton.Text = "Сохранить";
            //deleteButton.Enabled = false;
            vactination.Id = 0;
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

                vactination.VactinationName = vactination_name.Text.Trim();

                if (vactination.Id == 0) db.Vactination.Add(vactination);
                else db.Vactination.Update(vactination);

                db.SaveChanges();
            }
            populateDataGridView();
            clear();
        }

        private void vactinationView_DoubleClick(object sender, EventArgs e)
        {
            if (vactinationView.CurrentRow.Index != -1)
            {

                vactination.Id = Convert.ToInt32(vactinationView.CurrentRow.Cells["id"].Value);
                using (vet_clinicContext db = new vet_clinicContext())
                {
                    vactination = db.Vactination.Where(x => x.Id == vactination.Id).FirstOrDefault();
                    Console.WriteLine(vactination.VactinationName); // ???

                    vactination_name.Text = vactination.VactinationName;
                }
                saveButton.Text = "Обновить";
                deleteButton.Enabled = true;
            }
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
                    var entry = db.Entry(vactination);
                    if (entry.State == Microsoft.EntityFrameworkCore.EntityState.Detached)

                        db.Vactination.Attach(vactination);
                    db.Vactination.Remove(vactination);
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

        private void avButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            var avforms = new AnimalsVactinationForm();
            avforms.Show();
        }

        private void VactinationForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }

    
}
