// -----------------------------------------------------------------------
// <copyright file="IScp106Event.cs" company="Exiled Team">
// Copyright (c) Exiled Team. All rights reserved.
// Licensed under the CC BY-SA 3.0 license.
// </copyright>
// -----------------------------------------------------------------------

namespace Exiled.Events.EventArgs.Interfaces
{
    using Exiled.API.Features.Roles;

    /// <summary>
    ///     Event args used for all <see cref="Scp106Role" /> related events.
    /// </summary>
    public interface IScp106Event : IPlayerEvent
    {
        /// <summary>
        ///     Gets the <see cref="Scp106Role" /> triggering the event.
        /// </summary>
        public Scp106Role Scp106 { get; }
    }
}