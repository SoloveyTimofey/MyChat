using MyChat.Core.Errors;
using MyChat.Core.Models.ContactCluster.Enums;
using MyChat.Core.Models.ContactCluster.ValuesObjects;
using MyChat.Core.Models.Identity;
using MyChat.Core.Shared;

namespace MyChat.Core.Models.ContactCluster.Entites;

public class AddToContactRequest
{
    #pragma warning disable
    private AddToContactRequest() { } // EF Core constructor
    #pragma warning enable

    public AddToContactRequest(AddToContactRequestId id, string senderId, string receiverId)
    {
        Id = id;
        SenderId = senderId;
        ReceiverId = receiverId;
        Status = AddToContactRequestStatus.Pending;
    }
    public AddToContactRequestId Id { get; }
    public AddToContactRequestStatus Status { get; private set; }

    public string SenderId { get; }
    public ApplicationUser Sender { get; } = null!;

    public string ReceiverId { get; }
    public ApplicationUser Receiver { get; } = null!;

    public Result Reject()
    {
        if (Status != AddToContactRequestStatus.Pending)
        {
            return Result.Failure(CoreErrors.AddToContactRequest.NotPending);
        }

        Status = AddToContactRequestStatus.Rejected;
        return Result.Success();
    }

    public Result Accept()
    {
        if (Status != AddToContactRequestStatus.Pending)
        {
            return Result.Failure(CoreErrors.AddToContactRequest.NotPending);
        }

        Status = AddToContactRequestStatus.Accepted;
        return Result.Success();
    }
}