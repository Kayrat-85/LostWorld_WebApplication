using System;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using theLostWorld.Domain.Entities;


namespace theLostWorld.Domain
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        //конструктор
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<TextField> TextFields { get; set; }
        public DbSet<ServiceItem> ServiceItems { get; set; }
        public DbSet<DinosaursPredators> DinosaursPredator { get; set; }
        public DbSet<DinosaursHerbivores> DinosaursHerbivore { get; set; }
        public DbSet<DinosaursFlying> DinosaursFlyings { get; set; }
        public DbSet<DinosaursAquatic> DinosaursAquatics { get; set; }
        public DbSet<MammalsPredators> MammalsPredators { get; set; }
        public DbSet<MammalsHerbivores> MammalsHerbivores { get; set; }
        public DbSet<Anthropogenesis> Anthropogenesis { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                Name = "admin",
                NormalizedName = "ADMIN"
            });

            modelBuilder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "3b62472e-4f66-49fa-a20f-e7685b9565d8",
                UserName = "admin",
                NormalizedUserName = "ADMIN",
                Email = "kayrat_tekebayev@mail.ru",
                NormalizedEmail = "KAYRAT_TEKEBAYEV@MAIL.RU",
                EmailConfirmed = true,
                PasswordHash = new PasswordHasher<IdentityUser>().HashPassword(null, "dieSpinne85"),
                SecurityStamp = string.Empty
            });

            modelBuilder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                RoleId = "44546e06-8719-4ad8-b88a-f271ae9d6eab",
                UserId = "3b62472e-4f66-49fa-a20f-e7685b9565d8"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("63dc8fa6-07ae-4391-8916-e057f71239ce"),
                CodeWord = "PageIndex",
                Title = "Главная"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("70bf165a-700a-4156-91c0-e83fce0a277f"),
                CodeWord = "PageDinosaursPredators",
                Title = "Хищные динозавры"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("a463fe1a-74dd-4f2f-8f09-1ca13afdffd3"),
                CodeWord = "PageDinosaursHerbivores",
                Title = "Травоядные динозавры"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("f66c3438-7fae-4b5e-936d-b030f4dfffb1"),
                CodeWord = "PageDinosaursFlyings",
                Title = "Летающие динозавры"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("2f604579-3dd8-4048-b4ef-300484cd4a99"),
                CodeWord = "PageDinosaursAquatic",
                Title = "Водные динозавры"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("4aa76a4c-c59d-409a-84c1-06e6487a137a"),
                CodeWord = "PageNews",
                Title = "Новости"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("04e664e6-26d9-4fc7-ad2e-7cc0894a7d27"),
                CodeWord = "PageMammalsPredators",
                Title = "Хищные млекопитающие"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("8163839a-dce8-402d-be29-f57615395f28"),
                CodeWord = "PageMammalsHerbivores",
                Title = "Травояднык млекопитающие"
            });

            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("0e2f8edc-13d3-427d-9e68-ce83b3a563bf"),
                CodeWord = "PageAnthropogenesis",
                Title = "Антропогенез"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("c023faf9-369d-4cb4-a8dd-8d2ccbf3cb33"),
                CodeWord = "PageAboutMe",
                Title = "Контакты"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("67450832-3ede-4420-861f-a04d4f536e30"),
                CodeWord = "PageMyWebProject",
                Title = "О проекте"
            });
            
            //представления для Главной страницы
            //Мезозойская эра
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("14372a40-774c-4551-8215-c557ccc43c14"),
                CodeWord = "PageTriassic",
                Title = "Триасовый период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("b4aaa792-092a-4a9e-9c4d-2b6b916a65f8"),
                CodeWord = "PageJurassic",
                Title = "Юрский период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("1e7a21df-ad48-4872-a325-687f9414c361"),
                CodeWord = "PageCretaceous",
                Title = "Меловой период"
            });
            //Кайнозойская эра
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("9edf8766-b00f-4781-a358-a8650ba78507"),
                CodeWord = "PagePaleogene",
                Title = "Палеогеновый период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("6d9eecb0-2912-4883-ac8a-045a3c0c769a"),
                CodeWord = "PageNeogene",
                Title = "Неогеновый период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("6dbe2258-400e-4d1b-853d-4331cac8dec7"),
                CodeWord = "PageQuaternary",
                Title = "Четвертичный период"
            });
            //Палеозо́йская э́ра
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("38ea5137-e57d-4be5-a098-e56459caf2ed"),
                CodeWord = "PageCambrian",
                Title = "Кембрийский период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("2656ced9-2652-4319-8d73-682ae34a542b"),
                CodeWord = "PageOrdovician",
                Title = "Ордовикский период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("e5345fec-bff0-4ca4-bb70-073506051976"),
                CodeWord = "PageSilurian",
                Title = "Силурийский период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5595b92d-23ec-456c-a29d-531d052b0543"),
                CodeWord = "PageDevonian",
                Title = "Девонский период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("5a8ed9ad-6a10-499e-b475-4b693bc2da70"),
                CodeWord = "PageCarboniferous",
                Title = "Каменноугольный период"
            });
            modelBuilder.Entity<TextField>().HasData(new TextField
            {
                Id = new Guid("613faf6e-200b-4081-ac67-d0dd4d09f506"),
                CodeWord = "PagePermian",
                Title = "Пермский период"
            });
        }
    }
}
