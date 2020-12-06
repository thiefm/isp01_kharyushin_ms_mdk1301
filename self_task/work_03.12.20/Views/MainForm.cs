using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Controllers;

namespace WindowsFormsApp6
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            var context = new StorageContext();

            MainController mainController = new MainController(context, this);
            this.studentsButtonMainForm.Click += mainController.StudentsButton_Click;
            this.groupsButtonMainForm.Click += mainController.GroupsButton_Click;
            this.specialtiesButtonMainForm.Click += mainController.SpecialtiesButton_Click;
        }
    }
}
