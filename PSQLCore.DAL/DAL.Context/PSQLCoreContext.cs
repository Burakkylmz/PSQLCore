using Microsoft.EntityFrameworkCore;
using PSQLCore.DAL.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PSQLCore.DAL.DAL.Context
{
    public class PSQLCoreContext:DbContext
    {
        public PSQLCoreContext(DbContextOptions<PSQLCoreContext> options):base(options)
        {

        }
        public DbSet<Category> Categories{ get; set; }
    }
}