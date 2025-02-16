using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlazorContact.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorContact.Shared.Data
{
    public class ContactDbContext:DbContext
    {
        //public ContactDbContext(DbContextOptions<ContactDbContext> options)
        //:base(options)
        //{
            
        //}

        public DbSet<Contact> Contacts { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\ARNZ1;Initial Catalog=MyContactDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
            base.OnConfiguring(optionsBuilder);
        }
    }
}
