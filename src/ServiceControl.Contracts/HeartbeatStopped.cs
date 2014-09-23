namespace ServiceControl.Contracts
{
    using System;

    /// <summary>
    /// Event emitted when ServiceControl detects lack of heartbeat from one of monitored endpoints.
    /// </summary>
    public class HeartbeatStopped
    {
        /// <summary>
        /// The information about the endpoint.
        /// </summary>
        public EndpointInfo Endpoint { get; set; }
        /// <summary>
        /// The date and time last hearbeat has been received from the endpoint.
        /// </summary>
        public DateTime LastReceivedAt { get; set; }
        /// <summary>
        /// The date and time the lack of heartbeat been detected by ServiceControl.
        /// </summary>
        public DateTime DetectedAt { get; set; }

        /// <summary>
        /// Emdpoint specific details
        /// </summary>
        public class EndpointInfo
        {
            /// <summary>
            /// The name of the endpoint
            /// </summary>
            public string Name { get; set; }

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
}