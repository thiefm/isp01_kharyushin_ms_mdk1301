using System;
using System.Collections.Generic;
using System.Windows.Forms;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Controllers
{
    public class StudentsController
    {
        private StorageContext _context;

        private StudentsForm _view;

        public StudentsController(StorageContext context, StudentsForm view)
        {
            _context = context;
            _view = view;
        }

        private void UpdateStudentsData()
        {
            var selectedStudents = _context.Students.GetAll();
            _view.StudentsGridView.DataSource = selectedStudents;
        }

        public void StudentsGridView_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            var column = _view.StudentsGridView.Columns[e.ColumnIndex];

            if (column.Name != "GroupColumn")
                return;

            var student = _view.StudentsGridView.Rows[e.RowIndex].DataBoundItem as Student;
            e.Value = student.Group.Name;
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            List<StudentsGroup> selectedGroups = _context.Groups.GetAll();

            StudentsEditorForm studentsEditorForm = new StudentsEditorForm();
            var dialogResult = studentsEditorForm.ShowDialog(selectedGroups);

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Students.Add(studentsEditorForm.ChangeData);
                UpdateStudentsData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateStudentsData();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            List<StudentsGroup> selectedGroups = _context.Groups.GetAll();

            int studentId = (int)_view.StudentsGridView.CurrentRow.Cells[0].Value;
            Student student = _context.Students.Get(studentId);

            StudentsEditorForm studentsEditorForm = new StudentsEditorForm();
            var dialogResult = studentsEditorForm.ShowDialog(selectedGroups, student);

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Students.Update(studentId, studentsEditorForm.ChangeData);
                UpdateStudentsData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
