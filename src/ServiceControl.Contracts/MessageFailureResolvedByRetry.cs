namespace ServiceControl.Contracts
{
    /// <summary>
    /// Event emitted by ServiceControl for each failed message that was resolved by retry
    /// </summary>
    public class MessageFailureResolvedByRetry
    {
        /// <summary>
        /// The unique identifier of the message that failed and was resolved by retry
        /// </summary>
        public string FailedMessageId { get; set; }

        /// <summary>
        /// Alternative Failed MessageIds that failed and were resolved by retry
        /// </summary>
        public string[] AlternativeFailedMessageIds { get; set; }
    }
}