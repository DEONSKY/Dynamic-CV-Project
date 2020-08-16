using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MCY_CV3.Models.Tables
{
    public class About
    {
        [Key]
        public int ID { get; set; }
        public string AboutMe { get; set; }
        //public ICollection<WorkExp> WorkExps { get; set; }
        //public ICollection<Ability> Abilities { get; set; }
        //public ICollection<ComChannel> ComChannels { get; set; }
        //public ICollection<Project> Projects { get; set; }
        //public ICollection<Hobby> Hobbies { get; set; }
        //public ICollection<Image> Images { get; set; }
        [DataType(DataType.Url)]
        public string ImageURL { get; set; }
    }
}