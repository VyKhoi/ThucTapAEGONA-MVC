using System.ComponentModel.DataAnnotations;

namespace ThucTapMVC.Models.Dto
{
    public class ContactsDto
    {
        [Required]
        public string FullName { set; get; }
        [Required]
        public string CompanyPhone { set; get; }
        public string BusinessPhone { set; get; }
        [Required]
        public string Email { set; get; }
        public string Message { set; get; }
    }
}
