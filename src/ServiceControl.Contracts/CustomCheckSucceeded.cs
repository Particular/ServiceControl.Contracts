namespace ServiceControl.Contracts
{
    using System;
    using NServiceBus;

    /// <summary>
    /// Event emitted when a custom check passes.
    /// </summary>
    public class CustomCheckSucceeded : IEvent
    {
        /// <summary>
        /// The id for the custom check provided by the user.
        /// </summary>
        public string CustomCheckId { get; set; }

        /// <summary>
        /// The custom check category provided by the user.
        /// </summary>
        public string Category { get; set; }

        /// <summary>
        /// The date and time the check passed.
        /// </summary>
        public DateTime SucceededAt { get; set; }

        /// <summary>
        /// The name of the endpoint
        /// </summary>
        public string EndpointName { get; set; }

        /// <summary>
        /// The unique identifier for the host that runs the endpoint
        /// </summary>
        public Guid HostId { get; set; }

        /// <summary>
        /// The name of the host
        /// </summary>
        public string Host { get; set; }
    }
}