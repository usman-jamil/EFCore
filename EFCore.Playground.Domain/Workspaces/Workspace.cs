using EFCore.Playground.Domain.Shared;
using EFCore.Playground.Domain.Abstractions;
using EFCore.Playground.Domain.Groups;
using EFCore.Playground.Domain.Users;
using EFCore.Playground.Domain.Workspaces.Events;
using System.Security;
using EFCore.Playground.Domain.Documents;

namespace EFCore.Playground.Domain.Workspaces;

public class Workspace : Entity
{
    private Workspace(Guid id, Name workspaceName, bool isPublic, Guid createdBy)
        : base(id)
    {
        WorkspaceName = workspaceName;
        IsPublic = isPublic;
        CreatedBy = createdBy;
    }

    private Workspace()
    {
    }

    public Name WorkspaceName { get; private set; }

    public bool IsPublic { get; private set; }

    public Guid CreatedBy { get; private set; }

    public DateTime CreatedOnUtc { get; private set; }
    
    public static Workspace Create(Name workspaceName, bool isPublic, Guid createdBy)
    {
        var workspace = new Workspace(Guid.NewGuid(), workspaceName, isPublic, createdBy);

        workspace.RaiseDomainEvent(new WorkspaceCreatedDomainEvent(workspace.Id));

        return workspace;
    }
}
