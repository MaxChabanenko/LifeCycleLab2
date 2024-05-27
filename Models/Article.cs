namespace LifeCycleLab.Models
{
    public class Article
    {
        public Guid gid { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public DateTime PublishDate { get; set; }
        public DateTime LastModifiedDate { get; set; }
        public List<Author> Authors { get; set; }
        public Author Author { get { return Authors.FirstOrDefault(); } }

        public override string ToString()
        {
            return Title;
        }
    }
}
