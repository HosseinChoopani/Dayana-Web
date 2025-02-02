﻿using Dayana.Shared.Basic.MethodsAndObjects.Models;
using Dayana.Shared.Infrastructure.Operations;
using MediatR;

namespace Dayana.Shared.Persistence.Models.Blog.Commands;


#region PostCategoryComments

public record CreatePostCategoryCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public CreatePostCategoryCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public RequestInfo RequestInfo { get; set; }
    public string CommentText { get; set; }
    public bool IsReply { get; set; }
    public int PostCategoryId { get; set; }
    public int CommentOwnerId { get; set; }
    public int? ReplyToCommentId { get; set; }
}

public record DeletePostCategoryCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public DeletePostCategoryCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public RequestInfo RequestInfo { get; set; }
    public int Id { get; set; }
}

public record UpdatePostCategoryCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public UpdatePostCategoryCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public RequestInfo RequestInfo { get; set; }
    public int Id { get; set; }
    public string CommentText { get; set; }
    public bool IsReply { get; set; }
    public int PostCategoryId { get; set; }
    public int CommentOwnerId { get; set; }
    public int? ReplyToCommentId { get; set; }
}

#endregion

#region PostComment

public record CreatePostCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public CreatePostCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public string CommentText { get; set; }
    public bool IsReply { get; set; }
    public int PostId { get; set; }
    public int CommentOwnerId { get; set; }
    public int? ReplyToCommentId { get; set; }

    public RequestInfo RequestInfo { get; set; }
}

public record DeletePostCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public DeletePostCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }
    public int Id { get; set; }

    public RequestInfo RequestInfo { get; set; }
}

public record UpdatePostCommentCommand : IRequestInfo, IRequest<OperationResult>
{
    public UpdatePostCommentCommand(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public int Id { get; set; }
    public string CommentText { get; set; }
    public bool IsReply { get; set; }
    public int PostId { get; set; }
    public int CommentOwnerId { get; set; }
    public int? ReplyToCommentId { get; set; }

    public RequestInfo RequestInfo { get; set; }
}

#endregion

