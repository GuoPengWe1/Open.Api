using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Open.Tool.Appsettings;
using Open.User.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Open.User.Models
{
    public class UserDbContext : DbContext
    {

        /// <summary>
        /// 用户信息
        /// </summary>
        public DbSet<UserInfo> userInfos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(_configuration.GetConnectionString("OpenApiDbString"));
            optionsBuilder.UseSqlServer(AppSettingsJson.Configuration.GetConnectionString("DefaultOpenApiDbString"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserInfo>()
                .HasIndex(x=>x.UserName);
            modelBuilder.Entity<UserInfo>()
                .HasKey(x=>x.Id);
        }
    }
}
