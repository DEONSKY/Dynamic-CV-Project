using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class TechKnow
    {
        [Key]
        public int TechKnowID { get; set; }
        public string Description_EN { get; set; }
    }
}