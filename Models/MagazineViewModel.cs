using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace LifeCycleLab.Models
{
    public class MagazineViewModel
    {

        [Required(ErrorMessage = "Title is required.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Issue is required.")]
        public string Issue { get; set; }

        [Required(ErrorMessage = "Publish Date is required.")]
        [DataType(DataType.Date)]
        public DateTime PublishDate { get; set; }

        [Required(ErrorMessage = "Please select an article(s).")]
        public List<Guid> SelectedArticlesId { get; set; }

        [ValidateNever] 
        public List<Article> Articles { get; set; }
    }
}
