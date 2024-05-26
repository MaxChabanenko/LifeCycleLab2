using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LifeCycleLab.Models
{
    public class ArticleViewModel
    {

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Content is required.")]
        public string Content { get; set; }

        [Required(ErrorMessage = "Publish Date is required.")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Please select an author(s).")]
        public List<Guid> SelectedAuthorId { get; set; }

        [ValidateNever] 
        public List<Author> Authors { get; set; }
    }
}
