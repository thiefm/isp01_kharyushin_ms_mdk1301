using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp6.Controllers;
using WindowsFormsApp6.Models;
using WindowsFormsApp6.Providers;

namespace WindowsFormsApp6.Views
{
    public partial class StudentsEditorForm : Form
    {
        public Student ChangeData
        {
            get
            {
                return new Student
                {
                    FullName = this.fioTextBoxStudentsEditorForm.Text,
                    Gender = this.genderComboBoxStudentsEditorForm.Text,
                    Phone = this.phoneTextBoxStudentsEditorForm.Text,
                    GroupId = this.groupComboBoxStudentsEditorForm.SelectedIndex + 1
                };
            }
        }

        public StudentsEditorForm()
        {
            InitializeComponent();

            var studentsEditorController = new StudentsEditorController(this);
            this.submitButtonStudentsEditorForm.Click += studentsEditorController.SubmitButton_Click;
            this.exitButtonStudentsEditorForm.Click += studentsEditorController.ExitButton_Click;
        }

        public DialogResult ShowDialog(List<StudentsGroup> groups, Student student = null)
        {
            if (student == null)
                student = new Student();

            this.fioTextBoxStudentsEditorForm.Text = student.FullName;
            this.genderComboBoxStudentsEditorForm.SelectedItem = student.Gender;
            this.phoneTextBoxStudentsEditorForm.Text = student.Phone;

            this.groupComboBoxStudentsEditorForm.DataSource = groups;
            this.groupComboBoxStudentsEditorForm.DisplayMember = "Name";

            StudentsGroup group = null;
            foreach (var item in groups)
            {
                if (item.Id == student.GroupId)
                {
                    group = item;
                    break;
                }
            }

            this.groupComboBoxStudentsEditorForm.SelectedItem = group;

            return base.ShowDialog();
        }
    }
}
