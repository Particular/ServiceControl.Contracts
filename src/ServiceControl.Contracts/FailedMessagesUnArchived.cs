namespace ServiceControl.Contracts
{
    using NServiceBus;

    /// <summary>
    /// Event emitted for failed messages that were unarchived
    /// </summary>
    public class FailedMessagesUnArchived : IEvent
    {
        /// <summary>
        /// A list of the unique identifiers of the messages that failed and were unarchived
        /// </summary>
        public string[] FailedMessagesIds { get; set; }
    }
}