﻿using EFCore.Playground.Domain.Shared;
using EFCore.Playground.Domain.Workspaces;

namespace EFCore.Playground.Domain.Documents;

public sealed class Document
{
    private Document(Guid documentId, Name documentName)
        : base()
    {
        DocumentName = documentName;
    }
    private Document()
    {
    }

    public Guid DocumentId { get; private set; }
    public Name DocumentName { get; private set; }

    public Guid WorkspaceId { get; private set; }

    public static Document Create(Guid workspaceId,Name documentName)
    {
        var group = new Document(Guid.NewGuid(), documentName);

        return group;
    }

}