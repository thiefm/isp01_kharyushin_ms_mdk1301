using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

using WindowsFormsApp6.Providers;
using WindowsFormsApp6.Views;
using WindowsFormsApp6.Models;

namespace WindowsFormsApp6.Controllers
{
    public class MainController
    {
        private StorageContext _context;

        private MainForm _view;

        public MainController(StorageContext context, MainForm view)
        {
            _context = context;
            _view = view;
        }

        public void StudentsButton_Click(object sender, EventArgs e)
        {
            List<Student> selectStudents = _context.Students.GetAll();

            var studentsForm = new StudentsForm(_context);
            studentsForm.ShowDialog(selectStudents);
        }

        public void GroupsButton_Click(object sender, EventArgs e)
        {
            List<StudentsGroup> selectGroups = _context.Groups.GetAll();

            var studentsForm = new GroupsForm(_context);
            studentsForm.ShowDialog(selectGroups);
        }

        public void SpecialtiesButton_Click(object sender, EventArgs e)
        {
            List<Specialty> selectSpecialties = _context.Specialties.GetAll();

            var specialtyForm = new SpecialtiesForm(_context);
            specialtyForm.ShowDialog(selectSpecialties);
        }
    }
}
