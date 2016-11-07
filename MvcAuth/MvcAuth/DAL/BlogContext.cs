using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using MvcAuth.Models;

namespace MvcAuth.DAL
{
    public class BlogContext : ApplicationDbContext
    {
        public virtual DbSet<BlogPost> Posts { get; set; }
    }
}