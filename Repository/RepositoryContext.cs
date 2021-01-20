using Entities.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Globalization;

namespace Repository
{
    public class RepositoryContext : DbContext
    {
        public RepositoryContext(DbContextOptions options)
            : base(options)
        {
        }

        public DbSet<Owner> Owners { get; set; }
        public DbSet<Account> Accounts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Owner>().HasData(
                new Owner
                {
                    Id = new Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906"),
                    Name = "John Keen",
                    DateOfBirth = DateTime.ParseExact("1980-12-05", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Address = "61 Wellfield Road"

                },
                new Owner
                {
                    Id = new Guid("261e1685-cf26-494c-b17c-3546e65f5620"),
                    Name = "Anna Bosh",
                    DateOfBirth = DateTime.ParseExact("1974-11-14", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Address = "27 Colored Row"
                },
                new Owner
                {
                    Id = new Guid("66774006-2371-4d5b-8518-2177bcf3f73e"),
                    Name = "Nick Somion",
                    DateOfBirth = DateTime.ParseExact("1998-12-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Address = "North sunny address 102"
                },
                new Owner
                {
                    Id = new Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937"),
                    Name = "Sam Query",
                    DateOfBirth = DateTime.ParseExact("1990-04-22", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Address = "91 Western Roads"
                },
                new Owner
                {
                    Id = new Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6"),
                    Name = "Martin Miller",
                    DateOfBirth = DateTime.ParseExact("1983-05-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    Address = "3 Edgar Buildings"
                });
            
            modelBuilder.Entity<Account>().HasData(
                new Account
                {
                    Id = new System.Guid("03e91478-5608-4132-a753-d494dafce00b"),
                    DateCreated = DateTime.ParseExact("2003-12-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Domestic",
                    OwnerId = new System.Guid("f98e4d74-0f68-4aac-89fd-047f1aaca6b6")
                },
                new Account
                {
                    Id = new System.Guid("356a5a9b-64bf-4de0-bc84-5395a1fdc9c4"),
                    DateCreated = DateTime.ParseExact("1996-02-15", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Domestic",
                    OwnerId = new System.Guid("261e1685-cf26-494c-b17c-3546e65f5620")
                },
                new Account
                {
                    Id = new System.Guid("371b93f2-f8c5-4a32-894a-fc672741aa5b"),
                    DateCreated = DateTime.ParseExact("1999-05-04", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Domestic",
                    OwnerId = new System.Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new System.Guid("670775db-ecc0-4b90-a9ab-37cd0d8e2801"),
                    DateCreated = DateTime.ParseExact("1999-12-21", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Savings",
                    OwnerId = new System.Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new System.Guid("a3fbad0b-7f48-4feb-8ac0-6d3bbc997bfc"),
                    DateCreated = DateTime.ParseExact("2010-05-28", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Domestic",
                    OwnerId = new System.Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937")
                },
                new Account
                {
                    Id = new System.Guid("aa15f658-04bb-4f73-82af-82db49d0fbef"),
                    DateCreated = DateTime.ParseExact("1999-05-12", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Foreign",
                    OwnerId = new System.Guid("24fd81f8-d58a-4bcc-9f35-dc6cd5641906")
                },
                new Account
                {
                    Id = new System.Guid("c6066eb0-53ca-43e1-97aa-3c2169eec659"),
                    DateCreated = DateTime.ParseExact("1996-02-16", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Foreign",
                    OwnerId = new System.Guid("261e1685-cf26-494c-b17c-3546e65f5620")
                },
                new Account
                {
                    Id = new System.Guid("eccadf79-85fe-402f-893c-32d3f03ed9b1"),
                    DateCreated = DateTime.ParseExact("2010-06-20", "yyyy-MM-dd", CultureInfo.InvariantCulture),
                    AccountType = "Foreign",
                    OwnerId = new System.Guid("a3c1880c-674c-4d18-8f91-5d3608a2c937")
                });
        }
    }
}
