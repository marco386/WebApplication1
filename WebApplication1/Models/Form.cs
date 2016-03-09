using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class Form
    {
        [Key]
        public int Id { get; set; }

        [Required()]
        public string Name { get; set; }

        [Required()]
        public string Address { get; set; }

        [Required()]
        [DataType(DataType.PhoneNumber)]
        public int Phone { get; set; }

        [Required()]
        [DataType(DataType.Date)]
        public string Birthdate { get; set; }

        public string Message { get; set; }
    }
}