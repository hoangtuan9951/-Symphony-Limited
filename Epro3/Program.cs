using AutoMapper.Internal;
using Epro3;
using Epro3.Application.Features.Commands.AboutCommand;
using Epro3.Application.Features.Commands.ClassCommand;
using Epro3.Application.Features.Commands.ContactCommand;
using Epro3.Application.Features.Commands.CourseCommand;
using Epro3.Application.Features.Commands.CourseModuleCommand;
using Epro3.Application.Features.Commands.EntranceExamCommand;
using Epro3.Application.Features.Commands.EntranceExamStudentResultCommand;
using Epro3.Application.Features.Commands.FAQCommand;
using Epro3.Application.Features.Commands.StudentCommand;
using Epro3.Application.Features.Queries.AboutQuery;
using Epro3.Application.Features.Queries.AdminQuery;
using Epro3.Application.Features.Queries.ClassQuery;
using Epro3.Application.Features.Queries.ContactQuery;
using Epro3.Application.Features.Queries.CourseModuleQuery;
using Epro3.Application.Features.Queries.CourseQuery;
using Epro3.Application.Features.Queries.EntranceExamQuery;
using Epro3.Application.Features.Queries.EntranceExamStudentResultQuery;
using Epro3.Application.Features.Queries.FAQQuery;
using Epro3.Application.Features.Queries.StudentQuery;
using Epro3.Application.Helpers;
using Epro3.Domain.Interfaces.IRepository.Architecture;
using Epro3.Domain.Interfaces.IRepository.Epro3;
using Epro3.Infrastructure.DBContext;
using Epro3.Infrastructure.Repositories;
using Epro3.Infrastructure.Repositories.Epro3;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
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


builder.Services.AddAuthentication(JwtBearerDefaults.AuthenticationScheme)
    .AddJwtBearer(options =>
    {
        options.TokenValidationParameters = new TokenValidationParameters
        {
            ValidateAudience = false,
            ValidateIssuer = false,
            ValidateIssuerSigningKey = true,
            IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(builder.Configuration.GetSection("JwtSettings:Key").Value!)),
            ClockSkew = TimeSpan.Zero
        };
    });

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

//MediatR Command
builder.Services.AddMediatR(typeof(CreateAboutCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteAboutCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateAboutCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateClassCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteClassCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateClassCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateContactCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteContactCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateContactCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateCourseCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteCourseCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateCourseCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateCourseModuleCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteCourseModuleCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateCourseModuleCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateEntranceExamCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteEntranceExamCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateEntranceExamCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateEntranceExamStudentResultCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteEntranceExamStudentResultCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateEntranceExamStudentResultCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateFAQCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteFAQCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateFAQCommand).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(CreateStudentCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(DeleteStudentCommand).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(UpdateStudentCommand).GetTypeInfo().Assembly);

//MediatR Query
builder.Services.AddMediatR(typeof(GetAllAboutAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllAboutClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(AdminLogin).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllClassAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetClassByIdAdminQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetClassByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetClassByIdClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllContactAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllContactClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetContactByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetContactByIdClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllCourseModuleAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllCourseModuleClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetCourseModuleByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetCourseModuleByIdClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllCourseAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllCourseClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetCourseByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetCourseByIdClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetSixLatestCourseClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllEntranceExamAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetLatestEntranceExamClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetEntranceExamByIdAdminQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllEntranceExamStudentResultAdminQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetLastOverEntranceExamClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetEntranceExamStudentResultDetailAdminQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllFAQAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllFAQClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetFAQByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetFAQByIdClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetAllStudentAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetAllStudentClientQuery).GetTypeInfo().Assembly);

builder.Services.AddMediatR(typeof(GetStudentByIdAdminQuery).GetTypeInfo().Assembly);
builder.Services.AddMediatR(typeof(GetStudentByIdClientQuery).GetTypeInfo().Assembly);

//UnitOfWork Dependency Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
builder.Services.AddScoped<IStudentIdRepository, StudentIdRepository>();

//DbContext Denpendency Injection
builder.Services.AddScoped<ApplicationDatabaseContext, ApplicationDatabaseContext>();

var app = builder.Build();

//app.UseMiddleware<ExceptionMiddle>();
//app.UseStatusCodePagesWithReExecute("/error/{0}");
app.UseSwagger();
app.UseSwaggerUI(option => option.SwaggerEndpoint("/swagger/v1/swagger.json", "Epro3"));

app.UseRouting();
app.UseCors("CorsPolicy");

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/volume/Resource/Image/Course"),
    RequestPath = "/resource/image/course"
});

app.UseStaticFiles(new StaticFileOptions
{
    FileProvider = new PhysicalFileProvider("/app/volume/Resource/Image/Other"),
    RequestPath = "/resource/image/other"
});

app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

var startup = new Startup(builder.Configuration, app.Services);
startup.Configure(app);
await startup.Init();

app.Run();
