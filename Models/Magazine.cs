namespace LifeCycleLab.Domain
{
    public class Magazine
    {
        public Guid gid { get; set; }
        public string Title { get; set; }
        public string Issue { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public List<Article> Articles { get; set; }
    }
}
