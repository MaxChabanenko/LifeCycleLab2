namespace LifeCycleLab.Models
{
    public class Author
    {
        public Guid gid { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public List<Article> Articles { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {SecondName} {LastName}";
        }
    }
}
