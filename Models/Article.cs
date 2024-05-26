namespace LifeCycleLab.Domain
{
    public class Article
    {
        public Guid gid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public Author Author { get; set; }
    }
}
