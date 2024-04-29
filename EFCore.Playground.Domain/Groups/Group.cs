using EFCore.Playground.Domain.Abstractions;
using EFCore.Playground.Domain.Shared;
using EFCore.Playground.Domain.Users;

namespace EFCore.Playground.Domain.Groups;

public sealed class Group : Entity
{
    private Group(Guid id, Name groupName, Guid workspaceId)
        : base(id)
    {
        GroupName = groupName;
        WorkspaceId = workspaceId;
    }

    private Group()
    {
    }

    public Name GroupName { get; private set; }

    public Guid WorkspaceId { get; private set; }

    public ICollection<User> Users { get; set; }

    public static Group Create(Name groupName, Guid workspaceId)
    {
        var group = new Group(Guid.NewGuid(), groupName, workspaceId);

        return group;
    }
}
