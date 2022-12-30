using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Views.ViewModels
{
    public class LoginVM
    {
        [Display(Name ="帳號")]
        [Required]
        [StringLength(30)]
        public string Account { get; set; }

        [Display(Name = "密碼")]
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
    }
}