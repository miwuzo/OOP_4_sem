﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace laba9
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Comment> Comments { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectStr = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
            optionsBuilder.UseSqlServer(connectStr);
        }

        public void UpdateUserAndComment(int userId, string newLogin, string newPassword, string newText, DateTime date)
        {
            var user = Users.FirstOrDefault(u => u.Id == userId);
            if (user != null)
            {
                user.Login = newLogin;
                user.Password = newPassword;
                SaveChanges();
            }

            var comment = Comments.FirstOrDefault(c => c.UserId == userId && c.DateTime == date);
            if (comment != null)
            {
                comment.Text = newText;
                SaveChanges();
            }
        }

    }
}
