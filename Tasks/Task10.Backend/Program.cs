using Task10.Backend.Data;
using Task10.Backend.Mapper;
using Task10.Backend.Repositories;
using Task10.Backend.Repositories.IRepositories;

var builder = WebApplication.CreateBuilder(args);


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<DepositDbContext>();
builder.Services.AddScoped<IDepositRepository, PostgresDepositRepository>();

builder.Services.AddAutoMapper(typeof(AutoMapperProfiles));
var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
