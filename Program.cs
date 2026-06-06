using ToDo.Repositoris;
using ToDo.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

builder.Services.AddScoped<ITaskService,TaskService>();
builder.Services.AddScoped<ITaskRepository,TaskRepository>();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();


var app = builder.Build();

app.UseHttpsRedirection();

app.UseSwagger();

app.UseSwaggerUI();

app.UseAuthorization();

app.MapControllers();



app.Run();
