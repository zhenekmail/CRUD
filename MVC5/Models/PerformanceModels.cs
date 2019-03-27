using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5.Models
{
    public class Performance
    {
        [Key]
        public int Id { get; set; }

        public byte IsDone { get; set; }

        public int SubjectId { get; set; }
        public decimal StudentId { get; set; }
    }


    public class PerformanceDBContext : DbContext
    {
        public DbSet<Performance> Performances { get; set; }
    }
}