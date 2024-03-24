using AutoMapper.Internal;
using Epro3;
using Epro3.Application.DTOs.AdminDTOs.About;
using Epro3.Application.DTOs.AdminDTOs.Admin;
using Epro3.Application.DTOs.AdminDTOs.Class;
using Epro3.Application.DTOs.AdminDTOs.Contact;
using Epro3.Application.DTOs.AdminDTOs.Course;
using Epro3.Application.DTOs.AdminDTOs.CourseModule;
using Epro3.Application.DTOs.AdminDTOs.EntranceExam;
using Epro3.Application.DTOs.AdminDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.AdminDTOs.FAQ;
using Epro3.Application.DTOs.AdminDTOs.Student;
using Epro3.Application.DTOs.ClientDTOs.About;
using Epro3.Application.DTOs.ClientDTOs.Class;
using Epro3.Application.DTOs.ClientDTOs.Contact;
using Epro3.Application.DTOs.ClientDTOs.Course;
using Epro3.Application.DTOs.ClientDTOs.EntranceExam;
using Epro3.Application.DTOs.ClientDTOs.EntranceExamStudentResult;
using Epro3.Application.DTOs.ClientDTOs.FAQ;
using Epro3.Application.DTOs.ClientDTOs.Student;
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
using Epro3.Infrastructure.DBContext;
using Epro3.Infrastructure.Repositories;
using MediatR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.FileProviders;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Models;
using System.Reflection;
using System.Text;
using static Epro3.Application.Features.Commands.AboutCommand.CreateAboutCommand;
using static Epro3.Application.Features.Commands.AboutCommand.DeleteAboutCommand;
using static Epro3.Application.Features.Commands.AboutCommand.UpdateAboutCommand;
using static Epro3.Application.Features.Commands.ClassCommand.CreateClassCommand;
using static Epro3.Application.Features.Commands.ClassCommand.DeleteClassCommand;
using static Epro3.Application.Features.Commands.ClassCommand.UpdateClassCommand;
using static Epro3.Application.Features.Commands.ContactCommand.CreateContactCommand;
using static Epro3.Application.Features.Commands.ContactCommand.DeleteContactCommand;
using static Epro3.Application.Features.Commands.ContactCommand.UpdateContactCommand;
using static Epro3.Application.Features.Commands.CourseCommand.CreateCourseCommand;
using static Epro3.Application.Features.Commands.CourseCommand.DeleteCourseCommand;
using static Epro3.Application.Features.Commands.CourseCommand.UpdateCourseCommand;
using static Epro3.Application.Features.Commands.CourseModuleCommand.CreateCourseModuleCommand;
using static Epro3.Application.Features.Commands.CourseModuleCommand.DeleteCourseModuleCommand;
using static Epro3.Application.Features.Commands.CourseModuleCommand.UpdateCourseModuleCommand;
using static Epro3.Application.Features.Commands.EntranceExamCommand.CreateEntranceExamCommand;
using static Epro3.Application.Features.Commands.EntranceExamCommand.DeleteEntranceExamCommand;
using static Epro3.Application.Features.Commands.EntranceExamCommand.UpdateEntranceExamCommand;
using static Epro3.Application.Features.Commands.EntranceExamStudentResultCommand.CreateEntranceExamStudentResultCommand;
using static Epro3.Application.Features.Commands.EntranceExamStudentResultCommand.DeleteEntranceExamStudentResultCommand;
using static Epro3.Application.Features.Commands.EntranceExamStudentResultCommand.UpdateEntranceExamStudentResultCommand;
using static Epro3.Application.Features.Commands.FAQCommand.CreateFAQCommand;
using static Epro3.Application.Features.Commands.FAQCommand.DeleteFAQCommand;
using static Epro3.Application.Features.Commands.FAQCommand.UpdateFAQCommand;
using static Epro3.Application.Features.Commands.StudentCommand.CreateStudentCommand;
using static Epro3.Application.Features.Commands.StudentCommand.DeleteStudentCommand;
using static Epro3.Application.Features.Commands.StudentCommand.UpdateStudentCommand;
using static Epro3.Application.Features.Queries.AboutQuery.GetAllAboutAdminQuery;
using static Epro3.Application.Features.Queries.AdminQuery.AdminLogin;
using static Epro3.Application.Features.Queries.ClassQuery.GetAllClassAdminQuery;
using static Epro3.Application.Features.Queries.ClassQuery.GetClassByIdAdminQuery;
using static Epro3.Application.Features.Queries.ContactQuery.GetAllContactAdminQuery;
using static Epro3.Application.Features.Queries.ContactQuery.GetContactByIdAdminQuery;
using static Epro3.Application.Features.Queries.CourseModuleQuery.GetCourseModuleByIdAdminQuery;
using static Epro3.Application.Features.Queries.CourseQuery.GetAllCourseAdminQuery;
using static Epro3.Application.Features.Queries.CourseQuery.GetCourseByIdAdminQuery;
using static Epro3.Application.Features.Queries.EntranceExamQuery.GetAllEntranceExamAdminQuery;
using static Epro3.Application.Features.Queries.EntranceExamQuery.GetEntranceExamByIdAdminQuery;
using static Epro3.Application.Features.Queries.EntranceExamStudentResultQuery.GetAllEntranceExamStudentResultAdminQuery;
using static Epro3.Application.Features.Queries.EntranceExamStudentResultQuery.GetEntranceExamStudentResultByIdAdminQuery;
using static Epro3.Application.Features.Queries.FAQQuery.GetAllFAQAdminQuery;
using static Epro3.Application.Features.Queries.FAQQuery.GetFAQByIdAdminQuery;
using static Epro3.Application.Features.Queries.StudentQuery.GetAllStudentAdminQuery;
using static Epro3.Application.Features.Queries.StudentQuery.GetStudentByIdAdminQuery;

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
builder.Services.AddMediatR(Assembly.GetExecutingAssembly());
builder.Services.AddCors(option =>
{
    option.AddPolicy(name: "CorsPolicy",
        configurePolicy: builder => builder
        .SetIsOriginAllowed((host) => true)
        .AllowAnyMethod()
        .AllowAnyHeader()
        .AllowCredentials());
});

