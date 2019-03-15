namespace Votevent.Web.Data.Entities
{
    using System.ComponentModel.DataAnnotations;
    public class Candidate
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(100, ErrorMessage = "The field {0} only can contain a maximum {1} characters")]
        [Display(Name = "Name")]
        public string Name { get; set; }
        [Required]
        [Display(Name = "Proposal")]
        public string Proposal { get; set; }
        [Display(Name = "Image")]
        public string ImageUrl { get; set; }
    }
}
