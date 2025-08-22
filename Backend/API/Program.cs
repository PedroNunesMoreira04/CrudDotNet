var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSwaggerGen();

var app = builder.Build();

app.Run();
