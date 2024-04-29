

using EFCore.Playground.Domain.Abstractions;

namespace EFCore.Playground.Domain.Groups;

public static class GroupErrors
{
    public static readonly Error NotFound = new(
        "Group.NotFound",
        "The group with the specified identifier was not found");
}
