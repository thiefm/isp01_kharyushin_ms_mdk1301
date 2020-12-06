using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;
using WindowsFormsApp6.Models;
using System.Windows.Forms;

namespace WindowsFormsApp6.Controllers
{
    public class StudentsEditorController
    {
        private StudentsEditorForm _view;

        public StudentsEditorController(StudentsEditorForm view)
        {
            _view = view;
        }

        public void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_view.ChangeData.FullName)
                || string.IsNullOrEmpty(_view.ChangeData.Gender)
                || string.IsNullOrEmpty(_view.ChangeData.Phone)
                || _view.ChangeData.GroupId == 0)
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
