Public Module EntriesStr
    Public EStr As String
    Public Res1 As Boolean
    Public ComLst As ListBox
    Public ChkChg As Boolean
    Public GetStrs, CStrType As String
    Public Function ZA(ByVal Intx As Integer) As String
        If (ComLst.Items.Count - 1) >= Intx Then
            ZA = ComLst.Items.Item(Intx).ToString
            'MsgBox(ZA)
        Else
            ZA = ""

        End If
    End Function

End Module
