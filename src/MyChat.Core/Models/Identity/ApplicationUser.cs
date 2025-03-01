using Microsoft.AspNetCore.Identity;
using MyChat.Core.Models.ChatCluster.Entities;
using MyChat.Core.Models.ContactCluster.Entites;

namespace MyChat.Core.Models.Identity;

public class ApplicationUser : IdentityUser
{
    public List<Chat> Chats { get; } = new();
    public List<Contact> Contacts { get; } = new();
    public List<AddToContactRequest> AddToContactRequests { get; } = new();
}