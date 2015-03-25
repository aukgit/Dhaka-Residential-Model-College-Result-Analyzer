Imports System.Data.OleDb
Public Module AukSql
    Public Sql As String
    Public Sql2 As String
    Public Sql3 As String
    Public sql4 As String
    Public Dset As DataSet
    Public ST(7) As Object
    Public SF(7) As Object
    Public Connect As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\auksoft.aukbased"
    Public Cn As New OleDb.OleDbConnection(Connect)
    Public DrC As DataColumn
    Public DrR As DataRow
    Public DT As DataTable
    Public LK(7) As Object
    Public NM(7) As Object
    Public EP(7) As Object
    Public Expre(7) As Object
    Public GrpObj(7) As Object

    Public ESum(7) As Object


    Public Adp As OleDbDataAdapter
    Public Function SqlAukCmDND(ByVal TitleNames As String, ByVal GrpT As String, ByVal Grp As Boolean, ByVal OrB As Boolean, ByVal OpenTableName As String, ByVal LikeOpt As Boolean)
        Dim m, p As String
        Dim CvObj(7) As Object
        Dim strvX As String
        'Dim I As Integer
        p = "') and"
        m = "='"

        For I = 0 To 7
            If Expre(I).ToString = "" Then
                If Trim(SF(I).ToString) <> "" Then
                    If Trim(NM(I).ToString) = "" And Trim(EP(I).ToString) = "" Then
                        If LikeOpt = False Then
                            If Trim(LK(I).ToString) <> "" Then
                                If ESum(I).ToString <> "" Then
                                    CvObj(I) = "(" & ESum(I).ToString & "([" & SF(I).ToString & "]) like '%" & ST(I).ToString & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I).ToString & "] like '%" & ST(I).ToString & "%')"
                                End If

                            Else
                                CvObj(I) = "([" & SF(I).ToString & "]" & m & ST(I).ToString & "')"
                            End If
                        Else
                            If EP(I).ToString = "" And NM(I).ToString = "" Then
                                If ESum(I).ToString <> "" Then '
                                    CvObj(I) = "(" & ESum(I).ToString & "([" & SF(I).ToString & "])" & " like '%" & ST(I).ToString & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I).ToString & "]" & " like '%" & ST(I).ToString & "%')"
                                End If

                            End If
                        End If

                    Else

                        If Trim(EP(I)).ToString <> "" Then
                            If ESum(I).ToString = "" Then
                                CvObj(I) = "(" & ESum(I).ToString & "([" & SF(I).ToString & "] " & ST(I).ToString & ")"
                            Else
                                CvObj(I) = "([" & SF(I).ToString & "] " & ST(I).ToString & ")"
                            End If

                        Else
                            CvObj(I) = "([" & SF(I).ToString & "]=" & ST(I).ToString & ")"
                        End If
                    End If

                Else
                    CvObj(I) = ""
                End If

                If CvObj(I) <> "" Then
                    If strvX = "" Then
                        strvX = CvObj(I)
                    Else
                        strvX = strvX & " and " & CvObj(I)
                    End If

                End If
            Else


                If LikeOpt = False Then
                    If Trim(LK(I)).ToString <> "" Then
                        If ESum(I).ToString <> "" Then
                            CvObj(I) = "(" & ESum(I).ToString & "([" & SF(I).ToString & "]) like " & Expre(I).ToString & ")"
                        Else
                            CvObj(I) = "([" & SF(I).ToString & "] like " & Expre(I).ToString & ")"
                        End If

                    Else
                        CvObj(I) = "([" & SF(I).ToString & "]" & m & Expre(I).ToString & "')"
                    End If
                Else
                    If EP(I).ToString = "" And NM(I).ToString = "" Then
                        If ESum(I).ToString <> "" Then '
                            CvObj(I) = "(" & ESum(I).ToString & "([" & SF(I).ToString & "])" & " like " & Expre(I).ToString & ")"
                        Else
                            CvObj(I) = "([" & SF(I) & "]" & " like " & Expre(I).ToString & ")"
                        End If

                    End If
                End If


            End If
           
        Next

        If strvX <> "" Then
            Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )"
        Else
            Sql = "select " & TitleNames & " from " & OpenTableName
        End If
        cbt = GrpT
        GrpT = " Group by " & GrpT

        If Grp = True Then
            If strvX <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT & " Having ( " & strvX & " )"
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT

            End If
        End If
        GrpT = cbt
        GrpT = " ORDER BY " & GrpT
        If OrB = True Then
            If strvX <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )" & GrpT
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT

            End If
        End If
        For I = 0 To 7
            CvObj(I) = ""
            SF(I) = ""
            ST(I) = ""
            LK(I) = ""
            EP(I) = ""
            NM(I) = ""
            ESum(I) = ""
            Expre(I) = ""

        Next
        strvX = ""
    End Function
    Public Function SqlAukCmD(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal Likeuse As Boolean, ByVal AnyWhere As Boolean)
        Dim m, p As String
        Dim CvObj(7) As Object
        Dim strvX As String
        'Dim I As Integer


        p = "') and"
        m = "='"
        For I = 0 To 7
            If Trim(SF(I)) <> "" Then
                If Likeuse = True Then
                    If AnyWhere = False Then
                        CvObj(I) = "(" & SF(I) & " like '%" & ST(I) & "')"
                    Else
                        CvObj(I) = "(" & SF(I) & " like '%" & ST(I) & "%')"
                    End If

                Else
                    CvObj(I) = "(" & SF(I) & m & ST(I) & "')"
                End If

            Else
                CvObj(I) = ""
            End If
            If CvObj(I) <> "" Then
                If strvX = "" Then
                    strvX = CvObj(I)
                Else
                    strvX = strvX & " and " & CvObj(I)
                End If

            End If
        Next

        If strvX <> "" Then
            Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & ")"
        Else
            Sql = "select " & TitleNames & " from " & OpenTableName
        End If

        For I = 0 To 7
            CvObj(I) = ""
            SF(I) = ""
            ST(I) = ""
        Next
        strvX = ""
    End Function
    Public Function SqlAukNonLike_findWithAdd(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal Mk As DataSet, ByVal allOpen As Boolean)
        If allOpen = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(Mk, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, False, False)
            'dsetX.Tables(OpenTableName).Clear()
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(Mk, OpenTableName)
        End If
    End Function

    Public Function SqlAukLikeAnyWhere_Add(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet, ByVal allOpen As Boolean, ByVal ClsBefore As Boolean)
        If allOpen = True Then
            Try
                Sql = "select " & TitleNames & " from " & OpenTableName
                Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
                Adp.Fill(dsetX, OpenTableName)
            Catch ex As Exception
                Ebx(Err.Number, Err.Description)
            End Try

        Else
            SqlAukCmD(TitleNames, OpenTableName, True, True)
            If ClsBefore = True Then
                dsetX.Tables(OpenTableName).Clear()
            End If

            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        End If
    End Function

    Public Function A_SqlAuk_FindAnd_Add(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal dsetX As DataSet)
        cg = ""
        For I = 0 To 7
            cg = cg & SF(I)
        Next
        If cg = "" Then FilterOnly = True
        If FilterOnly = True Then
            Sql = "select " & TitleNames & " from " & OpenTableName
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(dsetX, OpenTableName)
        Else
            SqlAukCmD(TitleNames, OpenTableName, False, False)
            'MsgBox(Sql)

            'dsetX.Tables(OpenTableName).Clear()
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
    Public Function SFC(ByVal T As Object)
        SF(0) = T

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object)
        SF(0) = T
        SF(1) = T2
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
        SF(3) = T4
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
        SF(3) = T4
        SF(4) = T5

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
        SF(3) = T4
        SF(4) = T5
        SF(5) = T6
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
        SF(3) = T4
        SF(4) = T5
        SF(5) = T6
        SF(6) = T7

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        SF(0) = T
        SF(1) = T2
        SF(2) = t3
        SF(3) = T4
        SF(4) = T5
        SF(5) = T6
        SF(6) = T7
        SF(7) = T8
    End Function
    Public Function STC(ByVal T As Object)
        ST(0) = T

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object)
        ST(0) = T
        ST(1) = T2
    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
        ST(3) = T4
    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
        ST(3) = T4
        ST(4) = T5

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
        ST(3) = T4
        ST(4) = T5
        ST(5) = T6
    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
        ST(3) = T4
        ST(4) = T5
        ST(5) = T6
        ST(6) = T7

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        ST(0) = T
        ST(1) = T2
        ST(2) = t3
        ST(3) = T4
        ST(4) = T5
        ST(5) = T6
        ST(6) = T7
        ST(7) = T8
    End Function
    Public Function LKC(ByVal T As Object)
        LK(0) = T

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object)
        LK(0) = T
        LK(1) = T2
    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
        LK(3) = T4
    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
        LK(3) = T4
        LK(4) = T5

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
        LK(3) = T4
        LK(4) = T5
        LK(5) = T6
    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
        LK(3) = T4
        LK(4) = T5
        LK(5) = T6
        LK(6) = T7

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        LK(0) = T
        LK(1) = T2
        LK(2) = t3
        LK(3) = T4
        LK(4) = T5
        LK(5) = T6
        LK(6) = T7
        LK(7) = T8
    End Function
    Public Function NMC(ByVal T As Object)
        NM(0) = T

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object)
        NM(0) = T
        NM(1) = T2
    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
        NM(3) = T4
    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
        NM(3) = T4
        NM(4) = T5

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
        NM(3) = T4
        NM(4) = T5
        NM(5) = T6
    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
        NM(3) = T4
        NM(4) = T5
        NM(5) = T6
        NM(6) = T7

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        NM(0) = T
        NM(1) = T2
        NM(2) = t3
        NM(3) = T4
        NM(4) = T5
        NM(5) = T6
        NM(6) = T7
        NM(7) = T8
    End Function
    Public Function EPC(ByVal T As Object)
        EP(0) = T

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object)
        EP(0) = T
        EP(1) = T2
    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
        EP(3) = T4
    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
        EP(3) = T4
        EP(4) = T5

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
        EP(3) = T4
        EP(4) = T5
        EP(5) = T6
    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
        EP(3) = T4
        EP(4) = T5
        EP(5) = T6
        EP(6) = T7

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        EP(0) = T
        EP(1) = T2
        EP(2) = t3
        EP(3) = T4
        EP(4) = T5
        EP(5) = T6
        EP(6) = T7
        EP(7) = T8
    End Function
    Public Function GroupTxTStr(ByVal T As Object)
        GrpObj(0) = T

    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        'for i = 
    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
        GrpObj(3) = T4
    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
        GrpObj(3) = T4
        GrpObj(4) = T5

    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
        GrpObj(3) = T4
        GrpObj(4) = T5
        GrpObj(5) = T6
    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
        GrpObj(3) = T4
        GrpObj(4) = T5
        GrpObj(5) = T6
        GrpObj(6) = T7

    End Function
    Public Function GroupTxTStr(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        GrpObj(0) = T
        GrpObj(1) = T2
        GrpObj(2) = t3
        GrpObj(3) = T4
        GrpObj(4) = T5
        GrpObj(5) = T6
        GrpObj(6) = T7
        GrpObj(7) = T8
    End Function
    Public Function ExpreC(ByVal T As Object)
        expre(0) = T

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object)
        expre(0) = T
        expre(1) = T2
    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
        expre(3) = T4
    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
        expre(3) = T4
        expre(4) = T5

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
        expre(3) = T4
        expre(4) = T5
        expre(5) = T6
    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
        expre(3) = T4
        expre(4) = T5
        expre(5) = T6
        expre(6) = T7

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        expre(0) = T
        expre(1) = T2
        expre(2) = t3
        expre(3) = T4
        expre(4) = T5
        expre(5) = T6
        Expre(6) = T7
        Expre(7) = T8
    End Function
End Module

