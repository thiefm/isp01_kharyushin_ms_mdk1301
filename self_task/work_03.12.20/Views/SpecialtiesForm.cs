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
    public partial class SpecialtiesForm : Form
    {
        public DataGridView SpecialtiesGridView
        {
            get => this.specialtiesGridView;
            set { this.specialtiesGridView = value; }
        }

        public SpecialtiesForm(StorageContext context)
        {
            InitializeComponent();

            SpecialtiesController specialtiesController = new SpecialtiesController(context, this);
            this.addButtonSpecialtiesForm.Click += specialtiesController.AddButton_Click;
            this.updateButtonSpecialtiesForm.Click += specialtiesController.UpdateButton_Click;
            this.editButtonSpecialtiesForm.Click += specialtiesController.EditButton_Click;
        }

        public DialogResult ShowDialog(List<Specialty> specialties)
        {
            this.specialtiesGridView.DataSource = specialties;

            return base.ShowDialog();
        }
    }
}
