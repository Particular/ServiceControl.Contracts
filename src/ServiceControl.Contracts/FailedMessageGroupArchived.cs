namespace ServiceControl.Contracts
{
    /// <summary>
    /// Event emitted for each failed message that was archived
    /// </summary>
    public class FailedMessageGroupArchived
    {
        /// <summary>
        /// The unique identifier of the group of failed messages that was archived
        /// </summary>
        public string GroupId { get; set; }
        /// <summary>
        /// The name of the group of failed messages that was archived
        /// </summary>
        public string GroupName { get; set; }
        /// <summary>
        /// The number of failed messages in the group that was archived
        /// </summary>
        public int MessagesCount { get; set; }
        /// <summary>
        /// A list of the unique identifiers of the messages that failed in the group that was archived
        /// </summary>
        public string[] FailedMessagesIds { get; set; }
    }
}