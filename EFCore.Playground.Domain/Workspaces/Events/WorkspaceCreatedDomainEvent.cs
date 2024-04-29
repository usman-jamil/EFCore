
using EFCore.Playground.Domain.Abstractions;

namespace EFCore.Playground.Domain.Workspaces.Events;

public sealed record WorkspaceCreatedDomainEvent(Guid WorkspaceId) : IDomainEvent;
