Public Class AlsoShow

    Private Declare Function ExitWindowsEx Lib "user32" (ByVal uflags As Integer, ByVal dwReserved As Integer) As Integer
    'UPGRADE_ISSUE: Declaring a parameter 'As Any' is not supported. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="FAE78A8D-8978-4FD4-8208-5B7324A8F795"'
    Private Declare Function SystemParametersInfo Lib "user32" Alias "SystemParametersInfoA" (ByVal uAction As Integer, ByVal uParam As Integer, ByRef lpvParam As String, ByVal fuWinIni As Integer) As Integer
    Private Declare Function SetWindowPos Lib "user32" (ByVal hwnd As Integer, ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer
    Private Declare Function GetSystemMetrics Lib "user32" (ByVal nIndex As Integer) As Integer
    Private Const SM_CXSCREEN As Short = 0
    Private Const SM_CYSCREEN As Short = 1
    Private Const HWND_TOP As Short = 0
    Private Const SWP_SHOWWINDOW As Short = &H40S
    Private Const SWP_NOMOVE As Integer = &H2S
    Private Const SWP_NOSIZE As Integer = &H1S
    Public t As Short
    Public MaxStr As String

    Public ExeNum As Object
    Public ButNam As String
    Public LPpath As String
    Public Function AlsoShow(ByRef frm As System.Windows.Forms.Form) As Object
        Dim cx As Object
        Dim lFlags As Integer
        Dim cy As Integer
        Dim RetVal As Integer
        Dim pOld As Boolean
        t = 0
        'UPGRADE_WARNING: Couldn't resolve default property of object cx. Click for more: 'ms-help://MS.VSCC.v80/dv_commoner/local/redirect.htm?keyword="6A50421D-15FE-4896-8A1B-2EC21E9037B2"'
        cx = GetSystemMetrics(SM_CXSCREEN)
        cy = GetSystemMetrics(SM_CYSCREEN)

        lFlags = SWP_NOSIZE Or SWP_NOMOVE
        RetVal = SetWindowPos(frm.Handle.ToInt32, -1, 0, 0, 0, 0, lFlags)

        ' hide from ctlaltdel

    End Function

End Class
