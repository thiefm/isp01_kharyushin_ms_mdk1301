using System.Windows.Forms;

using WindowsFormsApp6.Models;
using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Controllers;

namespace WindowsFormsApp6.Views
{
    public partial class SpecialtiesEditorForm : Form
    {
        public Specialty ChangeData
        {
            get
            {
                return new Specialty
                {
                    Code = this.codeTextBoxSpecialtiesEditorForm.Text,
                    Name = this.nameTextBoxSpecialtiesEditorForm.Text
                };
            }
        }

        public SpecialtiesEditorForm()
        {
            InitializeComponent();

            var specialtiesEditorController = new SpecialtiesEditorController(this);
            this.submitButtonSpecialtiesEditorForm.Click += specialtiesEditorController.SubmitButton_Click;
            this.exitButtonSpecialtiesEditorForm.Click += specialtiesEditorController.ExitButton_Click;
        }

        public DialogResult ShowDialog(Specialty specialty = null)
        {
            if (specialty == null)
                specialty = new Specialty();

            this.codeTextBoxSpecialtiesEditorForm.Text = specialty.Code;
            this.nameTextBoxSpecialtiesEditorForm.Text = specialty.Name;

            return base.ShowDialog();
        }
    }
}
