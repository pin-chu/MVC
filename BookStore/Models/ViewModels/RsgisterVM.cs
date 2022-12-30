using BookStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Views.ViewModels
{
    public class RsgisterVM
    {

        public int Id { get; set; }

        [Required]
        [StringLength(30)]
        public string Account { get; set; }

        [Required]
        [StringLength(50)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        [Compare(nameof(Password))]
        [DataType(DataType.Password)]

        public string ConfirmPassword { get; set; }


        [Required]
        [StringLength(256)]
        public string Email { get; set; }

        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        [StringLength(10)]
        public string Mobile { get; set; }

    }
    public static class RegisterVMExts
    {
        public static RegisterDto ToRequestDto(this RsgisterVM source)
        {
            return new RegisterDto
            {
                Account = source.Account,
                Password = source.Password,
                Email = source.Email,
                Name = source.Name,
                Mobile = source.Mobile,
            };
        }
    }
}