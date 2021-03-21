namespace ServiceControl.Contracts
{
    /// <summary>
    /// Event emitted for failed messages that were unarchived
    /// </summary>
    public class FailedMessagesUnArchived
    {
        /// <summary>
        /// The number of messages that failed and were unarchived
        /// </summary>
        public int MessagesCount { get; set; }
        /// <summary>
        /// A list of the unique identifiers of the messages that failed and were unarchived
        /// </summary>
        public string[] FailedMessagesIds { get; set; }

    }
}
