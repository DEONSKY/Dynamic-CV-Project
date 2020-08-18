using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class WorkExp
    {
        [Key]
        public int WorkExpID { get; set; }
        public string Company { get; set; }
        public string Position { get; set; }
        [DataType(DataType.Date)]
        public DateTime? StartDate { get; set; }
        [DataType(DataType.Date)]
        public DateTime? EndDate { get; set; }
        //public int AboutID { get; set; }
        //public virtual About About { get; set; }
    }
}