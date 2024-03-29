﻿using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
    public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-2MVTJ39\\SQLEXPRESS;database=TraversalDB;integrated security=true;");
        }
        public DbSet<About> abouts  { get; set; }
        public DbSet<About2> about2s { get; set; }
        public DbSet<Destination> destinations { get; set; }
        public DbSet<Feature> features  { get; set; }
        public DbSet<Feature2> feature2s { get; set; }
        public DbSet<Guide> guides { get; set; }
        public DbSet<NewsLetter> newsLetters { get; set; }
        public DbSet<SubAbout> subAbouts { get; set; }
        public DbSet<Testimonial> testimonials { get; set; }
    }
}
