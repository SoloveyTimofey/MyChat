using MyChat.Core.Errors;
using MyChat.Core.Models.ContactCluster.Enums;
using MyChat.Core.Models.ContactCluster.ValuesObjects;
using MyChat.Core.Models.Identity;
using MyChat.Core.Shared;

namespace MyChat.Core.Models.ContactCluster.Entites;

public class AddToContactRequest
{
    public AddToContactRequest(AddToContactRequestId id, string senderId, string receiverId)
    {
        Id = id;
        SenderId = senderId;
        ReceiverId = receiverId;
        AddToContactRequestStatus = AddToContactRequestStatus.Pending;
    }
    public AddToContactRequestId Id { get; }
    public AddToContactRequestStatus AddToContactRequestStatus { get; private set; }

    public string SenderId { get; }
    public ApplicationUser Sender { get; } = null!;

    public string ReceiverId { get; }
    public ApplicationUser Receiver { get; } = null!;

    public Result Reject()
    {
        if (AddToContactRequestStatus != AddToContactRequestStatus.Pending)
        {
            return Result.Failure(CoreErrors.AddToContactRequest.NotPending);
        }

        AddToContactRequestStatus = AddToContactRequestStatus.Rejected;
        return Result.Success();
    }

    public Result Accept()
    {
        if (AddToContactRequestStatus != AddToContactRequestStatus.Pending)
        {
            return Result.Failure(CoreErrors.AddToContactRequest.NotPending);
        }

        AddToContactRequestStatus = AddToContactRequestStatus.Accepted;
        return Result.Success();
    }
}