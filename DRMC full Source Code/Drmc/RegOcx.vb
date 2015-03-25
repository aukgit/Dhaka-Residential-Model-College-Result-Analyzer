Module RegOcx

    'UPGRADE_ISSUE: Declaring a parameter 'as string' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    'UPGRADE_ISSUE: Declaring a parameter 'as string' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function FindWindow Lib "user32.dll" Alias "FindWindowA" (ByVal a As String, ByVal b As String) As Integer
    Private Declare Function LoadLibrary Lib "kernel32" Alias "LoadLibraryA" (ByVal lpLibFileName As String) As Integer
    Private Declare Function GetProcAddress Lib "kernel32" (ByVal hModule As Integer, ByVal lpProcName As String) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'as string' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function CreateThread Lib "kernel32" (ByRef lpThreadAttributes As String, ByVal dwStackSize As Integer, ByVal lpStartAddress As Integer, ByVal lParameter As Integer, ByVal dwCreationFlags As Integer, ByRef lpThreadID As Integer) As Integer
    Private Declare Function WaitForSingleObject Lib "kernel32" (ByVal hHandle As Integer, ByVal dwMilliseconds As Integer) As Integer
    Private Declare Function GetExitCodeThread Lib "kernel32" (ByVal hThread As Integer, ByRef lpExitCode As Integer) As Integer
    Private Declare Sub ExitThread Lib "kernel32" (ByVal dwExitCode As Integer)
    Private Declare Function FreeLibrary Lib "kernel32" (ByVal hLibModule As Integer) As Integer
    Private Declare Function CloseHandle Lib "kernel32" (ByVal hObject As Integer) As Integer
    Dim Reg As String
    Dim Success As Boolean
    Dim mresult As Object


    Public Sub RegUnReg(ByVal inFileSpec As String, Optional ByRef inHandle As String = "")
        Dim Prob As Object
        On Error Resume Next
        Dim lLib As Integer ' Store handle of the control library
        Dim lpDLLEntryPoint As Integer ' Store the address of function called
        Dim lpThreadID As Integer ' Pointer that receives the thread identifier
        Dim lpExitCode As Integer ' Exit code of GetExitCodeThread
        Dim mThread As Object

        ' Load the control DLL, i. e. map the specified DLL file into the
        ' address space of the calling process
        lLib = LoadLibrary(inFileSpec)
        If lLib = 0 Then
            ' e.g. file not exists or not a valid DLL file
            'UPGRADE_WARNING: Couldn't resolve default property of object Prob. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Prob = "This Component is installed before"
            Exit Sub
        Else
            'UPGRADE_WARNING: Couldn't resolve default property of object Prob. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
            Prob = ""
        End If

        ' Find and store the DLL entry point, i.e. obtain the address of the
        ' ?DllRegisterServer? or "DllUnregisterServer" function (to register
        ' or deregister the server?s components in the registry).
        '
        If inHandle = "" Then
            lpDLLEntryPoint = GetProcAddress(lLib, "DllRegisterServer")
        ElseIf inHandle = "U" Or inHandle = "u" Then
            lpDLLEntryPoint = GetProcAddress(lLib, "DllUnregisterServer")
        Else
            MsgBox("Unknown command handle")
            Exit Sub
        End If
        If lpDLLEntryPoint = VariantType.Null Or lpDLLEntryPoint = 0 Then
            GoTo earlyExit1
        End If

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor

        ' Create a thread to execute within the virtual address space of the calling process
        'UPGRADE_WARNING: Couldn't resolve default property of object mThread. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mThread = CreateThread(0, 0, lpDLLEntryPoint, 0, 0, lpThreadID)
        'UPGRADE_WARNING: Couldn't resolve default property of object mThread. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If mThread = 0 Then
            GoTo earlyExit1
        End If

        ' Use WaitForSingleObject to check the return state (i) when the specified object
        ' is in the signaled state or (ii) when the time-out interval elapses.  This
        ' function can be used to test Process and Thread.
        'UPGRADE_WARNING: Couldn't resolve default property of object mThread. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        'UPGRADE_WARNING: Couldn't resolve default property of object mresult. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        mresult = WaitForSingleObject(mThread, 10000)
        'UPGRADE_WARNING: Couldn't resolve default property of object mresult. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        If mresult <> 0 Then
            GoTo earlyExit2
        End If

        ' We don't call the dangerous TerminateThread(); after the last handle
        ' to an object is closed, the object is removed from the system.
        'UPGRADE_WARNING: Couldn't resolve default property of object mThread. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        CloseHandle(mThread)
        FreeLibrary(lLib)

        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        Success = True
        Exit Sub


earlyExit1:
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'UPGRADE_WARNING: Couldn't resolve default property of object Prob. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prob = "Registration failed in obtaining entry point or creating thread. "
        ' Decrements the reference count of loaded DLL module before leaving
        FreeLibrary(lLib)
        Success = False
        Exit Sub

earlyExit2:
        Success = False
        'UPGRADE_WARNING: Screen property Screen.MousePointer has a new behavior. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6BA9B8D2-2A32-4B6E-8D36-44949974A5B4"'
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
        'UPGRADE_WARNING: Couldn't resolve default property of object Prob. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        Prob = "Registration failed in signaled state or time-out"
        FreeLibrary(lLib)
        ' Terminate the thread to free up resources that are used by the thread
        ' NB Calling ExitThread for an application's primary thread will cause
        ' the application to terminate
        'UPGRADE_WARNING: Couldn't resolve default property of object mThread. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        lpExitCode = GetExitCodeThread(mThread, lpExitCode)
        ExitThread(lpExitCode)
    End Sub

    Public Function RegOcx(ByRef Ocx_Name As String) As Object
        Reg = "u"
        RegUnReg(Ocx_Name, Reg)
        Reg = ""
        RegUnReg(Ocx_Name, Reg)
    End Function
    Public Function UnRegOcx(ByRef Ocx_Name As String) As Object
        Reg = "u"
        RegUnReg(Ocx_Name, Reg)
        'Reg = ""
        'RegUnReg(Ocx_Name, Reg)
    End Function

End Module
