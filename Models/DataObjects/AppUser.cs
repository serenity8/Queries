﻿using System;
using System.Collections.Generic;
using Microsoft.AspNet.Identity;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models.DataObjects
{
    [Table("AspNetUsers")]
    public class AppUser : IUser<string>
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public bool EmailConfirmed { get; set; }
        public string PasswordHash { get; set; }
        public string SecurityStamp { get; set; }
        public string PhoneNumber { get; set; }
        public bool PhoneNumberConfirmed { get; set; }
        public bool TwoFactorEnabled { get; set; }
        public DateTime? LockoutEndDateUtc { get; set; }
        public bool LockoutEnabled { get; set; }
        public int AccessFailedCount { get; set; }
        public string UserName { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime? Birthdate { get; set; }
        
        public virtual IList<Query> Queries { get; set; }

        public AppUser()
        {
            Queries = new List<Query>();
        }
    }
}