using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class AmSubject
    {
        public AmSubject()
        {
            AccessMatrices = new HashSet<AccessMatrix>();
            UserGroups = new HashSet<UserGroup>();
            Users = new HashSet<User>();
        }

        public int Id { get; set; }
        public int Type { get; set; }
        public string Name { get; set; } = null!;
        public string LocName { get; set; } = null!;
        public string? Description { get; set; }
        public int Code { get; set; }

        public virtual ICollection<AccessMatrix> AccessMatrices { get; set; }
        public virtual ICollection<UserGroup> UserGroups { get; set; }
        public virtual ICollection<User> Users { get; set; }
    }
}
