using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MyChat.Core.Models.Identity;
using System.Reflection;

namespace MyChat.DataAccess.Context;

internal class MyChatDbContext : IdentityDbContext<ApplicationUser>
{
    public MyChatDbContext(DbContextOptions<MyChatDbContext> options) : base(options) { }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}