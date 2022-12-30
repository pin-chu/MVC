using Eventsite.Models.EFModels;
using Eventsite.Models.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventsite.Models.Services
{
    public class Registers_Service
    {
        private RegisterRepository repository = new RegisterRepository();

        public void Create(Register register)
        {
            //var dataInDb = db.Registers.FirstOrDefault(x => x.Email == register.Email);
            var dataInDb = repository.FindByEmail(register.Email);

            if (dataInDb != null)
            {
                throw new Exception("Email 已經報名過了,無法再度報名");
            }

            register.CreatedTime = DateTime.Now;

            repository.Create(register);
            //db.Registers.Add(register);
            //db.SaveChanges();
        }
        public Register Find(int id)
        {
            Register register = repository.FindById(id);
            if (register == null)
            {
                throw new Exception("找不到指定的紀錄");
            }
            return register;
        }
    }
}