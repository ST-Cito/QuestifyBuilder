Imports System.Runtime.InteropServices

<ComImport(), Guid("00000016-0000-0000-C000-000000000046"), InterfaceType(ComInterfaceType.InterfaceIsIUnknown)> _
Interface _IOleMessageFilter
    <PreserveSig()> Function HandleInComingCall(ByVal dwCallType As Integer, ByVal hTaskCaller As IntPtr, ByVal dwTickCount As Integer, ByVal lpInterfaceInfo As IntPtr) As Integer
    <PreserveSig()> Function RetryRejectedCall(ByVal hTaskCallee As IntPtr, ByVal dwTickCount As Integer, ByVal dwRejectType As Integer) As Integer
    <PreserveSig()> Function MessagePending(ByVal hTaskCallee As IntPtr, ByVal dwTickCount As Integer, ByVal dwPendingType As Integer) As Integer
End Interface

