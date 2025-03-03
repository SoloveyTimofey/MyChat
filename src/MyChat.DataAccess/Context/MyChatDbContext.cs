using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyChat.Core.Models.ChatCluster.Entities;
using MyChat.Core.Models.ContactCluster.Entites;
using MyChat.Core.Models.Identity;
using System.Reflection;

namespace MyChat.DataAccess.Context;

public class MyChatDbContext : IdentityDbContext<ApplicationUser>
{
    public MyChatDbContext(DbContextOptions<MyChatDbContext> options) : base(options) { }

    public DbSet<Chat> Chats { get; set; }
    public DbSet<Message> Messages { get; set; }
    public DbSet<AddToContactRequest> AddToContactRequests { get; set; }
    public DbSet<Contact> Contacts { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        base.OnModelCreating(builder);
    }
}