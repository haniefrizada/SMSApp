namespace SMSApp.Models.Domain
{
    public class Grade
    {
        public Guid GradeId { get; set; }

        public string Subject { get; set; }

        public int Average { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
