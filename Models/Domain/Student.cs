namespace SMSApp.Models.Domain
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Address { get; set;}

        public int emailid { get; set; }

        public int GradeId { get; set; }

        public Grade Grade { get; set; }

        public Todo Todo { get; set; }

    }
}
