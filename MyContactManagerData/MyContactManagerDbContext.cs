using ContactWebModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace MyContactManagerData
{
    public class MyContactManagerDbContext : DbContext
    {
        private static IConfigurationRoot _configuration;

        public DbSet<State> States { get; set; }
        public DbSet<Contact> Contacts { get; set; }

        public MyContactManagerDbContext()
        {

        }

        public MyContactManagerDbContext(DbContextOptions options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true);
            _configuration = builder.Build();
            var cnstr = _configuration.GetConnectionString("MyContactManager");
            optionsBuilder.UseSqlServer(cnstr)
;        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<State>(x =>
            {
                x.HasData(
                    new State() { Id = 1, Name = "Alabama", Abbrevation = "AL"},
                    new State() { Id = 2, Name = "Alaska", Abbrevation = "AK"},
                    new State() { Id = 3, Name = "Arizona", Abbrevation = "AZ" },
                    new State() { Id = 4, Name = "Arkansas", Abbrevation = "AR" },
                    new State() { Id = 5, Name = "California", Abbrevation = "CA" },
                    new State() { Id = 6, Name = "Colorado", Abbrevation = "CO" },
                    new State() { Id = 7, Name = "Connecticut", Abbrevation = "CT" },
                    new State() { Id = 8, Name = "Delaware", Abbrevation = "DE" },
                    new State() { Id = 9, Name = "District of Columbia", Abbrevation = "DC" },
                    new State() { Id = 10, Name = "Florida", Abbrevation = "FL" },
                    new State() { Id = 11, Name = "Georgia", Abbrevation = "GA" },
                    new State() { Id = 12, Name = "Hawaii", Abbrevation = "HI" },
                    new State() { Id = 13, Name = "Idaho", Abbrevation = "ID" },
                    new State() { Id = 14, Name = "Illinois", Abbrevation = "IL" },
                    new State() { Id = 15, Name = "Indiana", Abbrevation = "IN" },
                    new State() { Id = 16, Name = "Iowa", Abbrevation = "IA" },
                    new State() { Id = 17, Name = "Kansas", Abbrevation = "KS" },
                    new State() { Id = 18, Name = "Kentucky", Abbrevation = "KY" },
                    new State() { Id = 19, Name = "Louisiana", Abbrevation = "LA" },
                    new State() { Id = 20, Name = "Maine", Abbrevation = "ME" },
                    new State() { Id = 21, Name = "Maryland", Abbrevation = "MD" },
                    new State() { Id = 22, Name = "Massachusetts", Abbrevation = "MS" },
                    new State() { Id = 23, Name = "Michigan", Abbrevation = "MI" },
                    new State() { Id = 24, Name = "Minnesota", Abbrevation = "MN" },
                    new State() { Id = 25, Name = "Mississippi", Abbrevation = "MS" },
                    new State() { Id = 26, Name = "Missouri", Abbrevation = "MO" },
                    new State() { Id = 27, Name = "Montana", Abbrevation = "MT" },
                    new State() { Id = 28, Name = "Nebraska", Abbrevation = "NE" },
                    new State() { Id = 29, Name = "Nevada", Abbrevation = "NV" },
                    new State() { Id = 30, Name = "New Hampshire", Abbrevation = "NE" },
                    new State() { Id = 31, Name = "New Jersey", Abbrevation = "NJ" },
                    new State() { Id = 32, Name = "New Mexico", Abbrevation = "NM" },
                    new State() { Id = 33, Name = "New York", Abbrevation = "NY" },
                    new State() { Id = 34, Name = "North Carolina", Abbrevation = "NC" },
                    new State() { Id = 35, Name = "North Dakota", Abbrevation = "ND" },
                    new State() { Id = 36, Name = "Ohio", Abbrevation = "OH" },
                    new State() { Id = 37, Name = "Oklahoma", Abbrevation = "OK" },
                    new State() { Id = 38, Name = "Oregon", Abbrevation = "OR" },
                    new State() { Id = 39, Name = "Pennsylvania", Abbrevation = "PA" },
                    new State() { Id = 40, Name = "Rhode Island", Abbrevation = "RI" },
                    new State() { Id = 41, Name = "South Carolina", Abbrevation = "SC" },
                    new State() { Id = 42, Name = "South Dakota", Abbrevation = "SD" },
                    new State() { Id = 43, Name = "Tennessee", Abbrevation = "TN" },
                    new State() { Id = 44, Name = "Texas", Abbrevation = "TX" },
                    new State() { Id = 45, Name = "Utah", Abbrevation = "UT" },
                    new State() { Id = 46, Name = "Vermont", Abbrevation = "VT" },
                    new State() { Id = 47, Name = "Virginia", Abbrevation = "VA" },
                    new State() { Id = 48, Name = "Washington", Abbrevation = "WA" },
                    new State() { Id = 49, Name = "West Virginia", Abbrevation = "WV" },
                    new State() { Id = 50, Name = "Wisconsin", Abbrevation = "WI" },
                    new State() { Id = 51, Name = "Wyoming", Abbrevation = "WY" }
                    );
            });
        }
    }
}