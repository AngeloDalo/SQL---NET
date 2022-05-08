var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();

var app = builder.Build();

app.UseCors(options =>
    options 
        .WithOrigins("http://localhost:4200")
        .WithMethods("POST", "PUT", "DELATE", "GET")
        .AllowAnyHeader()
);

app.MapControllers();

app.Run();
 