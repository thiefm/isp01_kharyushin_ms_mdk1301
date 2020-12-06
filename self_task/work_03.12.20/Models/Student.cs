namespace WindowsFormsApp6.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string Gender { get; set; }
        public string Phone { get; set; }
        public int GroupId { get; set; }
        public StudentsGroup Group { get; set; } = null;
    }
}