//UnitOfWork Dependency Injection
builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();

//DbContext Denpendency Injection
builder.Services.AddScoped<ApplicationDatabaseContext, ApplicationDatabaseContext>();

//MediatR Admin
builder.Services.AddTransient<IRequestHandler<GetAllAboutAdminQuery, IEnumerable<AboutAdminDTO>>, GetAllAboutAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateAboutCommand, Unit>, CreateAboutCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateAboutCommand, Unit>, UpdateAboutCommandHandler>();
builder.Services.AddTransient<IRequestHandler<AdminLogin, AdminAuthenDTO>, AdminLoginHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllClassAdminQuery, IEnumerable<ClassAdminDTO>>, GetAllClassAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetClassByIdAdminQuery, ClassDetailAdminDTO>, GetClassByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateClassCommand, Unit>, CreateClassCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateClassCommand, Unit>, UpdateClassCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllContactAdminQuery, IEnumerable<ContactAdminDTO>>, GetAllContactAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetContactByIdAdminQuery, ContactDetailAdminDTO>, GetContactByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateContactCommand, Unit>, CreateContactCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateContactCommand, Unit>, UpdateContactCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllCourseAdminQuery, IEnumerable<CourseAdminDTO>>, GetAllCourseAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetCourseByIdAdminQuery, CourseDetailAdminDTO>, GetCourseByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateCourseCommand, Unit>, CreateCourseCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateCourseCommand, Unit>, UpdateCourseCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllCourseAdminQuery, IEnumerable<CourseAdminDTO>>, GetAllCourseAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetCourseModuleByIdAdminQuery, CourseModuleDetailAdminDTO>, GetCourseModuleByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateCourseModuleCommand, Unit>, CreateCourseModuleCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateCourseModuleCommand, Unit>, UpdateCourseModuleCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllEntranceExamAdminQuery, IEnumerable<EntranceExamAdminDTO>>, GetAllEntranceExamAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetEntranceExamByIdAdminQuery, EntranceExamDetailAdminDTO>, GetEntranceExamByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateEntranceExamCommand, Unit>, CreateEntranceExamCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateEntranceExamCommand, Unit>, UpdateEntranceExamCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllEntranceExamStudentResultAdminQuery, IEnumerable<EntranceExamStudentResultAdminDTO>>, GetAllEntranceExamStudentResultAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetEntranceExamStudentResultByIdAdminQuery, EntranceExamStudentResultDetailAdminDTO>, GetEntranceExamStudentResultByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateEntranceExamStudentResultCommand, Unit>, CreateEntranceExamStudentResultCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateEntranceExamStudentResultCommand, Unit>, UpdateEntranceExamStudentResultCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllFAQAdminQuery, IEnumerable<FAQAdminDTO>>, GetAllFAQAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetFAQByIdAdminQuery, FAQDetailAdminDTO>, GetFAQByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateFAQCommand, Unit>, CreateFAQCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateFAQCommand, Unit>, UpdateFAQCommandHandler>();
builder.Services.AddTransient<IRequestHandler<GetAllStudentAdminQuery, IEnumerable<StudentAdminDTO>>, GetAllStudentAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<GetStudentByIdAdminQuery, StudentDetailAdminDTO>, GetStudentByIdAdminQueryHandler>();
builder.Services.AddTransient<IRequestHandler<CreateStudentCommand, Unit>, CreateStudentCommandHandler>();
builder.Services.AddTransient<IRequestHandler<UpdateStudentCommand, Unit>, UpdateStudentCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteStudentCommand, Unit>, DeleteStudentCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteFAQCommand, Unit>, DeleteFAQCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteEntranceExamCommand, Unit>, DeleteEntranceExamCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteEntranceExamStudentResultCommand, Unit>, DeleteEntranceExamStudentResultCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteCourseModuleCommand, Unit>, DeleteCourseModuleCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteCourseCommand, Unit>, DeleteCourseCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteContactCommand, Unit>, DeleteContactCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteClassCommand, Unit>, DeleteClassCommandHandler>();
builder.Services.AddTransient<IRequestHandler<DeleteAboutCommand, Unit>, DeleteAboutCommandHandler>();

