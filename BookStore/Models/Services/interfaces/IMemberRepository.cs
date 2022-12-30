using BookStore.Models.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookStore.Models.Services.interfaces
{
    public interface IMemberRepository
    {
        bool IsExists(string account);

        void Create(RegisterDto dto);

        MemberDto Load(int memberId);
        void ActiveRegister(int memberId);
        MemberDto GetByAccount(string account);
    }
}
