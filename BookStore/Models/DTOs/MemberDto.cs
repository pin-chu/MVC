﻿using BookStore.Models.EFModels;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BookStore.Models.DTOs
{
    public class MemberDto
    {
        public int Id { get; set; }

        public string Account { get; set; }

        public string EncryptedPassword { get; set; }

        public string Email { get; set; }

        public string Name { get; set; }

        public string Mobile { get; set; }

        public bool? IsConfirmed { get; set; }

        public string ConfirmCode { get; set; }


    }
    public static class MemberExts
    {
        public static MemberDto ToDto(this Member entity)
        {
            if (entity == null) return null;
            return new MemberDto
            {
                Id = entity.Id,
                Account = entity.Account,
                EncryptedPassword = entity.EncryptedPassword,
                Email = entity.Email,
                Name = entity.Name,
                Mobile = entity.Mobile,
                IsConfirmed = entity.IsConfirmed,
                ConfirmCode = entity.ConfirmCode
            };
        }
    }
}