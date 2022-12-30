using _12._21.Models.EFModels;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace _12._21.Models.Repository
{
    public class RegisterRepository
    {
        private AppDbContext db = new AppDbContext();

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