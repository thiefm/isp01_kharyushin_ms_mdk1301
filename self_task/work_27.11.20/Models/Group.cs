namespace WindowsFormsApp5.Models
{
    class Group
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Year { get; set; }
        public int SpecialtyId { get; set; }
        public Specialty Specialty { get; set; } = null;
    }
}
