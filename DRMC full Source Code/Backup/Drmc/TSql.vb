Module TSql
    'Public Adp As OleDb.OleDbDataAdapter
    Public Function CTab_NonLike(ByVal Cls As Boolean, ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataTable)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & "='" & Findtxt & "' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        If Cls = True Then
            DtX.Clear()
        End If
        Adp.Fill(DtX)
    End Function
    Public Function CTab_NonLike(ByVal Cls As Boolean, ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataSet)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & "='" & Findtxt & "' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        If Cls = True Then
            DtX.Tables(OpenTableName).Clear()
        End If
        Adp.Fill(DtX, OpenTableName)
    End Function
    Public Function CTab_Like(ByVal Cls As Boolean, ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataTable)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & " like '%" & Findtxt & "%' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        If Cls = True Then
            DtX.Clear()
        End If
        Adp.Fill(DtX)
    End Function
    Public Function CTab_Like(ByVal Cls As Boolean, ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataSet)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & " like '%" & Findtxt & "%' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        If Cls = True Then
            DtX.Tables(OpenTableName).Clear()

        End If
        Adp.Fill(DtX, OpenTableName)
    End Function
    Public Function CTab_Like_Cls(ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataSet)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & " like '%" & Findtxt & "%' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        'If Cls = True Then
        DtX.Tables(OpenTableName).Clear()

        'End If
        Adp.Fill(DtX, OpenTableName)
    End Function
    Public Function CTab_Like_Cls(ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal Findtxt As String, ByVal DtX As DataTable)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & " like '%" & Findtxt & "%' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        'If Cls = True Then
        DtX.Clear()

        'End If
        Adp.Fill(DtX)
    End Function
    Public Function CTab_2_NonLike(ByVal Cls As Boolean, ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal FindFieldName2 As String, ByVal Findtxt As String, ByVal Findtxt2 As String, ByVal DtX As DataTable)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & "='" & Findtxt & "'" & " and " & FindField2 & "='" & Findtxt2 & "' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        If Cls = True Then
            DtX.Clear()
        End If
        Adp.Fill(DtX)
    End Function
    Public Function CTab_2_NonLike(ByVal TableTitles As String, ByVal Ordertxt As String, ByVal OpenTableName As String, ByVal FindFieldName As String, ByVal FindFieldName2 As String, ByVal Findtxt As String, ByVal Findtxt2 As String, ByVal DtX As DataTable)
        If Trim(Ordertxt) <> "" Then
            Ordertxt = " ORDER BY " & Ordertxt
        End If

        If FindField <> "" Then
            Sql = "select " & TableTitles & " from " & OpenTableName & " where ( " & FindField & "='" & Findtxt & "'" & " and " & FindField2 & "='" & Findtxt2 & "' ) " & Ordertxt
        Else
            Sql = "select " & TableTitles & " from " & OpenTableName & " " & Ordertxt
        End If
        'If Cls = True Then
        DtX.Clear()
        'End If
        Adp.Fill(DtX)
    End Function
End Module
