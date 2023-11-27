using Libraria.Data.Database;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using Microsoft.Extensions.Configuration;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Libraria.Data.Repository;
using Libraria.Business.Service;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Libraria.Mediator;
using Libraria.Entity.Entities;
using Microsoft.AspNetCore.Identity;
using DinkToPdf.Contracts;
using DinkToPdf;
using Libraria.DLLManagement;
using System.IO;
using Microsoft.OpenApi.Models;

namespace Libraria
{
    public class Startup
    {
        public Startup(IConfiguration configuration , Microsoft.AspNetCore.Hosting.IHostingEnvironment hostingEnvironment)
        {
            Configuration = configuration;
            _hostingEnvironment = hostingEnvironment;
        }

        public IConfiguration Configuration { get; }
        private readonly Microsoft.AspNetCore.Hosting.IHostingEnvironment _hostingEnvironment;

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddHttpContextAccessor();

            services.AddEntityFrameworkSqlServer()
         .AddDbContext<LibrariaDbContext>(options =>
           options.UseSqlServer(Configuration.GetConnectionString("ConnStr")));
            services.AddIdentity<Perdorues, IdentityRole>()
             .AddEntityFrameworkStores<LibrariaDbContext >()
             .AddDefaultTokenProviders();
            
            services.AddTransient<IAuthMediator, AuthMediator>();
            services.AddTransient(typeof(IRepository<>), typeof(Repository<>));
            services.AddTransient<IAuthMediator, AuthMediator>();
            services.AddTransient<IAuthService, AuthService>();
            services.AddTransient<ILiberMediator, LiberMediator>();
            services.AddTransient<ILIberService, LIberService>();
            services.AddTransient<ILIbrariaService, LIbrariaService>();
            services.AddTransient<ILexuesService, LexuesService>();
            services.AddTransient<ILibrariaMediator, LibrariaMediator>();
            services.AddTransient<IAccountService, AccountService>();
            services.AddSingleton(typeof(IConverter), new SynchronizedConverter(new PdfTools()));
            services.AddTransient<ILibrariaMediator, LibrariaMediator>();

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Zomato API",
                    Version = "v1",
                    Description = "Description for the API goes here.",
                    Contact = new OpenApiContact
                    {
                        Name = "Ankush Jain",
                        Email = string.Empty,
                        Url = new Uri("https://coderjony.com/"),
                    },
                });
            });

            var wkHtmlToPdfPath = Path.Combine(_hostingEnvironment.ContentRootPath, @"wkhtmltox\\libwkhtmltox.dll");
            CustomAssemblyLoadContext context = new CustomAssemblyLoadContext();
            context.LoadUnmanagedLibrary(wkHtmlToPdfPath);
            services.AddCors(options =>
            {
                options.AddPolicy("EnableCORS", builder =>
                {
                    builder.AllowAnyOrigin()
                       .AllowAnyHeader()
                       .AllowAnyMethod();
                });
            });

            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultScheme = JwtBearerDefaults.AuthenticationScheme;
            })

           // Adding Jwt Bearer  
           .AddJwtBearer(options =>
           {
               options.SaveToken = true;
               options.RequireHttpsMetadata = false;
               options.TokenValidationParameters = new TokenValidationParameters()
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidAudience = Configuration["JWT:ValidAudience"],
                   ValidIssuer = Configuration["JWT:ValidIssuer"],
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(Configuration["JWT:Secret"]))
               };
           });
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseAuthentication();
            app.UseHttpsRedirection();
            app.UseAuthorization();
            app.UseRouting();
            app.UseCors("EnableCORS");
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

          
        }
    }
}
