namespace Votevent.Web.Data
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Votevent.Web.Data.Entities;

    public class SeedDb
    {
        private readonly DataContext context;
        private Random random;

        public SeedDb(DataContext context)
        {
            this.context = context;
            this.random = new Random();
        }

        public async Task SeedAsync()
        {
            await this.context.Database.EnsureCreatedAsync();

            if (!this.context.Candidates.Any())
            {
                this.AddCantidate("Mateo Arteaga");
                this.AddCantidate("Carlos Achipis");
                this.AddCantidate("Jhon Moncada");
                await this.context.SaveChangesAsync();
            }
        }

        private void AddCantidate(string name)
        {
            this.context.Candidates.Add(new Candidate
            {
                Name = name,
                Proposal = "Proposal Nro " +this.random.Next(100)
            });
        }
    }

}
