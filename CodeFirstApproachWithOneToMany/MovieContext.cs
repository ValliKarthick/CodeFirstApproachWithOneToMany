

using System.Data.Entity;

namespace CodeFirstApproachWithOneToMany
{
    public class MovieContext : DbContext
    {
        public MovieContext() : base("Name=MovieConnectionstring") { }
        //public DbSet<MovieModel> movieModels { get; set; }
        public DbSet<DirectorModel> directorModels { get; set; }
        public DbSet<DirectorAddress> directorAddresses { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<DirectorModel>()
            //   .HasRequired(property => property.Address)
            //   .WithRequiredPrincipal(ad => ad.DirectorModel);

            modelBuilder.Entity<DirectorModel>().
                HasMany(property => property.movieModels).
                WithRequired(property => property.directorModel).
                HasForeignKey(property => property.DirectorId).WillCascadeOnDelete();

            //modelBuilder.Entity<DirectorModel>()
            //.HasMany<MovieModel>(s => s.movieModels)
            //.WithMany(c => c.directorModels)
            //.Map(cs =>
            //{
            //    cs.MapLeftKey("MovieRefId");
            //    cs.MapRightKey("DirectorRefId");
            //});
        }
    }
}
