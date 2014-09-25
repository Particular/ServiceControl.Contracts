namespace ServiceControl.Contracts
{
    using System;

    /// <summary>
    /// Event emitted when ServiceControl detects lack of heartbeat from one of monitored endpoints.
    /// </summary>
    public class HeartbeatRestored
    {
        /// <summary>
        /// The date and time the heartbeat been again detected by ServiceControl.
        /// </summary>
        public DateTime RestoredAt { get; set; }

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