using Magnum.Model.Nahrung;
using Magnum.Model.Nahrung.Data;
using Microsoft.EntityFrameworkCore;

namespace Magnum.Api.Models
{
    public class GerichtDbContext : DbContext
    {
        public GerichtDbContext(DbContextOptions<GerichtDbContext> options) : base(options)
        { }

        public DbSet<GerichtData> GerichtData { get; set; }
        public DbSet<ZutatData> ZutatData { get; set; }
        public DbSet<BeigabeData> ZutatenBeigaben { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);


            modelBuilder.Entity<GerichtData>()
                .HasKey(gericht => gericht.GerichtId);

            modelBuilder.Entity<ZutatData>()
                .HasKey(zutat => zutat.ZutatId);

            modelBuilder.Entity<BeigabeData>()
                .HasKey(beigabe => new { beigabe.ZutatenId, beigabe.GerichtId });

            var extraktor = new NahrungDataExtraktor();

            AddGerichte(modelBuilder, extraktor);
            AddZutaten(modelBuilder, extraktor);

        }

        private void AddGerichte(ModelBuilder modelBuilder, NahrungDataExtraktor extraktor)
        {
            AddGericht(modelBuilder, extraktor, Gerichte.BACKOFEN_FISCH);
            AddGericht(modelBuilder, extraktor, Gerichte.BOHNEN_UND_KICHERERBSENNUDELN);
            AddGericht(modelBuilder, extraktor, Gerichte.BROT_MIT_KÖRNIGEM_FRISCHKÄSE);
            AddGericht(modelBuilder, extraktor, Gerichte.EINE_BANANE);
            AddGericht(modelBuilder, extraktor, Gerichte.EIN_BUENO);
            AddGericht(modelBuilder, extraktor, Gerichte.GEBACKENE_BOHNEN_100G);
            AddGericht(modelBuilder, extraktor, Gerichte.GEFÜLLTE_TORTELLINI_SUPPE);
            AddGericht(modelBuilder, extraktor, Gerichte.HAFERFLOCKEN_MIT_MILCH);
            AddGericht(modelBuilder, extraktor, Gerichte.RÜHREI);
            AddGericht(modelBuilder, extraktor, Gerichte.HANDVOLL_MANDELN);
            AddGericht(modelBuilder, extraktor, Gerichte.KARTOFFELBREI_EIN_KILO);
        }

        private void AddGericht(ModelBuilder modelBuilder, NahrungDataExtraktor extraktor, Gericht gericht)
        {
            var gerichtDataMitZutaten = extraktor.ExtrahiereGerichtData(gericht);
            modelBuilder.Entity<GerichtData>().HasData(gerichtDataMitZutaten.Item1);
            foreach (BeigabeData beigabeData in gerichtDataMitZutaten.Item2) 
            {
                modelBuilder.Entity<BeigabeData>().HasData(beigabeData);
            }
        }

        private void AddZutaten(ModelBuilder modelBuilder, NahrungDataExtraktor extraktor) 
        {
            foreach (ZutatData zutatData in extraktor.GetZutatData())
            { 
                modelBuilder.Entity<ZutatData>().HasData(zutatData);            
            }
        }

    }
}
