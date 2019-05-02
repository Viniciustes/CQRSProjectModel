﻿using CQRSProjectModel.Domain.Core.Commands;
using CQRSProjectModel.Domain.Core.Events;
using System.Threading.Tasks;

namespace CQRSProjectModel.Domain.Core.Mediators
{
    public interface IMediatorHandler
    {
        Task SendCommand<T>(T command) where T : Command;

        Task RaiseEvent<T>(T @event) where T : Event;
    }
}
