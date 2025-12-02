using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

var builder = WebApplication.CreateBuilder(args);

// Controllers
builder.Services.AddControllers();

// Swagger
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Carrega configuração SMTP (de appsettings + user-secrets)
builder.Services.Configure<SmtpSettings>(builder.Configuration.GetSection("Smtp"));

// Serviço de envio de e-mail
builder.Services.AddScoped<EmailService>();

var app = builder.Build();

// Swagger no desenvolvimento
if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

// Controller endpoints
app.MapControllers();

// Executa a aplicação
app.Run();


