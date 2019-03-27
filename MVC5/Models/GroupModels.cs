using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class Group
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; }
        public int Course { get; set; }
        public int SpecialityId { get; set; }

    }


    public class GroupDBContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
    }

}