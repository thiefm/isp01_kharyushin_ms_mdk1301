using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp6.Controllers;
using WindowsFormsApp6.Models;
using WindowsFormsApp6.Providers;

namespace WindowsFormsApp6.Views
{
    public partial class GroupsEditorForm : Form
    {
        public StudentsGroup ChangeData
        {
            get
            {
                return new StudentsGroup
                {
                    Name = this.nameTextBoxGroupsEditorForm.Text,
                    YearCreation = int.Parse(this.yearCreationTextBoxGroupsEditorForm.Text),
                    SpecialtyId = this.specialtyComboBoxGroupsEditorForm.SelectedIndex + 1
                };
            }
        }

        public GroupsEditorForm(StorageContext context)
        {
            InitializeComponent();

            var groupsEditorController = new GroupsEditorController(context, this);
            this.submitButtonGroupsEditorForm.Click += groupsEditorController.SubmitButton_Click;
            this.exitButtonGroupsEditorForm.Click += groupsEditorController.ExitButton_Click;
        }

        public DialogResult ShowDialog(List<Specialty> specialties, StudentsGroup group = null)
        {
            if (group == null)
                group = new StudentsGroup();

            this.nameTextBoxGroupsEditorForm.Text = group.Name;

            if (group.YearCreation != default)
                this.yearCreationTextBoxGroupsEditorForm.Text = group.YearCreation.ToString();

            this.specialtyComboBoxGroupsEditorForm.DataSource = specialties;
            this.specialtyComboBoxGroupsEditorForm.DisplayMember = "Name";

            Specialty specialty = null;
            foreach (var item in specialties)
            {
                if (item.Id == group.SpecialtyId)
                {
                    specialty = item;
                    break;
                }
            }

            this.specialtyComboBoxGroupsEditorForm.SelectedItem = specialty;

            return base.ShowDialog();
        }
    }
}
