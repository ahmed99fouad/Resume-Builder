using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructrer.Entities
{
    public class Resume
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string UserId { get; set; } // Link to the authenticated user

        [Required]
        public string FullName { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        public string Education { get; set; }

        public string WorkExperience { get; set; }

        public string Skills { get; set; }

        public string Certifications { get; set; }
    }
}

