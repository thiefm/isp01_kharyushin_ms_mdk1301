using System;
using WindowsFormsApp6.Views;
using System.Windows.Forms;

namespace WindowsFormsApp6.Controllers
{
    class SpecialtiesEditorController
    {
        private SpecialtiesEditorForm _view;

        public SpecialtiesEditorController(SpecialtiesEditorForm view)
        {
            _view = view;
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.ChangeData.Code)
                || string.IsNullOrEmpty(_view.ChangeData.Name))
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
