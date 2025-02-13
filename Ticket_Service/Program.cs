using Microsoft.EntityFrameworkCore;
using Ticket_Service.data;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<ApplicationDbContext>(options => options.UseSqlServer.builder.Configuration.GetConnectionString("DefaultConnection"));