﻿
using E_SkiLift.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_SkiLift.Persistence
{
    class UserRepository: Repository<User>, IUserRepository
    {
        public UserRepository(ERDContainer dbContext): base(dbContext) { }
        public User GetUserByCredentials(string login, string password)
        {
            return ERDContainer.Set<User>().Where(user=>user.Login==login&&user.Password==password).FirstOrDefault();
        }

        public User GetUserByLogin(string login)
        {
            return ERDContainer.Set<User>().Where(user => user.Login == login).FirstOrDefault();
        }

        public ERDContainer ERDContainer { get { return dbContext as ERDContainer; } }
        
    }
}
