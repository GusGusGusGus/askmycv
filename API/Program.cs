using System.Text;
using API.Data;
using API.Entities;
using API.Extensions;
using API.Intefaces;
using API.Middleware;
using API.Services;
using API.SignalR;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;

var builder = WebApplication.CreateBuilder(args);
var config =builder.Configuration;

builder.Services.AddApplicationServices(config);
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddIdentityServices(config);
builder.Services.AddSignalR();
// builder.Services.AddCors();
builder.Services.AddTransient<IEmailSender, EmailSender>();

builder.Services.Configure<AuthMessageSenderOptions>(builder.Configuration);
builder.Services.Configure<ApplicationOptions>(builder.Configuration);



var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseMiddleware<ExceptionMiddleware>();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

// app.UseRouting();

//this env will contain deployed app link and will be updated in heroku upon post_deployment script
var allowedOrigins = Environment.GetEnvironmentVariable("ALLOWED_ORIGINS")?.Split(',');
var localOrigins = new[] { "http://localhost:4200", "https://localhost:4200" };

if (allowedOrigins != null && allowedOrigins.Length > 0)
{
    app.UseCors(
        policy =>  policy.WithOrigins(allowedOrigins.Concat(localOrigins).ToArray())
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowCredentials());
}
else
{
    app.UseCors(
        policy =>  policy.WithOrigins(localOrigins)
                                .AllowAnyHeader()
                                .AllowAnyMethod()
                                .AllowCredentials());
}
 

app.UseAuthentication();

app.UseAuthorization();

app.UseDefaultFiles();
app.UseStaticFiles();

app.MapControllers();
app.MapHub<PresenceHub>("/hubs/presence");
app.MapHub<MessageHub>("/hubs/message");
app.MapFallbackToController("Index", "Fallback");

using var scope = app.Services.CreateScope();
var services = scope.ServiceProvider;

try
{
    var context = services.GetRequiredService<DataContext>();
    var userManager = services.GetRequiredService<UserManager<AppUser>>();
    var roleManager = services.GetRequiredService<RoleManager<AppRole>>();
    await context.Database.MigrateAsync();
    await Seed.SeedUsers(userManager, roleManager);
}
catch (Exception ex)
{
    var logger = services.GetRequiredService<ILogger<Program>>();
    logger.LogError(ex, "An error occurred during migration");
}



await app.RunAsync();

//IDE Changes
//added prefix _ for the private fields in settings, search 'prefix'
//removed prefix this for the private fields in settings, search 'Use this for ctor'