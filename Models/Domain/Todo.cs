namespace SMSApp.Models.Domain
{
    public class Todo
    {
        public int TodoId { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public ICollection<Student> Students { get; set; }
    }
}
