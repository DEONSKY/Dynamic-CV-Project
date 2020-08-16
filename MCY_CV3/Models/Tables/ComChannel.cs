using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class ComChannel
    {
        [Key]
        public int ComChannelID { get; set; }
        public string Title_EN { get; set; }
        [DataType(DataType.Url)]
        public string Link { get; set; }
        public string Symbol { get; set; }
        //public int AboutID { get; set; }
        //public virtual About About { get; set; }
    }
}