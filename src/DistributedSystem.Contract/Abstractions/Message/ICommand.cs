﻿using DistributedSystem.Contract.Abstractions.Shared;
using MassTransit;
using MediatR;

namespace DistributedSystem.Contract.Abstractions.Message
{
    [ExcludeFromTopology]
    public interface ICommand : IRequest<Result>
    {
    }

    public interface ICommand<TResponse> : IRequest<Result<TResponse>>
    {
    }
}
