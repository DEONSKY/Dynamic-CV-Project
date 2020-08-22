using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class Ability
    {
        [Key]
        public int AbilityID { get; set; }
        public string Description_EN { get; set; }
        public string Symbol { get; set; }
        //public int AboutID { get; set; }
        //public virtual About About { get; set; }
    }
}