var builder = WebApplication.CreateBuilder(args);
var jwtSettings = builder.Configuration.GetSection("JwtSettings");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder =>
{
    builder.WithOrigins("http://localhost:5173")
           .SetIsOriginAllowedToAllowWildcardSubdomains()
           .AllowAnyHeader()
           .AllowCredentials()
           .WithMethods("GET", "PUT", "POST", "DELETE", "OPTIONS")
           .SetPreflightMaxAge(TimeSpan.FromSeconds(3600));
});


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
