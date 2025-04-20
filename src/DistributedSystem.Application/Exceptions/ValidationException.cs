﻿using DistributedSystem.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistributedSystem.Application.Exceptions
{
    public sealed class ValidationException : DomainException
    {
        public ValidationException(IReadOnlyCollection<ValidationError> errors)
            : base("Validation Failure", "One or more validation errors occurred")
            => Errors = errors;

        public IReadOnlyCollection<ValidationError> Errors { get; }
    }

    public record ValidationError(string PropertyName, string ErrorMessage);
}
