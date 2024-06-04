using BookAPI.Data;
using BookAPI.Repository;
using BookAPI.Services;
using BookWebAPI.Repositories;
using BookWebAPI.Services;
using Microsoft.EntityFrameworkCore;


namespace BookAPI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);


            builder.Services.AddControllers();

            builder.Services.AddCors(options => options.AddDefaultPolicy(builder => builder.WithOrigins("http://localhost:4200").AllowAnyMethod().AllowAnyHeader()));

            // Add services to the container.

            var connectionString = builder.Configuration.GetConnectionString("defaultConnection");
            //assign the connection string to ApplicationDbContext class for CRUD
            builder.Services.AddDbContext<ApplicationDbContext>(op => op.UseSqlServer(connectionString));

            //inject the services in project
            builder.Services.AddScoped<IBookRepo, BookRepo>();
            builder.Services.AddScoped<IBookService, BookService>();
            builder.Services.AddScoped<IStudentRepo, StudentRepo>();
            builder.Services.AddScoped<IStudentService, StudentService>();

            builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();



           /* builder.Services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo { Title = "WebApiDemo", Version = "v1" });
            });
*/
          


            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseAuthorization();
            app.UseCors();

            



            app.MapControllers();

            app.Run();
        }
    }
}