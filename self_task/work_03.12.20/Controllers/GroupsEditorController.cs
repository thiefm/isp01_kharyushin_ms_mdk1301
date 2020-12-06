using System;
using System.Windows.Forms;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;

namespace WindowsFormsApp6.Controllers
{
    public class GroupsEditorController
    {
        private StorageContext _context;

        private GroupsEditorForm _view;

        public GroupsEditorController(StorageContext context, GroupsEditorForm view)
        {
            _context = context;
            _view = view;
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.ChangeData.Name)
                || string.IsNullOrEmpty(_view.ChangeData.YearCreation.ToString())
                || _view.ChangeData.SpecialtyId == 0)
                return;

            _view.DialogResult = DialogResult.OK;
            _view.Close();
        }

        public void ExitButton_Click(object sender, EventArgs e)
        {
            _view.Close();
        }
    }
}
