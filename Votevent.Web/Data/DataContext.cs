namespace Votevent.Web.Data
{
    using Microsoft.EntityFrameworkCore;
    using Entities;

    public class DataContext : DbContext
    {
        public DbSet<Candidate> Candidates { get; set; }

        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

    }
}
