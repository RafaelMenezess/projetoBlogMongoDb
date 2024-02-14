using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace projetoBlog.Models.Account
{
    public class AcessarModel
    {
        [Required]
        [DataType(DataType.EmailAddress)]
        [Display(Name = "Email")]
        public string Email { get; set; }

        [HiddenInput(DisplayValue = false)]
        public string RetornoUrl { get; set; }
    }
}