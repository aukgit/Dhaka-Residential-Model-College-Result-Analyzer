Imports System.Data.OleDb
Public Module AukSql
    Public Sql As String
    Public Sql2 As String
    Public Sql3 As String
    Public sql4 As String
    Public Dset As DataSet
    Public ST(14) As Object
    Public SF(14) As Object
    Public Connect As String = My.Settings.AukCon.ToString
    Dim InP(14) As Object
    Public Cn As New OleDb.OleDbConnection(Connect)
    Public DrC As DataColumn
    Public DrR As DataRow
    Public DT As DataTable
    Public NotOpt(14) As Boolean
    Public LK(14) As Object
    Public NM(14) As Object
    Public EP(14) As Object
    Public Expre(14) As Object
    Public GrpObj(14) As Object
    Public ANDOR_orTrue(14) As Boolean
    Public ESum(14) As Object
    Dim strvX As String
    Dim m, p As String
    Dim CvObj(14) As Object
    Public Adp As OleDbDataAdapter
    Public Function FirstSqlAukCmDND(ByVal TitleNames As String, ByVal GrpT As String, ByVal Grp As Boolean, ByVal OrB As Boolean, ByVal OpenTableName As String, ByVal LikeOpt As Boolean)
        'Dim I As Integer

        p = "') and"
        m = "='"
        For I = 0 To 14
            If Expre(I) = "" Then
                If Trim(SF(I)) <> "" Then
                    If Trim(NM(I)) = "" And Trim(EP(I)) = "" And Trim(InP(I)) = "" Then
                        If LikeOpt = False Then
                            If Trim(LK(I)) <> "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) like '" & ST(I) & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] like '" & ST(I) & "%')"
                                End If
                            Else
                                CvObj(I) = "([" & SF(I) & "]" & m & ST(I) & "')"
                            End If
                        Else
                            If EP(I) = "" And NM(I) = "" Then
                                If ESum(I) <> "" Then '
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "])" & " like '" & ST(I) & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I) & "]" & " like '" & ST(I) & "%')"
                                End If
                            End If
                        End If
                    ElseIf Trim(NM(I)) = "" And Trim(EP(I)) = "" And Trim(InP(I)) <> "" Then
                      
                        If ESum(I) <> "" Then
                            CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) In (" & ST(I) & "))"
                        Else
                            CvObj(I) = "([" & SF(I) & "] In (" & ST(I) & "))"
                        End If

                    Else

                        If Trim(EP(I)) <> "" And Trim(InP(I)) = "" Then
                            If Trim(LK(I)) = "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) " & EP(I) & ST(I) & ")"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] " & EP(I) & ST(I) & ")"
                                End If
                            ElseIf Trim(LK(I)) <> "" And Trim(InP(I)) = "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) Like " & EP(I) & ST(I) & ")"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] Like " & EP(I) & ST(I) & ")"
                                End If
                            ElseIf Trim(LK(I)) = "" And Trim(InP(I)) <> "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) " & EP(I) & " In ( " & ST(I) & "))"
                                Else
                                    CvObj(I) = "([" & SF(I) & "]) " & EP(I) & " In ( " & ST(I) & "))"
                                End If
                            End If
                        Else
                            CvObj(I) = "([" & SF(I) & "]=" & ST(I) & ")"
                        End If
                    End If
                Else
                    CvObj(I) = ""
                End If
            Else
                If LikeOpt = False Then
                    If SF(I) <> "" And Expre(I) <> "" Then
                        CvObj(I) = "([" & SF(I) & "]" & " = " & Expre(I) & ")"
                    End If
                Else
                    If SF(I) <> "" And Expre(I) <> "" Then
                        CvObj(I) = "([" & SF(I) & "]" & " like " & Expre(I) & ")"
                    End If
                End If
            End If
            If CvObj(I) <> "" Then
                If strvX = "" Then
                    strvX = CvObj(I)
                Else
                    If ANDOR_orTrue(I) = True Then
                        strvX = strvX & " Or " & CvObj(I)
                    Else
                        strvX = strvX & " and " & CvObj(I)
                    End If

                End If
            End If

            CvObj(I) = ""
            SF(I) = ""
            ST(I) = ""
            LK(I) = ""
            EP(I) = ""
            NM(I) = ""
            ESum(I) = ""
            Expre(I) = ""
            ANDOR_orTrue(I) = False
            InP(I) = ""
        Next
        If strvX <> "" Then
            Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )"
        Else
            Sql = "select " & TitleNames & " from " & OpenTableName
        End If
        cbt = GrpT
        If GrpT = "" Then
            GrpT = ""
        Else
            GrpT = " Group by " & GrpT
        End If
        If Grp = True Then
            If strvX <> "" And GrpT <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT & " Having ( " & strvX & " )"
            ElseIf strvX <> "" And GrpT = "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )"
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT
            End If
        End If
        GrpT = cbt
        If GrpT = "" Then
            GrpT = ""
        Else
            GrpT = " ORDER BY " & GrpT
        End If
        If OrB = True Then
            If strvX <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )" & GrpT
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT

            End If
        End If
        'For I = 0 To 14

        'Next
        strvX = ""
    End Function
    Public Function SqlAukCmDND(ByVal TitleNames As String, ByVal GrpT As String, ByVal Grp As Boolean, ByVal OrB As Boolean, ByVal OpenTableName As String, ByVal LikeOpt As Boolean)
        'Dim I As Integer

        p = "') and"
        m = "='"
        For I = 0 To 14
            If Expre(I) = "" Then
                If Trim(SF(I)) <> "" Then
                    If Trim(NM(I)) = "" And Trim(EP(I)) = "" And Trim(InP(I)) = "" Then
                        If LikeOpt = False Then
                            If Trim(LK(I)) <> "" Then
                                If NotOpt(I) = True Then
                                    If ESum(I) <> "" Then
                                        CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) Not Like '*" & ST(I) & "*')"
                                    Else
                                        CvObj(I) = "([" & SF(I) & "] Not Like '%" & ST(I) & "%')"
                                    End If
                                Else
                                    If ESum(I) <> "" Then
                                        CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) like '*" & ST(I) & "*')"
                                    Else
                                        CvObj(I) = "([" & SF(I) & "] like '%" & ST(I) & "%')"
                                    End If
                                End If

                            Else
                                If NotOpt(I) = True Then
                                    CvObj(I) = "([" & SF(I) & "]" & "<>'" & ST(I) & "')"
                                Else
                                    CvObj(I) = "([" & SF(I) & "]" & m & ST(I) & "')"
                                End If

                            End If
                        Else
                            If EP(I) = "" And NM(I) = "" Then
                                If NotOpt(I) = False Then
                                    If ESum(I) <> "" Then '
                                        CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "])" & " like '*" & ST(I) & "*')"
                                    Else
                                        CvObj(I) = "([" & SF(I) & "]" & " like '%" & ST(I) & "%')"
                                    End If
                                Else
                                    If ESum(I) <> "" Then '
                                        CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "])" & " Not like '*" & ST(I) & "*')"
                                    Else
                                        CvObj(I) = "([" & SF(I) & "]" & " Not like '%" & ST(I) & "%')"
                                    End If
                                End If
                               
                            End If
                        End If
                    ElseIf Trim(NM(I)) = "" And Trim(EP(I)) = "" And Trim(InP(I)) <> "" Then

                        If ESum(I) <> "" Then
                            CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) In (" & ST(I) & "))"
                        Else
                            CvObj(I) = "([" & SF(I) & "] In (" & ST(I) & "))"
                        End If

                    Else

                        If Trim(EP(I)) <> "" And Trim(InP(I)) = "" Then
                            If Trim(LK(I)) = "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) " & EP(I) & ST(I) & ")"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] " & EP(I) & ST(I) & ")"
                                End If
                            ElseIf Trim(LK(I)) <> "" And Trim(InP(I)) = "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) Like " & EP(I) & ST(I) & ")"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] Like " & EP(I) & ST(I) & ")"
                                End If
                            ElseIf Trim(LK(I)) = "" And Trim(InP(I)) <> "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) " & EP(I) & " In ( " & ST(I) & "))"
                                Else
                                    CvObj(I) = "([" & SF(I) & "]) " & EP(I) & " In ( " & ST(I) & "))"
                                End If
                            End If
                        Else
                            CvObj(I) = "([" & SF(I) & "]=" & ST(I) & ")"
                        End If
                    End If
                Else
                    CvObj(I) = ""
                End If
            Else
                If LikeOpt = False Then
                    If SF(I) <> "" And Expre(I) <> "" Then
                        CvObj(I) = "([" & SF(I) & "]" & " = " & Expre(I) & ")"
                    End If
                Else
                    If SF(I) <> "" And Expre(I) <> "" Then
                        CvObj(I) = "([" & SF(I) & "]" & " like " & Expre(I) & ")"
                    End If
                End If
            End If
            If CvObj(I) <> "" Then
                If strvX = "" Then
                    strvX = CvObj(I)
                Else
                    If ANDOR_orTrue(I) = True Then
                        strvX = strvX & " Or " & CvObj(I)
                    Else
                        strvX = strvX & " and " & CvObj(I)
                    End If

                End If
            End If

            CvObj(I) = ""
            SF(I) = ""
            ST(I) = ""
            LK(I) = ""
            EP(I) = ""
            NM(I) = ""
            ESum(I) = ""
            Expre(I) = ""
            ANDOR_orTrue(I) = False
            InP(I) = ""
        Next
        If strvX <> "" Then
            Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )"
        Else
            Sql = "select " & TitleNames & " from " & OpenTableName
        End If
        cbt = GrpT
        If GrpT = "" Then
            GrpT = ""
        Else
            GrpT = " Group by " & GrpT
        End If
        If Grp = True Then
            If strvX <> "" And GrpT <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT & " Having ( " & strvX & " )"
            ElseIf strvX <> "" And GrpT = "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )"
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT
            End If
        End If
        GrpT = cbt
        If GrpT = "" Then
            GrpT = ""
        Else
            GrpT = " ORDER BY " & GrpT
        End If
        If OrB = True Then
            If strvX <> "" Then
                Sql = "select " & TitleNames & " from " & OpenTableName & " where ( " & strvX & " )" & GrpT
            Else
                Sql = "select " & TitleNames & " from " & OpenTableName & GrpT

            End If
        End If
        'For I = 0 To 14

        'Next
        strvX = ""
    End Function
    Public Function SqlAukCmD(ByVal TitleNames As String, ByVal OpenTableName As String, ByVal Likeuse As Boolean, ByVal AnyWhere As Boolean)
        'Dim m, p As String
        'Dim CvObj(7) As Object
        'Dim strvX As String
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
            ''MsgBox(Sql)

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
        If SF(0) = "" Then SF(0) = T
      
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
    
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
    End Function

    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
    End Function
    'Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If SF(0) = "" Then SF(0) = T
    '    If SF(1) = "" Then SF(1) = T2
    '    If SF(2) = "" Then SF(2) = t3
    '    If SF(3) = "" Then SF(3) = T4
    '    If SF(4) = "" Then SF(4) = T5
    '    If SF(5) = "" Then SF(5) = T6
    '    If SF(6) = "" Then SF(6) = T7
    '    If SF(7) = "" Then SF(7) = T8


    'End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        'If SF(10) = "" Then SF(10) = T11
        'If SF(11) = "" Then SF(11) = T12
        'If SF(12) = "" Then SF(12) = T13

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        If SF(10) = "" Then SF(10) = T11
        'If SF(11) = "" Then SF(11) = T12
        'If SF(12) = "" Then SF(12) = T13

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        If SF(10) = "" Then SF(10) = T11
        If SF(11) = "" Then SF(11) = T12
        'If SF(12) = "" Then SF(12) = T13

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        If SF(10) = "" Then SF(10) = T11
        If SF(11) = "" Then SF(11) = T12
        If SF(12) = "" Then SF(12) = T13

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        If SF(10) = "" Then SF(10) = T11
        If SF(11) = "" Then SF(11) = T12
        If SF(12) = "" Then SF(12) = T13
        If SF(13) = "" Then SF(13) = T14

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If SF(0) = "" Then SF(0) = T
        If SF(1) = "" Then SF(1) = T2
        If SF(2) = "" Then SF(2) = t3
        If SF(3) = "" Then SF(3) = T4
        If SF(4) = "" Then SF(4) = T5
        If SF(5) = "" Then SF(5) = T6
        If SF(6) = "" Then SF(6) = T7
        If SF(7) = "" Then SF(7) = T8
        If SF(8) = "" Then SF(8) = t9
        If SF(9) = "" Then SF(9) = T10
        If SF(10) = "" Then SF(10) = T11
        If SF(11) = "" Then SF(11) = T12
        If SF(12) = "" Then SF(12) = T13
        If SF(13) = "" Then SF(13) = T14
        If SF(14) = "" Then SF(14) = T15
    End Function
    Public Function STC(ByVal T As Object)
        If ST(0) = "" Then ST(0) = T

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
    End Function

    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
    End Function
    'Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If ST(0) = "" Then ST(0) = T
    '    If ST(1) = "" Then ST(1) = T2
    '    If ST(2) = "" Then ST(2) = t3
    '    If ST(3) = "" Then ST(3) = T4
    '    If ST(4) = "" Then ST(4) = T5
    '    If ST(5) = "" Then ST(5) = T6
    '    If ST(6) = "" Then ST(6) = T7
    '    If ST(7) = "" Then ST(7) = T8


    'End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        'If ST(10) = "" Then ST(10) = T11
        'If ST(11) = "" Then ST(11) = T12
        'If ST(12) = "" Then ST(12) = T13

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        If ST(10) = "" Then ST(10) = T11
        'If ST(11) = "" Then ST(11) = T12
        'If ST(12) = "" Then ST(12) = T13

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        If ST(10) = "" Then ST(10) = T11
        If ST(11) = "" Then ST(11) = T12
        'If ST(12) = "" Then ST(12) = T13

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        If ST(10) = "" Then ST(10) = T11
        If ST(11) = "" Then ST(11) = T12
        If ST(12) = "" Then ST(12) = T13

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        If ST(10) = "" Then ST(10) = T11
        If ST(11) = "" Then ST(11) = T12
        If ST(12) = "" Then ST(12) = T13
        If ST(13) = "" Then ST(13) = T14

    End Function
    Public Function STC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If ST(0) = "" Then ST(0) = T
        If ST(1) = "" Then ST(1) = T2
        If ST(2) = "" Then ST(2) = t3
        If ST(3) = "" Then ST(3) = T4
        If ST(4) = "" Then ST(4) = T5
        If ST(5) = "" Then ST(5) = T6
        If ST(6) = "" Then ST(6) = T7
        If ST(7) = "" Then ST(7) = T8
        If ST(8) = "" Then ST(8) = t9
        If ST(9) = "" Then ST(9) = T10
        If ST(10) = "" Then ST(10) = T11
        If ST(11) = "" Then ST(11) = T12
        If ST(12) = "" Then ST(12) = T13
        If ST(13) = "" Then ST(13) = T14
        If ST(14) = "" Then ST(14) = T15
    End Function
    Public Function LKC(ByVal T As Object)
        If LK(0) = "" Then LK(0) = T

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
    End Function

    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
    End Function
    'Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If LK(0) = "" Then LK(0) = T
    '    If LK(1) = "" Then LK(1) = T2
    '    If LK(2) = "" Then LK(2) = t3
    '    If LK(3) = "" Then LK(3) = T4
    '    If LK(4) = "" Then LK(4) = T5
    '    If LK(5) = "" Then LK(5) = T6
    '    If LK(6) = "" Then LK(6) = T7
    '    If LK(7) = "" Then LK(7) = T8


    'End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        'If LK(10) = "" Then LK(10) = T11
        'If LK(11) = "" Then LK(11) = T12
        'If LK(12) = "" Then LK(12) = T13

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        If LK(10) = "" Then LK(10) = T11
        'If LK(11) = "" Then LK(11) = T12
        'If LK(12) = "" Then LK(12) = T13

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        If LK(10) = "" Then LK(10) = T11
        If LK(11) = "" Then LK(11) = T12
        'If LK(12) = "" Then LK(12) = T13

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        If LK(10) = "" Then LK(10) = T11
        If LK(11) = "" Then LK(11) = T12
        If LK(12) = "" Then LK(12) = T13

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        If LK(10) = "" Then LK(10) = T11
        If LK(11) = "" Then LK(11) = T12
        If LK(12) = "" Then LK(12) = T13
        If LK(13) = "" Then LK(13) = T14

    End Function
    Public Function LKC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If LK(0) = "" Then LK(0) = T
        If LK(1) = "" Then LK(1) = T2
        If LK(2) = "" Then LK(2) = t3
        If LK(3) = "" Then LK(3) = T4
        If LK(4) = "" Then LK(4) = T5
        If LK(5) = "" Then LK(5) = T6
        If LK(6) = "" Then LK(6) = T7
        If LK(7) = "" Then LK(7) = T8
        If LK(8) = "" Then LK(8) = t9
        If LK(9) = "" Then LK(9) = T10
        If LK(10) = "" Then LK(10) = T11
        If LK(11) = "" Then LK(11) = T12
        If LK(12) = "" Then LK(12) = T13
        If LK(13) = "" Then LK(13) = T14
        If LK(14) = "" Then LK(14) = T15
    End Function
    Public Function ESUMC(ByVal T As Object)
        If ESUM(0) = "" Then ESUM(0) = T

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
    End Function

    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
    End Function
    'Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If ESUM(0) = "" Then ESUM(0) = T
    '    If ESUM(1) = "" Then ESUM(1) = T2
    '    If ESUM(2) = "" Then ESUM(2) = t3
    '    If ESUM(3) = "" Then ESUM(3) = T4
    '    If ESUM(4) = "" Then ESUM(4) = T5
    '    If ESUM(5) = "" Then ESUM(5) = T6
    '    If ESUM(6) = "" Then ESUM(6) = T7
    '    If ESUM(7) = "" Then ESUM(7) = T8


    'End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        'If ESUM(10) = "" Then ESUM(10) = T11
        'If ESUM(11) = "" Then ESUM(11) = T12
        'If ESUM(12) = "" Then ESUM(12) = T13

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        If ESUM(10) = "" Then ESUM(10) = T11
        'If ESUM(11) = "" Then ESUM(11) = T12
        'If ESUM(12) = "" Then ESUM(12) = T13

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        If ESUM(10) = "" Then ESUM(10) = T11
        If ESUM(11) = "" Then ESUM(11) = T12
        'If ESUM(12) = "" Then ESUM(12) = T13

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        If ESUM(10) = "" Then ESUM(10) = T11
        If ESUM(11) = "" Then ESUM(11) = T12
        If ESUM(12) = "" Then ESUM(12) = T13

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        If ESUM(10) = "" Then ESUM(10) = T11
        If ESUM(11) = "" Then ESUM(11) = T12
        If ESUM(12) = "" Then ESUM(12) = T13
        If ESUM(13) = "" Then ESUM(13) = T14

    End Function
    Public Function ESUMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If ESUM(0) = "" Then ESUM(0) = T
        If ESUM(1) = "" Then ESUM(1) = T2
        If ESUM(2) = "" Then ESUM(2) = t3
        If ESUM(3) = "" Then ESUM(3) = T4
        If ESUM(4) = "" Then ESUM(4) = T5
        If ESUM(5) = "" Then ESUM(5) = T6
        If ESUM(6) = "" Then ESUM(6) = T7
        If ESUM(7) = "" Then ESUM(7) = T8
        If ESUM(8) = "" Then ESUM(8) = t9
        If ESUM(9) = "" Then ESUM(9) = T10
        If ESUM(10) = "" Then ESUM(10) = T11
        If ESUM(11) = "" Then ESUM(11) = T12
        If ESUM(12) = "" Then ESUM(12) = T13
        If ESUM(13) = "" Then ESum(13) = T14
        If ESum(14) = "" Then ESum(14) = T15
    End Function
    Public Function ExpreC(ByVal T As Object)
        If Expre(0) = "" Then Expre(0) = T

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
    End Function

    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
    End Function
    'Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If Expre(0) = "" Then Expre(0) = T
    '    If Expre(1) = "" Then Expre(1) = T2
    '    If Expre(2) = "" Then Expre(2) = t3
    '    If Expre(3) = "" Then Expre(3) = T4
    '    If Expre(4) = "" Then Expre(4) = T5
    '    If Expre(5) = "" Then Expre(5) = T6
    '    If Expre(6) = "" Then Expre(6) = T7
    '    If Expre(7) = "" Then Expre(7) = T8


    'End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        'If Expre(10) = "" Then Expre(10) = T11
        'If Expre(11) = "" Then Expre(11) = T12
        'If Expre(12) = "" Then Expre(12) = T13

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        If Expre(10) = "" Then Expre(10) = T11
        'If Expre(11) = "" Then Expre(11) = T12
        'If Expre(12) = "" Then Expre(12) = T13

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        If Expre(10) = "" Then Expre(10) = T11
        If Expre(11) = "" Then Expre(11) = T12
        'If Expre(12) = "" Then Expre(12) = T13

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        If Expre(10) = "" Then Expre(10) = T11
        If Expre(11) = "" Then Expre(11) = T12
        If Expre(12) = "" Then Expre(12) = T13

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        If Expre(10) = "" Then Expre(10) = T11
        If Expre(11) = "" Then Expre(11) = T12
        If Expre(12) = "" Then Expre(12) = T13
        If Expre(13) = "" Then Expre(13) = T14

    End Function
    Public Function ExpreC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If Expre(0) = "" Then Expre(0) = T
        If Expre(1) = "" Then Expre(1) = T2
        If Expre(2) = "" Then Expre(2) = t3
        If Expre(3) = "" Then Expre(3) = T4
        If Expre(4) = "" Then Expre(4) = T5
        If Expre(5) = "" Then Expre(5) = T6
        If Expre(6) = "" Then Expre(6) = T7
        If Expre(7) = "" Then Expre(7) = T8
        If Expre(8) = "" Then Expre(8) = t9
        If Expre(9) = "" Then Expre(9) = T10
        If Expre(10) = "" Then Expre(10) = T11
        If Expre(11) = "" Then Expre(11) = T12
        If Expre(12) = "" Then Expre(12) = T13
        If Expre(13) = "" Then Expre(13) = T14
        If Expre(14) = "" Then Expre(14) = T15
    End Function

    Public Function EPC(ByVal T As Object)
        If EP(0) = "" Then EP(0) = T

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
    End Function

    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
    End Function
    'Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If EP(0) = "" Then EP(0) = T
    '    If EP(1) = "" Then EP(1) = T2
    '    If EP(2) = "" Then EP(2) = t3
    '    If EP(3) = "" Then EP(3) = T4
    '    If EP(4) = "" Then EP(4) = T5
    '    If EP(5) = "" Then EP(5) = T6
    '    If EP(6) = "" Then EP(6) = T7
    '    If EP(7) = "" Then EP(7) = T8


    'End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        'If EP(10) = "" Then EP(10) = T11
        'If EP(11) = "" Then EP(11) = T12
        'If EP(12) = "" Then EP(12) = T13

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        If EP(10) = "" Then EP(10) = T11
        'If EP(11) = "" Then EP(11) = T12
        'If EP(12) = "" Then EP(12) = T13

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        If EP(10) = "" Then EP(10) = T11
        If EP(11) = "" Then EP(11) = T12
        'If EP(12) = "" Then EP(12) = T13

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        If EP(10) = "" Then EP(10) = T11
        If EP(11) = "" Then EP(11) = T12
        If EP(12) = "" Then EP(12) = T13

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        If EP(10) = "" Then EP(10) = T11
        If EP(11) = "" Then EP(11) = T12
        If EP(12) = "" Then EP(12) = T13
        If EP(13) = "" Then EP(13) = T14

    End Function
    Public Function EPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If EP(0) = "" Then EP(0) = T
        If EP(1) = "" Then EP(1) = T2
        If EP(2) = "" Then EP(2) = t3
        If EP(3) = "" Then EP(3) = T4
        If EP(4) = "" Then EP(4) = T5
        If EP(5) = "" Then EP(5) = T6
        If EP(6) = "" Then EP(6) = T7
        If EP(7) = "" Then EP(7) = T8
        If EP(8) = "" Then EP(8) = t9
        If EP(9) = "" Then EP(9) = T10
        If EP(10) = "" Then EP(10) = T11
        If EP(11) = "" Then EP(11) = T12
        If EP(12) = "" Then EP(12) = T13
        If EP(13) = "" Then EP(13) = T14
        If EP(14) = "" Then EP(14) = T15
    End Function
    Public Function NMC(ByVal T As Object)
        If NM(0) = "" Then NM(0) = T

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
    End Function

    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
    End Function
    'Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If NM(0) = "" Then NM(0) = T
    '    If NM(1) = "" Then NM(1) = T2
    '    If NM(2) = "" Then NM(2) = t3
    '    If NM(3) = "" Then NM(3) = T4
    '    If NM(4) = "" Then NM(4) = T5
    '    If NM(5) = "" Then NM(5) = T6
    '    If NM(6) = "" Then NM(6) = T7
    '    If NM(7) = "" Then NM(7) = T8


    'End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        'If NM(10) = "" Then NM(10) = T11
        'If NM(11) = "" Then NM(11) = T12
        'If NM(12) = "" Then NM(12) = T13

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        If NM(10) = "" Then NM(10) = T11
        'If NM(11) = "" Then NM(11) = T12
        'If NM(12) = "" Then NM(12) = T13

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        If NM(10) = "" Then NM(10) = T11
        If NM(11) = "" Then NM(11) = T12
        'If NM(12) = "" Then NM(12) = T13

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        If NM(10) = "" Then NM(10) = T11
        If NM(11) = "" Then NM(11) = T12
        If NM(12) = "" Then NM(12) = T13

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        If NM(10) = "" Then NM(10) = T11
        If NM(11) = "" Then NM(11) = T12
        If NM(12) = "" Then NM(12) = T13
        If NM(13) = "" Then NM(13) = T14

    End Function
    Public Function NMC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If NM(0) = "" Then NM(0) = T
        If NM(1) = "" Then NM(1) = T2
        If NM(2) = "" Then NM(2) = t3
        If NM(3) = "" Then NM(3) = T4
        If NM(4) = "" Then NM(4) = T5
        If NM(5) = "" Then NM(5) = T6
        If NM(6) = "" Then NM(6) = T7
        If NM(7) = "" Then NM(7) = T8
        If NM(8) = "" Then NM(8) = t9
        If NM(9) = "" Then NM(9) = T10
        If NM(10) = "" Then NM(10) = T11
        If NM(11) = "" Then NM(11) = T12
        If NM(12) = "" Then NM(12) = T13
        If NM(13) = "" Then NM(13) = T14
        If NM(14) = "" Then NM(14) = T15
    End Function
    Public Function andor_orTrueC(ByVal T As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        'If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        'If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        'If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        'If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        'If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15
    End Function

    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        'If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        'If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        'If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        'If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        'If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        'If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        'If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        'If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        'If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        'If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15
    End Function
    'Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean)
    '    If andor_orTrue(0) = False Then andor_orTrue(0) = T
    '    If andor_orTrue(1) = False Then andor_orTrue(1) = T2
    '    If andor_orTrue(2) = False Then andor_orTrue(2) = t3
    '    If andor_orTrue(3) = False Then andor_orTrue(3) = T4
    '    If andor_orTrue(4) = False Then andor_orTrue(4) = T5
    '    If andor_orTrue(5) = False Then andor_orTrue(5) = T6
    '    If andor_orTrue(6) = False Then andor_orTrue(6) = T7
    '    If andor_orTrue(7) = False Then andor_orTrue(7) = T8


    'End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        'If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        'If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        'If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        'If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        'If andor_orTrue(12) = False Then andor_orTrue(12) = T13

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean, ByVal T14 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        'If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15

    End Function
    Public Function andor_orTrueC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean, ByVal T14 As Boolean, ByVal T15 As Boolean)
        If ANDOR_orTrue(0) = False Then ANDOR_orTrue(0) = T
        If ANDOR_orTrue(1) = False Then ANDOR_orTrue(1) = T2
        If ANDOR_orTrue(2) = False Then ANDOR_orTrue(2) = t3
        If ANDOR_orTrue(3) = False Then ANDOR_orTrue(3) = T4
        If ANDOR_orTrue(4) = False Then ANDOR_orTrue(4) = T5
        If ANDOR_orTrue(5) = False Then ANDOR_orTrue(5) = T6
        If ANDOR_orTrue(6) = False Then ANDOR_orTrue(6) = T7
        If ANDOR_orTrue(7) = False Then ANDOR_orTrue(7) = T8
        If ANDOR_orTrue(8) = False Then ANDOR_orTrue(8) = t9
        If ANDOR_orTrue(9) = False Then ANDOR_orTrue(9) = T10
        If ANDOR_orTrue(10) = False Then ANDOR_orTrue(10) = T11
        If ANDOR_orTrue(11) = False Then ANDOR_orTrue(11) = T12
        If ANDOR_orTrue(12) = False Then ANDOR_orTrue(12) = T13
        If ANDOR_orTrue(13) = False Then ANDOR_orTrue(13) = T14
        If ANDOR_orTrue(14) = False Then ANDOR_orTrue(14) = T15
    End Function
    Public Function NotoptC(ByVal T As Boolean)
        If Notopt(0) = False Then Notopt(0) = T

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        'If Notopt(4) = False Then Notopt(4) = T5
        'If Notopt(5) = False Then Notopt(5) = T6
        'If Notopt(6) = False Then Notopt(6) = T7
        'If Notopt(7) = False Then Notopt(7) = T8
        'If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15
    End Function

    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        'If Notopt(5) = False Then Notopt(5) = T6
        'If Notopt(6) = False Then Notopt(6) = T7
        'If Notopt(7) = False Then Notopt(7) = T8
        'If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        'If Notopt(6) = False Then Notopt(6) = T7
        'If Notopt(7) = False Then Notopt(7) = T8
        'If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        'If Notopt(7) = False Then Notopt(7) = T8
        'If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        'If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15
    End Function
    'Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean)
    '    If Notopt(0) = False Then Notopt(0) = T
    '    If Notopt(1) = False Then Notopt(1) = T2
    '    If Notopt(2) = False Then Notopt(2) = t3
    '    If Notopt(3) = False Then Notopt(3) = T4
    '    If Notopt(4) = False Then Notopt(4) = T5
    '    If Notopt(5) = False Then Notopt(5) = T6
    '    If Notopt(6) = False Then Notopt(6) = T7
    '    If Notopt(7) = False Then Notopt(7) = T8


    'End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        If Notopt(8) = False Then Notopt(8) = t9
        'If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        If Notopt(8) = False Then Notopt(8) = t9
        If Notopt(9) = False Then Notopt(9) = T10
        'If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        If Notopt(8) = False Then Notopt(8) = t9
        If Notopt(9) = False Then Notopt(9) = T10
        If Notopt(10) = False Then Notopt(10) = T11
        'If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13
        'If Notopt(13) = False Then Notopt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        If Notopt(8) = False Then Notopt(8) = t9
        If Notopt(9) = False Then Notopt(9) = T10
        If Notopt(10) = False Then Notopt(10) = T11
        If Notopt(11) = False Then Notopt(11) = T12
        'If Notopt(12) = False Then Notopt(12) = T13

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean)
        If Notopt(0) = False Then Notopt(0) = T
        If Notopt(1) = False Then Notopt(1) = T2
        If Notopt(2) = False Then Notopt(2) = t3
        If Notopt(3) = False Then Notopt(3) = T4
        If Notopt(4) = False Then Notopt(4) = T5
        If Notopt(5) = False Then Notopt(5) = T6
        If Notopt(6) = False Then Notopt(6) = T7
        If Notopt(7) = False Then Notopt(7) = T8
        If Notopt(8) = False Then Notopt(8) = t9
        If Notopt(9) = False Then Notopt(9) = T10
        If Notopt(10) = False Then Notopt(10) = T11
        If Notopt(11) = False Then Notopt(11) = T12
        If Notopt(12) = False Then Notopt(12) = T13
    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean, ByVal T14 As Boolean)
        If NotOpt(0) = False Then NotOpt(0) = T
        If NotOpt(1) = False Then NotOpt(1) = T2
        If NotOpt(2) = False Then NotOpt(2) = t3
        If NotOpt(3) = False Then NotOpt(3) = T4
        If NotOpt(4) = False Then NotOpt(4) = T5
        If NotOpt(5) = False Then NotOpt(5) = T6
        If NotOpt(6) = False Then NotOpt(6) = T7
        If NotOpt(7) = False Then NotOpt(7) = T8
        If NotOpt(8) = False Then NotOpt(8) = t9
        If NotOpt(9) = False Then NotOpt(9) = T10
        If NotOpt(10) = False Then NotOpt(10) = T11
        If NotOpt(11) = False Then NotOpt(11) = T12
        If NotOpt(12) = False Then NotOpt(12) = T13
        If NotOpt(13) = False Then NotOpt(13) = T14
        'If Notopt(14) = False Then Notopt(14) = T15

    End Function
    Public Function NotoptC(ByVal T As Boolean, ByVal T2 As Boolean, ByVal t3 As Boolean, ByVal T4 As Boolean, ByVal T5 As Boolean, ByVal T6 As Boolean, ByVal T7 As Boolean, ByVal T8 As Boolean, ByVal t9 As Boolean, ByVal T10 As Boolean, ByVal T11 As Boolean, ByVal T12 As Boolean, ByVal T13 As Boolean, ByVal T14 As Boolean, ByVal T15 As Boolean)
        If NotOpt(0) = False Then NotOpt(0) = T
        If NotOpt(1) = False Then NotOpt(1) = T2
        If NotOpt(2) = False Then NotOpt(2) = t3
        If NotOpt(3) = False Then NotOpt(3) = T4
        If NotOpt(4) = False Then NotOpt(4) = T5
        If NotOpt(5) = False Then NotOpt(5) = T6
        If NotOpt(6) = False Then NotOpt(6) = T7
        If NotOpt(7) = False Then NotOpt(7) = T8
        If NotOpt(8) = False Then NotOpt(8) = t9
        If NotOpt(9) = False Then NotOpt(9) = T10
        If NotOpt(10) = False Then NotOpt(10) = T11
        If NotOpt(11) = False Then NotOpt(11) = T12
        If NotOpt(12) = False Then NotOpt(12) = T13
        If NotOpt(13) = False Then NotOpt(13) = T14
        If NotOpt(14) = False Then NotOpt(14) = T15
    End Function

    Public Function INPC(ByVal T As Object)
        If INP(0) = "" Then INP(0) = T

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
    End Function

    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
    End Function
    'Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
    '    If INP(0) = "" Then INP(0) = T
    '    If INP(1) = "" Then INP(1) = T2
    '    If INP(2) = "" Then INP(2) = t3
    '    If INP(3) = "" Then INP(3) = T4
    '    If INP(4) = "" Then INP(4) = T5
    '    If INP(5) = "" Then INP(5) = T6
    '    If INP(6) = "" Then INP(6) = T7
    '    If INP(7) = "" Then INP(7) = T8


    'End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        'If INP(10) = "" Then INP(10) = T11
        'If INP(11) = "" Then INP(11) = T12
        'If INP(12) = "" Then INP(12) = T13

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        If INP(10) = "" Then INP(10) = T11
        'If INP(11) = "" Then INP(11) = T12
        'If INP(12) = "" Then INP(12) = T13

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        If INP(10) = "" Then INP(10) = T11
        If INP(11) = "" Then INP(11) = T12
        'If INP(12) = "" Then INP(12) = T13

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        If INP(10) = "" Then INP(10) = T11
        If INP(11) = "" Then INP(11) = T12
        If INP(12) = "" Then INP(12) = T13

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        If INP(10) = "" Then INP(10) = T11
        If INP(11) = "" Then INP(11) = T12
        If INP(12) = "" Then INP(12) = T13
        If INP(13) = "" Then INP(13) = T14

    End Function
    Public Function INPC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object, ByVal t9 As Object, ByVal T10 As Object, ByVal T11 As Object, ByVal T12 As Object, ByVal T13 As Object, ByVal T14 As Object, ByVal T15 As Object)
        If INP(0) = "" Then INP(0) = T
        If INP(1) = "" Then INP(1) = T2
        If INP(2) = "" Then INP(2) = t3
        If INP(3) = "" Then INP(3) = T4
        If INP(4) = "" Then INP(4) = T5
        If INP(5) = "" Then INP(5) = T6
        If INP(6) = "" Then INP(6) = T7
        If INP(7) = "" Then INP(7) = T8
        If INP(8) = "" Then INP(8) = t9
        If INP(9) = "" Then INP(9) = T10
        If INP(10) = "" Then INP(10) = T11
        If INP(11) = "" Then INP(11) = T12
        If INP(12) = "" Then InP(12) = T13
        If InP(13) = "" Then ESum(13) = T14
        If ESum(14) = "" Then ESum(14) = T15
    End Function
End Module

