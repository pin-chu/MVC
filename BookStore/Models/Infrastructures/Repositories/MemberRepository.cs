using BookStore.Models.DTOs;
using BookStore.Models.EFModels;
using BookStore.Models.Services.interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Web;

namespace BookStore.Models.Infrastructures.Repositories
{
    
    public class MemberRepository : IMemberRepository
    {
        private AppDbContext db = new AppDbContext();
        public void Create(RegisterDto dto)
        {
            Member member = new Member
            {
                Account = dto.Account,
                EncryptedPassword= dto.EncryptedPassword,
                Email= dto.Email,
                Name = dto.Name,
                Mobile = dto.Mobile,
                IsConfirmed = false,
                ConfirmCode= dto.ConfirmCode,

            };
            db.Members.Add(member);
            db.SaveChanges();
        }

        public bool IsExists(string account)
        {
            //var entiey = db.Members.SingleOrDefault(x => x.Account == account);
            var entiey = db.Members.FirstOrDefault( x => x.Account == account );    

            return(entiey != null );
        }
        public MemberDto Load(int memberId)
        {
            Member entity = db.Members.SingleOrDefault(x => x.Id == memberId);
            if (entity == null) return null;
            MemberDto result = new MemberDto
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
            return result;
        }
        public void ActiveRegister(int memberId)
        {
            var member = db.Members.Find(memberId);
            member.IsConfirmed= true;
            member.ConfirmCode = null;
            db.SaveChanges();
        }

        public MemberDto GetByAccount(string account)
        {
            return db.Members
               .SingleOrDefault(x => x.Account == account)
               .ToDto();
            {

            }
        }
    }
}