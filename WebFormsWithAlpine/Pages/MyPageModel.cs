using System.ComponentModel.DataAnnotations;

namespace WebFormsWithAlpine.Pages
{
    public class MyPageModel
    {
        [Required]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int Zipcode { get; set; }
        public string Gender { get; set; }
    }
}