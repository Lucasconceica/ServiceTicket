using Microsoft.EntityFrameworkCore;
using WebApi.Models;
namespace Ticket_Service.data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Ticket_Suporte> Ticket_Suporte { get; set; }
}
