var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World from .NET 9!");

app.Run();

app.MapPost("/Login", (Dominio.DTOs.LoginDTO LoginDTO) =>
{
    if (LoginDTO.Email == "adm@teste.com" && LoginDTO.Password == "123456")
    {
        return Results.Ok("Login successful");
    }
    else
    {
        return Results.Unauthorized();
    }
});

public class LoginDTO
{
    public required string Email { get; set; }
    public required string Password { get; set; }
} 
