using Microsoft.EntityFrameworkCore;
using Ticket_Service.models;
namespace Ticket_Service.data;

public class ApplicationDbContext : DbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

    public DbSet<Ticket> Tickets { get; set; }
}
