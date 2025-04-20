﻿using AuthorizationApi.Abstractions;
using Carter;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace AuthorizationApi.APIs.Identity
{
    public class AuthApi : ApiEndpoint, ICarterModule
    {
        private const string BaseUrl = "/api/v{version:apiVersion}/auth";
        public void AddRoutes(IEndpointRouteBuilder app)
        {
            var group1 = app.NewVersionedApi("Authentication")
                .MapGroup(BaseUrl).HasApiVersion(1).RequireAuthorization();

            group1.MapPost("login", AuthenticationV1).AllowAnonymous();
        }


        public static async Task<IResult> AuthenticationV1(ISender sender, [FromBody] DistributedSystem.Contract.Services.V1.Identity.Query.Login login)
        {
            var result = await sender.Send(login);

            if (result.IsFailure)
                return HandlerFailure(result);

            return Results.Ok(result);
        }


    }
}
