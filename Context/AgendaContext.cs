using Microsoft.EntityFrameworkCore;
using MvcProject.Models;

namespace MvcProject.Context;

public class AgendaContext : DbContext
{
    public AgendaContext(DbContextOptions<AgendaContext> options) : base(options) {  }

    public DbSet<Contact> Contacts;
}