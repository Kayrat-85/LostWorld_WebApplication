using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using theLostWorld.Service;
using theLostWorld.Domain.Repositories.Abstract;
using theLostWorld.Domain.Repositories.EntityFramework;
using theLostWorld.Service;
using theLostWorld.Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace theLostWorld
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration) => Configuration = configuration;

       
        public void ConfigureServices(IServiceCollection services)
        {
            //appsettings.json
            Configuration.Bind("Project", new Config());

            //подключаем нужный функционал приложения в качестве сервисов
            services.AddTransient<ITextFieldsRepository, EFTextFieldsRepository>();
            services.AddTransient<IServiceItemsRepository, EFServiceItemsRepository>();
            services.AddTransient<IDinosaursPredatorsRepository, EFDinosaursPredatorsRepository>();
            services.AddTransient<IDinosaursHerbivoresRepository, EFDinosaursHerbivoresRepository>();
            services.AddTransient<IDinosaursFlyingRepository, EFDinosaursFlyingRepository>();
            services.AddTransient<IDinosaursAquaticRepository, EFDinosaursAquaticRepository>();
            services.AddTransient<IMammalsPredatorsRepository, EFMammalsPredatorsRepository>();
            services.AddTransient<IMammalsHerbivoresRepository, EFMammalsHerbivoresRepository>();
            services.AddTransient<IAnthropogenesisRepository, EFAnthropogenesisRepository>();
            services.AddTransient<DataManager>();

            //подключение к БД
            services.AddDbContext<AppDbContext>(x => x.UseSqlServer(Config.ConnectionString));

            //настраиваем Identity систему 
            services.AddIdentity<IdentityUser, IdentityRole>(opts =>
            {
                opts.User.RequireUniqueEmail = true;
                opts.Password.RequiredLength = 6;
                opts.Password.RequireNonAlphanumeric = false;
                opts.Password.RequireLowercase = false;
                opts.Password.RequireUppercase = false;
                opts.Password.RequireDigit = false;
            }).AddEntityFrameworkStores<AppDbContext>().AddDefaultTokenProviders();

            //настрайка authentication cookie
            services.ConfigureApplicationCookie(options =>
            {
                options.Cookie.Name = "lostWorldAuth";
                options.Cookie.HttpOnly = true;
                options.LoginPath = "/account/login";
                options.AccessDeniedPath = "/account/accessdenied";
                options.SlidingExpiration = true;
            });

            //Настрайка политики авторизации для Admin area
            services.AddAuthorization(x =>
            {
                x.AddPolicy("AdminArea", policy => { policy.RequireRole("admin"); });
            });

            //поддержка контроллеров и представлений(MVC). 
            services.AddControllersWithViews(x => 
            {
                x.Conventions.Add(new AdminAreaAuthorization("Admin", "AdminArea"));
            })
                    .SetCompatibilityVersion(CompatibilityVersion.Version_3_0)
                                            .AddSessionStateTempDataProvider();
            //делаем совместимость с asp.net core 3.0
        }


        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
                 app.UseDeveloperExceptionPage();
            
            else
            {
                app.UseExceptionHandler("/Home/Error");
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            //подключаем поддержку статичных файлов css, js 
            app.UseStaticFiles();
            //подключаем систему маршрутизации 
            app.UseRouting();

            //подключаем аутентификацию и авторизацию
            app.UseCookiePolicy();
            app.UseAuthentication();
            app.UseAuthorization();

            //регистрируем нужные маршруты (ендпоинты)
            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("admin", 
                    "{area:exists}/{controller=Home}/{action=Index}/{id?}");
                    endpoints.MapControllerRoute("default", 
                        "{controller=Home}/{action=Index}/{id?}");
                
            });
        }
    }
}
