using System.ComponentModel.DataAnnotations;

namespace ThucTapMVC.Models
{
    public class Contacts
    {
        [Key]
        public int Id { set; get; }
        
        public string FullName { set; get; }

        public string CompanyPhone { set; get; }
        public string BusinessPhone { set; get; }

        public string Email { set; get; }
        public string Message { set; get; }
    }
}
