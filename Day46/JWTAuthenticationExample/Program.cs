using JWTAuthenticationExample.Interfaces;
using JWTAuthenticationExample.Models;
using JWTAuthenticationExample.Services;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace JWTAuthenticationExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<JWTContext>(opts =>
            {
                opts.UseSqlServer(builder.Configuration.GetConnectionString("conn"));
            });
            builder.Services.AddScoped<IBaseRepo<string,User>,UserRepo>();
            builder.Services.AddScoped<IRepo<int,Product>,ProductRepo>();
            builder.Services.AddScoped<ProductService>();
            builder.Services.AddScoped<UserService>();
            builder.Services.AddScoped<ITokenGenerate,TokenService>();
            builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
                .AddJwtBearer(options =>
                {
                    options.TokenValidationParameters = new TokenValidationParameters
                    {
                        ValidateIssuerSigningKey = true,
                        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration["TokenKey"])),
                        ValidateIssuer = false,
                        ValidateAudience = false
                };
                });
            builder.Services.AddCors(opts =>
            {
                opts.AddPolicy("MyCors", policy =>
                {
                    policy.AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowAnyOrigin();
                });
            });
            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }
    
            app.UseAuthentication();
            app.UseCors("MyCors");
            app.UseAuthorization();
            


            app.MapControllers();

            app.Run();
        }
    }
}