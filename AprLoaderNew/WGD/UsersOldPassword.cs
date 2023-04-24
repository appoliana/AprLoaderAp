using System;
using System.Collections.Generic;

namespace AprLoaderNew.Models
{
    public partial class UsersOldPassword
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; } = null!;

        public virtual User User { get; set; } = null!;
    }
}
