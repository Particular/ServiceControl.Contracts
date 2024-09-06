﻿namespace ServiceControl.Contracts
{
    using NServiceBus;

    /// <summary>
    /// Event emitted when failed message that are archived
    /// </summary>
    public class FailedMessagesArchived : IEvent
    {
        /// <summary>
        /// A list of the unique identifiers of the messages that failed that were archived
        /// </summary>
        public string[] FailedMessagesIds { get; set; }
    }
}