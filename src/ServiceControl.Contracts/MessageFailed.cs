﻿namespace ServiceControl.Contracts
{
    using System;
    using System.Collections.Generic;


    /// <summary>
    /// Event emited for each message that ServiceControl detects as failed
    /// </summary>
    public class MessageFailed
    {
        /// <summary>
        /// The unique identifier for this failure generated by the ServiceControl
        /// </summary>
        public string FailedMessageId { get; set; }

        /// <summary>
        /// The message type of the message
        /// </summary>
        public string MessageType { get; set; }

        /// <summary>
        /// The number of times this message was attempted to be processed
        /// </summary>
        public int NumberOfProcessingAttempts { get; set; }

        /// <summary>
        /// Status of the falied message
        /// </summary>
        public MessageStatus Status { get; set; }

        /// <summary>
        /// The endpoint who sent the message
        /// </summary>
        public Endpoint SendingEndpoint { get; set; }

        /// <summary>
        /// The endpoint where the message failed to be processed
        /// </summary>
        public Endpoint ProcessingEndpoint { get; set; }

        /// <summary>
        /// Details about the reason for this particular failure
        /// </summary>
        public FailureInfo FailureDetails { get; set; }

        /// <summary>
        /// Details about the message itself 
        /// </summary>
        public Message MessageDetails { get; set; }

        /// <summary>
        /// Valid message statuses
        /// </summary>
        public enum MessageStatus
        {
            /// <summary>
            /// Message has been archived
            /// </summary>
            ArchivedFailure,
            /// <summary>
            /// Message has failed
            /// </summary>
            Failed,
            /// <summary>
            /// Message had failed, was retried and has failed again
            /// </summary>
            RepeatedFailure
        }

        /// <summary>
        /// Emdpoint specific details
        /// </summary>
        public class Endpoint
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

        /// <summary>
        /// Message details
        /// </summary>
        public class Message
        {
            /// <summary>
            /// The id of the message
            /// </summary>
            public string MessageId { get; set; }

            /// <summary>
            /// The headers of the message
            /// </summary>
            public Dictionary<string, string> Headers { get; set; }

            /// <summary>
            /// The content type of the body
            /// </summary>
            public string ContentType { get; set; }

            /// <summary>
            /// The body for non-binary messages
            /// </summary>
            public string Body { get; set; }
        }

        /// <summary>
        /// Information about the failure
        /// </summary>
        public class FailureInfo
        {
            /// <summary>
            /// The physical address of the host where the message has failed
            /// </summary>
            public string AddressOfFailingEndpoint { get; set; }

            /// <summary>
            /// The time when the message has failed
            /// </summary>
            public DateTime TimeOfFailure { get; set; }

            /// <summary>
            /// The exception that caused this failure
            /// </summary>
            public ExceptionInfo Exception { get; set; }

            /// <summary>
            /// Exception details
            /// </summary>
            public class ExceptionInfo
            {
                /// <summary>
                /// The CLR type of rhe exception
                /// </summary>
                public string ExceptionType { get; set; }

                /// <summary>
                /// The exception message
                /// </summary>
                public string Message { get; set; }

                /// <summary>
                /// The exception source
                /// </summary>
                public string Source { get; set; }

                /// <summary>
                /// The exception stack trace
                /// </summary>
                public string StackTrace { get; set; }
            }

        }
    }
}