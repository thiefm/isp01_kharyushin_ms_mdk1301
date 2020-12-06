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
    public partial class GroupsForm : Form
    {
        public DataGridView GroupsGridView
        {
            get => this.groupsGridView;
            set { this.groupsGridView = value; }
        }

        public GroupsForm(StorageContext context)
        {
            InitializeComponent();

            this.groupsGridView.AutoGenerateColumns = false;

            GroupsController groupsController = new GroupsController(context, this);
            this.groupsGridView.CellFormatting += groupsController.GroupsGridView_CellFormatting;
            this.addButtonGroupsForm.Click += groupsController.AddButton_Click;
            this.updateButtonGroupsForm.Click += groupsController.UpdateButton_Click;
            this.editButtonGroupsForm.Click += groupsController.EditButton_Click;
        }

        public DialogResult ShowDialog(List<StudentsGroup> groups)
        {
            this.groupsGridView.DataSource = groups;

            return base.ShowDialog();
        }
    }
}
