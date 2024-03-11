using Epro3;
using Epro3.Domain.Helpers;
using Epro3.Domain.Interfaces.IRepository;
using Epro3.Domain.Interfaces.IService.IAdminService;
using Epro3.Domain.Interfaces.IService.IApplicationService;
using Epro3.Infrastructure.DBContext;
using Epro3.Infrastructure.Repositories;
using Epro3.Service.AdminService;
using Epro3.Service.ApplicationService;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("default");
builder.Services.AddDbContext<ApplicationDatabaseContext>(options =>
            options.UseMySql(connectionString,
            ServerVersion.AutoDetect(connectionString)));

builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new OpenApiInfo { Title = "Epro3Api", Version = "v1" });

    var securityScheme = new OpenApiSecurityScheme
    {
        Name = "Authorization",
        Description = "Enter JWT Bearer token",
        In = ParameterLocation.Header,
        Type = SecuritySchemeType.Http,
        Scheme = "bearer",
        BearerFormat = "JWT"
    };
    c.AddSecurityDefinition("Bearer", securityScheme);

    var securityRequirement = new OpenApiSecurityRequirement
    {
        {
            new OpenApiSecurityScheme
            {
                Reference = new OpenApiReference
                {
                    Type = ReferenceType.SecurityScheme,
                    Id = "Bearer"
                }
            },
            new string[] {}
        }
    };
    c.AddSecurityRequirement(securityRequirement);
});


//builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
//    .AddJwtBearer(options =>
//    {
//        options.TokenValidationParameters = new TokenValidationParameters
//        {
//            ValidateAudience = false,
//            ValidateIssuer = false,
//            ValidateIssuerSigningKey = true,
//            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtSettings:Key").Value!)),
//            ClockSkew = TimeSpan.Zero
//        };
//    });

//UnitOfWork Dependency Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//Service Dependency Injection
builder.Services.AddScoped<ICourseServiceApplication, CourseServiceApplication>();

//Admin Service Dependency Injection
builder.Services.AddScoped<ICourseServiceAdmin, CourseServiceAdmin>();

//Repository Dependency Injection
builder.Services.AddScoped<ICourseRepository, CourseRepository>();

//DbContext Denpendency Injection
builder.Services.AddScoped<ApplicationDatabaseContext, ApplicationDatabaseContext>();

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MappingProfiles));
builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "CorsPolicy",
        configurePolicy: builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

var app = builder.Build();

//app.UseMiddleware<ExceptionMiddle>();
//app.UseStatusCodePagesWithReExecute("/error/{0}");
app.UseSwagger();
app.UseSwaggerUI(option => option.SwaggerEndpoint("/swagger/v1/swagger.json", "Epro3"));

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/volume/Resource/Image/Course"),
    RequestPath = "/resource/image/course"
});

app.UseRouting();
app.UseStaticFiles();
app.UseCors("CorsPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

var startup = new Startup(builder.Configuration, app.Services);
startup.Configure(app);

app.Run();
