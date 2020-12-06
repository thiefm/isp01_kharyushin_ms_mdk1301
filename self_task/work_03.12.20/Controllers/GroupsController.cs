using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Models;
using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;

namespace WindowsFormsApp6.Controllers
{
    public class GroupsController
    {
        private StorageContext _context;

        private GroupsForm _view;

        public GroupsController(StorageContext context, GroupsForm view)
        {
            _context = context;
            _view = view;
        }

        private void UpdateGroupsData()
        {
            var selectedGroups = _context.Groups.GetAll();
            _view.GroupsGridView.DataSource = selectedGroups;
        }

        public void GroupsGridView_CellFormatting(
            object sender,
            DataGridViewCellFormattingEventArgs e)
        {
            var column = _view.GroupsGridView.Columns[e.ColumnIndex];

            if (column.Name != "SpecialtyColumn")
                return;

            var student = _view.GroupsGridView.Rows[e.RowIndex].DataBoundItem as StudentsGroup;
            e.Value = student.Specialty.Name;
        }

        public void AddButton_Click(object sender, EventArgs e)
        {
            List<Specialty> selectedSpecialties = _context.Specialties.GetAll();

            GroupsEditorForm groupsEditorForm = new GroupsEditorForm(_context);
            var dialogResult = groupsEditorForm.ShowDialog(selectedSpecialties);

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Groups.Add(groupsEditorForm.ChangeData);
                UpdateGroupsData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void UpdateButton_Click(object sender, EventArgs e)
        {
            UpdateGroupsData();
        }

        public void EditButton_Click(object sender, EventArgs e)
        {
            List<Specialty> selectedSpecialties = _context.Specialties.GetAll();

            int groupId = (int)_view.GroupsGridView.CurrentRow.Cells[0].Value;
            StudentsGroup group = _context.Groups.Get(groupId);

            GroupsEditorForm groupsEditorForm = new GroupsEditorForm(_context);
            var dialogResult = groupsEditorForm.ShowDialog(selectedSpecialties, group);

            if (dialogResult != DialogResult.OK)
                return;

            try
            {
                _context.Groups.Update(groupId, groupsEditorForm.ChangeData);
                UpdateGroupsData();
            }
            catch
            {
                MessageBox.Show("Ошибка базы данных!", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
