using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Codefirst_NguyenThiThuong_2243.Models;
using Microsoft.EntityFrameworkCore;

namespace Codefirst_NguyenThiThuong_2243.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Student> Students {get;set;}
    }
}
