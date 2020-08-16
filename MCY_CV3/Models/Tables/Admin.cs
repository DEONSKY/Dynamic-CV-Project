using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class Admin
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        [Required]
        public string FirstKey { get; set; }
        [Required]
        public string SecondKey { get; set; }

    }
}