﻿using Dayana.Shared.Basic.MethodsAndObjects.Models;
using Dayana.Shared.Infrastructure.Operations;
using Dayana.Shared.Infrastructure.Pagination;
using MediatR;

namespace Dayana.Shared.Persistence.Models.Blog.Queries;
public record GetPostIssueFilterQuery : IRequestInfo, IRequest<OperationResult>
{
    public GetPostIssueFilterQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public DefaultPaginationFilter Filter { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}

public record GetPostIssueByIdQuery : IRequestInfo, IRequest<OperationResult>
{
    public GetPostIssueByIdQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public int PostIssueId { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}

public record GetPostCategoryIssueByFilterQuery : IRequestInfo, IRequest<OperationResult>
{
    public GetPostCategoryIssueByFilterQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public DefaultPaginationFilter Filter { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}

public record GetPostCategoryIssueByIdQuery : IRequestInfo, IRequest<OperationResult>
{
    public GetPostCategoryIssueByIdQuery(RequestInfo requestInfo)
    {
        RequestInfo = requestInfo;
    }

    public int Id { get; set; }
    public RequestInfo RequestInfo { get; private set; }
}