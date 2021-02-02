using LibraryData.EntityModels;
using Microsoft.EntityFrameworkCore;
using System;

namespace LibraryData
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Book> Books { get; set; }
        public DbSet<BranchHour> BranchHours { get; set; }
        public DbSet<CheckOut> CheckOuts { get; set; }
        public DbSet<CheckOutHistory> CheckOutHistories { get; set; }
        public DbSet<Hold> Holds { get; set; }
        public DbSet<LibraryAsset> LibraryAssets { get; set; }
        public DbSet<LibraryBranch> LibraryBranches { get; set; }
        public DbSet<LibraryCard> LibraryCards { get; set; }
        public DbSet<Patron> Patrons { get; set; }
        public DbSet<Status> Statuses { get; set; }
        public DbSet<Video> Videos { get; set; }
    }
}
