Imports System.Data.OleDb
Module QAukSql
    'Public Sql As String
    'Public Sql2 As String
    'Public Sql3 As String
    'Public sql4 As String
    'Public Dset As DataSet
    'Public ST(7) As Object
    'Public SF(7) As Object
    'Public Connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\Documents and Settings\AukSoft\My Documents\db1.mdb"
    'Public Cn As New OleDb.OleDbConnection(Connect)
    'Public DrC As DataColumn
    'Public DrR As DataRow
    'Public DT As DataTable



    'Public Adp As OleDb.OleDbDataAdapter
    'Public Function SqlAukCmD(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal Likeuse As Boolean, ByVal AnyWhere As Boolean)
    '    Dim m, p As String
    '    Dim CvObj(7) As Object
    '    Dim strvX As String
    '    'Dim I As Integer


    '    p = "') and"
    '    m = "='"
    '    For I = 0 To 7
    '        If Trim(SF(I)) <> "" Then
    '            If Likeuse = True Then
    '                If AnyWhere = False Then
    '                    CvObj(I) = "(" & SF(I) & " like '%" & ST(I) & "')"
    '                Else
    '                    CvObj(I) = "(" & SF(I) & " like '%" & ST(I) & "%')"
    '                End If

    '            Else
    '                CvObj(I) = "(" & SF(I) & m & ST(I) & "')"
    '            End If

    '        Else
    '            CvObj(I) = ""
    '        End If
    '        If CvObj(I) <> "" Then
    '            If strvX = "" Then
    '                strvX = CvObj(I)
    '            Else
    '                strvX = strvX & " and " & CvObj(I)
    '            End If

    '        End If
    '    Next

    '    If strvX <> "" Then
    '        Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & ")"
    '    Else
    '        Sql = "select " & TitleNames & " from " & OpenTableName
    '    End If

    '    For I = 0 To 7
    '        CvObj(I) = ""
    '        SF(I) = ""
    '        ST(I) = ""
    '    Next
    '    strvX = ""
    'End Function
    Public Function SqlAukNonLike(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet, ByVal allOpen As Boolean)
        If allOpen = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, False, False)
            dsetX.Tables(OpenTableName).Clear()
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        End If
    End Function

    Public Function SqlAukLikeAnyWhere(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet, ByVal allOpen As Boolean, ByVal ClsBefore As Boolean)
        If allOpen = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, True, True)
            If ClsBefore = True Then
                dsetX.Tables(OpenTableName).Clear()
            End If

            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        End If
    End Function
    Public Function SqlAukLikeFromStartText(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet, ByVal allOpen As Boolean)
        If allOpen = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, True, False)
            dsetX.Tables(OpenTableName).Clear()
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        End If
    End Function
    Public Function A_SqlAukFindOnlyFullMatched(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet)
        cg = ""
        For i = 0 To 7
            cg = cg & SF(i)
        Next
        If cg = "" Then FilterOnly = True
        If FilterOnly = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, False, False)
            ''MsgBox(Sql)

            dsetX.Tables(OpenTableName).Clear()
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        End If
    End Function
    'Public Function SqlCls(ByVal Cls As Boolean, ByVal DSetX As DataSet) As Boolean
    '    If Cls = False Or SqlCls = False Then
    '        Cls = False
    '        SqlCls = False
    '    ElseIf Cls = True Or SqlCls = True Then
    '        Cls = True
    '        SqlCls = True
    '        DSetX.Clear()
    '    End If
    'End Function
    'Public Function SqlCls(ByVal Cls As Boolean, ByVal DTS As DataTable) As Boolean
    '    If Cls = False Or SqlCls = False Then
    '        Cls = False
    '        SqlCls = False
    '    ElseIf Cls = True Or SqlCls = True Then
    '        Cls = True
    '        SqlCls = True
    '        DTS.Clear()
    '    End If
    'End Function

    'Public Function SqlRun(ByVal Sql As String, ByVal DSetX As DataSet)

    'End Function
    'Public Function SqlRun(ByVal Sql As String, ByVal DSetX As DataTable)

    'End Function
    'Public Function SqlRun(ByVal Sql As String)

    'End Function
    'Public Function SqlRun(ByVal Sql As String, ByVal ByTabs As Boolean)

    'End Function
End Module
