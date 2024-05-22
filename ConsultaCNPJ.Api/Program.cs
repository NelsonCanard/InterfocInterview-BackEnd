var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
     .AllowAnyOrigin()
     .AllowAnyMethod()
     .SetIsOriginAllowed((host) => true)
     .AllowAnyHeader());


app.MapControllerRoute(
    name: "default",
    pattern: "{controller=CNPJ}/{action=CadastrarCNPJ}/{cnpj?}");

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
