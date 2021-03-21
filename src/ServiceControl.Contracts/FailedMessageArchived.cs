namespace ServiceControl.Contracts
{
    /// <summary>
    /// Event emitted for each failed message that was archived
    /// </summary>
    public class FailedMessageArchived
    {
        /// <summary>
        /// The unique identifier of the message that failed and was archived
        /// </summary>
        public string FailedMessageId { get; set; }
    }
}