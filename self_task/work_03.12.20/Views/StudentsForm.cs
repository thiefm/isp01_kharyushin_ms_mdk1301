using System.Collections.Generic;
using System.Windows.Forms;
using WindowsFormsApp6.Controllers;
using WindowsFormsApp6.Models;
using WindowsFormsApp6.Providers;

namespace WindowsFormsApp6.Views
{
    public partial class StudentsForm : Form
    {
        public DataGridView StudentsGridView {
            get => this.studentsGridView;
            set { this.studentsGridView = value; }
        }

        public StudentsForm(StorageContext context)
        {
            InitializeComponent();

            this.studentsGridView.AutoGenerateColumns = false;

            StudentsController studentsController = new StudentsController(context, this);
            this.studentsGridView.CellFormatting += studentsController.StudentsGridView_CellFormatting;
            this.addButtonStudentsForm.Click += studentsController.AddButton_Click;
            this.updateButtonStudentsForm.Click += studentsController.UpdateButton_Click;
            this.editButtonStudentsForm.Click += studentsController.EditButton_Click;
        }

        public DialogResult ShowDialog(List<Student> students)
        {
            this.studentsGridView.DataSource = students;

            return base.ShowDialog();
        }
    }
}
