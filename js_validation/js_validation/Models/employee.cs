using System.ComponentModel.DataAnnotations;

namespace js_validation.Models
{
    public class employee
    {
        [Required(ErrorMessage ="First Name is required")]
        [RegularExpression ("[A-Za-z]+",ErrorMessage ="only alphabates")]
        [Display(Name = " First Name  ")]
        public string fname { get; set; }

        [Required]
        [RegularExpression (@"[9876]\d{9}",ErrorMessage ="Invalid mobile number..")]
        [Display(Name = "Mobile No. ")]
        public string moblie { get; set; }
        [Required]
        [EmailAddress]
        [Display(Name = " Email id ")]
        public string email { get; set; }
        [Required]
        [RegularExpression("((?=.*\\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[\\W]).{6,20})", ErrorMessage ="password is weak....")]
        [Display(Name = " Password ")]
        [DataType(DataType.Password)]

        public string password { get; set; }
        [Required]
        [Compare("password",ErrorMessage ="passwords do not match.....")]
        [Display(Name = " Conform Password")]
        [DataType(DataType.Password)]


        public string cfnpswrd { get; set; }


    }
}