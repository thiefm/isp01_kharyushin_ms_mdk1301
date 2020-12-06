using System;
using System.Collections.Generic;
using System.Windows.Forms;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Controllers
{
    public class SpecialtiesController
    {
        private StorageContext _context;

        private SpecialtiesForm _view;

        public SpecialtiesController(StorageContext context, SpecialtiesForm view)
        {
            _context = context;
            _view = view;
        }

        private void UpdateSpecialtiesData()
        {
            var selectedStudents = _context.Specialties.GetAll();
            _view.SpecialtiesGridView.DataSource = selectedStudents;
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            var specialtiesEditorController = new SpecialtiesEditorForm();
            var dialogResult = specialtiesEditorController.ShowDialog();

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Specialties.Add(specialtiesEditorController.ChangeData);
                UpdateSpecialtiesData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateSpecialtiesData();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            int specialtyId = (int)_view.SpecialtiesGridView.CurrentRow.Cells[0].Value;
            Specialty specialty = _context.Specialties.Get(specialtyId);

            var specialtiesEditorController = new SpecialtiesEditorForm();
            var dialogResult = specialtiesEditorController.ShowDialog(specialty);

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Specialties.Update(specialtyId, specialtiesEditorController.ChangeData);
                UpdateSpecialtiesData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
