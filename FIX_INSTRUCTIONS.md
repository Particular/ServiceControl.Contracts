# Fix for API Approval Test Failure

## Problem
The API approval test is failing with this error:
```
Approved: s CustomCheckFailed : NServiceBus.IEvent\n    {\n        public CustomCheckFailed(
Received: s CustomCheckFailed : NServiceBus.IEvent, NServiceBus.IMessage\n    {  \n        pub
```

## Root Cause
In NServiceBus, the `IEvent` interface inherits from `IMessage`. When the contracts implement `IEvent`, the generated public API shows both interfaces: `NServiceBus.IEvent, NServiceBus.IMessage`.

The approval file in PR #455 was updated to show only `: NServiceBus.IEvent`, but it needs to show both interfaces.

## Solution
Update the file `src/ServiceControl.Contracts.Tests/ApprovalFiles/APIApprovals.PublicClr.approved.txt` in PR #455.

For all 10 event contract classes, change:
- FROM: `: NServiceBus.IEvent`
- TO: `: NServiceBus.IEvent, NServiceBus.IMessage`

### Classes to Update:
1. `CustomCheckFailed`
2. `CustomCheckSucceeded`
3. `FailedMessagesArchived`
4. `FailedMessagesUnArchived`
5. `HeartbeatRestored`
6. `HeartbeatStopped`
7. `MessageEditedAndRetried`
8. `MessageFailed`
9. `MessageFailureResolvedByRetry`
10. `MessageFailureResolvedManually`

## Example
Change line 3:
```diff
- public class CustomCheckFailed : NServiceBus.IEvent
+ public class CustomCheckFailed : NServiceBus.IEvent, NServiceBus.IMessage
```

Apply this same change to all 10 classes listed above.

## Verification
After applying the fix, the approval test should pass because the approved file will match the actual generated API.
