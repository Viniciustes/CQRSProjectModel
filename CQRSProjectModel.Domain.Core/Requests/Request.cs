using FluentValidation.Results;
using MediatR;
using System;

namespace CQRSProjectModel.Domain.Core.Requests
{
    public abstract class Request : RequestMessage, IRequest
    {
        public Request()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }

        public ValidationResult ValidationResult { get; set; }

        public DateTime DataTime { get; }

        public abstract bool IsValid();
    }
}
