using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructrer.Entities
{
    public sealed class Applicationuser:IdentityUser
    {
        [MaxLength(100)]
        public string FirstName { get; set; }=string.Empty;

        [MaxLength(100)]
        public string LastName { get; set; } = string.Empty;
    }
}
