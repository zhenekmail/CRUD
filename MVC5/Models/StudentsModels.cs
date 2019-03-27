using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class Student
    {
        [Key]
        public int RegId { get; set; }

        public int Course { get; set; }
        public DateTime Enrolled { get; set; }

        public int GroupId { get; set; }
        public decimal RoomId { get; set; }

        //public virtual Group Group { get; set; }
        //public virtual Profile Profile { get; set; }
    }
   

    public class StudentDBContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
    }
}