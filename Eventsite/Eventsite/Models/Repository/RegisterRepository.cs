using Eventsite.Models.EFModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Eventsite.Models.Repository
{
    public class RegisterRepository
    {
        private Model1 db = new Model1();

        public void Create(Register register)
        {
            db.Registers.Add(register);
            db.SaveChanges();
        }

        public List<Register> GetAll()
        {
            return db.Registers.ToList();
        }

        public Register FindByEmail(string email)
        {
            return db.Registers.FirstOrDefault(x => x.Email == email);
        }
        public Register FindById(int id)
        {
            return db.Registers.Find(id);
        }

    }
}