//MediatR Client
builder.Services.AddTransient<IRequest<IEnumerable<AboutAdminDTO>>, GetAllAboutAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<AboutClientDTO>>, GetAllAboutClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<ClassAdminDTO>>, GetAllClassAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<ClassClientDTO>>, GetAllClassClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<ContactAdminDTO>>, GetAllContactAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<ContactClientDTO>>, GetAllContactClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<CourseAdminDTO>>, GetAllCourseAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<CourseClientDTO>>, GetAllCourseClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<EntranceExamAdminDTO>>, GetAllEntranceExamAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<EntranceExamClientDTO>>, GetAllEntranceExamClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<EntranceExamStudentResultAdminDTO>>, GetAllEntranceExamStudentResultAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<EntranceExamStudentResultClientDTO>>, GetAllEntranceExamStudentResultClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<FAQAdminDTO>>, GetAllFAQAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<FAQClientDTO>>, GetAllFAQClientQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<StudentAdminDTO>>, GetAllStudentAdminQuery>();
builder.Services.AddTransient<IRequest<IEnumerable<StudentClientDTO>>, GetAllStudentClientQuery>();

var app = builder.Build();

//app.UseMiddleware<ExceptionMiddle>();
//app.UseStatusCodePagesWithReExecute("/error/{0}");
app.UseSwagger();
app.UseSwaggerUI(option => option.SwaggerEndpoint("/swagger/v1/swagger.json", "Epro3"));

//app.UseStaticFiles(new StaticFileOptions
//{
//    FileProvider = new PhysicalFileProvider("/app/volume/Resource/Image/Course"),
//    RequestPath = "/resource/image/course"
//});

app.UseRouting();
app.UseStaticFiles();
app.UseCors("CorsPolicy");
app.UseAuthentication();
app.UseAuthorization();
app.MapControllers();

var startup = new Startup(builder.Configuration, app.Services);
startup.Configure(app);
await startup.Init();

app.Run();
