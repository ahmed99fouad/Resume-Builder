using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructrer.Entities
{
    public sealed class ApplicationRole:IdentityRole
    {
        public bool IsDeleteed { get; set; }
        public bool IsDefulte { get; set; }
    }
}
