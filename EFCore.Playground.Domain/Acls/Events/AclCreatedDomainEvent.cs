
using EFCore.Playground.Domain.Abstractions;

namespace EFCore.Playground.Domain.ACLs.Events;

public sealed record AclCreatedDomainEvent(string WorkspaceName, string GroupName, string RoleName) : IDomainEvent;
