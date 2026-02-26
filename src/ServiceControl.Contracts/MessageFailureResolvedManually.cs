namespace ServiceControl.Contracts
{
    using NServiceBus;

    /// <summary>
    /// Event emitted by ServiceControl for each failed message that was resolved manually
    /// </summary>

    public class MessageFailureResolvedManually : IEvent
    {
        /// <summary>
        /// The unique identifier of the message that failed and was resolved manually
        /// </summary>
        public string FailedMessageId { get; set; }
    }
}