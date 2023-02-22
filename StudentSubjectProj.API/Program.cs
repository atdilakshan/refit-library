using Refit;
using StudentSubjectProj.API.Clients;
using StudentSubjectProj.API.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Set base URL for Refit -- StudentsProj.API
string studentsBaseUrl = "https://localhost:7183";
builder.Services.AddScoped<IStudentsApiClient>(x => RestService.For<IStudentsApiClient>(studentsBaseUrl));

// Set base URL for Refit -- SubjectsProj.API
string subjectsBaseUrl = "https://localhost:7021";
builder.Services.AddScoped<ISubjectsApiClient>(x => RestService.For<ISubjectsApiClient>(subjectsBaseUrl));


builder.Services.AddScoped<IStudentSubjectRepository, StudentSubjectRepository>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
