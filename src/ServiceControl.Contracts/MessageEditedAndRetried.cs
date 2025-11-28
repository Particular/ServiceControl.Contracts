namespace ServiceControl.Contracts
{
    /// <summary>
    /// Event emitted by ServiceControl when edit-and-retry feature is used.
    /// </summary>
    public class MessageEditedAndRetried
    {
        /// <summary>
        /// The unique identifier of the message that was edited
        /// </summary>
        public string FailedMessageId { get; set; }
    }
}