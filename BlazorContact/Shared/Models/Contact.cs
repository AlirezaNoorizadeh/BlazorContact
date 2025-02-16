using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorContact.Shared.Models
{
    public class Contact
    {
        [Key]
        public int ContactId { get; set; }
        [Required]
        [MaxLength(300)]
        public string FullName { get; set; }
        [Required]
        [MaxLength(300)]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [MaxLength(300)]
        public string Mobile { get; set; }
        [Required]
        [MaxLength(800)]
        public string Address { get; set; }

    }
}
