using CRUD_in_ASP.Net_MVC.Models;
using MySql.Data.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace CRUD_in_ASP.Net_MVC.DBContext
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class ApplicationDBContext :DbContext
    {
        public ApplicationDBContext() : base("name=DefaultConnection") {}
        public virtual DbSet<Recruitment> Rec { get; set; }
    }
}