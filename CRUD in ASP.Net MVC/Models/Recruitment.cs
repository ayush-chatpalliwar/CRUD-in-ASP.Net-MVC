using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CRUD_in_ASP.Net_MVC.Models
{
    [Table("recruitment", Schema = "public")]
    public class Recruitment
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string Language { get; set; }
        public int Experience { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
    }
}