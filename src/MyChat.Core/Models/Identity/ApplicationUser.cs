using Microsoft.AspNetCore.Identity;
using MyChat.Core.Models.ChatCluster.Entities;
using MyChat.Core.Models.ContactCluster.Entites;

namespace MyChat.Core.Models.Identity;

public class ApplicationUser : IdentityUser
{
    //public List<Contact> Contacts { get; } = new();
    //public List<AddToContactRequest> AddToContactRequests { get; } = new();
    public List<Contact> ContactsAsFirstUser { get; } = new();
    public List<Contact> ContactsAsSecondUser { get; } = new();
    public List<AddToContactRequest> AddToContactRequestsAsSender { get; } = new();
    public List<AddToContactRequest> AddToContactRequestsAsReceiver { get; } = new();
}