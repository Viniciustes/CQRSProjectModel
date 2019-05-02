using CQRSProjectModel.Domain.Core.Events;
using FluentValidation.Results;
using System;

namespace CQRSProjectModel.Domain.Core.Commands
{
    public abstract class Command : Message
    {
        public Command()
        {
            Timestamp = DateTime.Now;
        }

        public DateTime Timestamp { get; private set; }

        public ValidationResult ValidationResult { get; set; }

        public abstract bool IsValid();
    }
}
