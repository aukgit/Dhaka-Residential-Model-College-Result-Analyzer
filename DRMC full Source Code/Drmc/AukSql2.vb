Imports System.Data.OleDb
Public Module AukSql
    Public Sql As String
    Public Sql2 As String
    Public Sql3 As String
    Public sql4 As String
    Public Dset As DataSet
    Public ST(7) As Object
    Public SF(14) As Object
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
    Public ANDOR_orTrue(7) As Boolean
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
            If Expre(I) = "" Then
                If Trim(SF(I)) <> "" Then
                    If Trim(NM(I)) = "" And Trim(EP(I)) = "" Then
                        If LikeOpt = False Then
                            If Trim(LK(I)) <> "" Then
                                If ESum(I) <> "" Then
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) like '%" & ST(I) & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I) & "] like '%" & ST(I) & "%')"
                                End If

                            Else
                                CvObj(I) = "([" & SF(I) & "]" & m & ST(I) & "')"
                            End If
                        Else
                            If EP(I) = "" And NM(I) = "" Then
                                If ESum(I) <> "" Then '
                                    CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "])" & " like '%" & ST(I) & "%')"
                                Else
                                    CvObj(I) = "([" & SF(I) & "]" & " like '%" & ST(I) & "%')"
                                End If

                            End If
                        End If

                    Else

                        If Trim(EP(I)) <> "" Then
                            If ESum(I) = "" Then
                                CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) " & ST(I) & ")"
                            Else
                                CvObj(I) = "([" & SF(I) & "] " & ST(I) & ")"
                            End If

                        Else
                            CvObj(I) = "([" & SF(I) & "]=" & ST(I) & ")"
                        End If
                    End If

                Else
                    CvObj(I) = ""
                End If

                'If CvObj(I) <> "" Then
                '    If strvX = "" Then
                '        strvX = CvObj(I)
                '    Else
                '        strvX = strvX & " and " & CvObj(I)
                '    End If

                'End If
            Else
            'MsgBox("c")

            If LikeOpt = False Then
                '    If Trim(LK(I)) <> "" Then
                '        If ESum(I) <> "" Then
                '            CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "]) like " & Expre(I) & ")"
                '        Else
                '            CvObj(I) = "([" & SF(I) & "] like " & Expre(I) & ")"
                '        End If

                '    Else
                '        CvObj(I) = "([" & SF(I) & "]" & m & Expre(I) & "')"
                '    End If
                'Else

                '    If ESum(I) <> "" Then '
                '        CvObj(I) = "(" & ESum(I) & "([" & SF(I) & "])" & " like " & Expre(I) & ")"
                '    Else

                '    End If
                If SF(I) <> "" And Expre(I) <> "" Then
                    CvObj(I) = "([" & SF(I) & "]" & " = " & Expre(I) & ")"
                End If


            Else
                If SF(I) <> "" And Expre(I) <> "" Then
                    CvObj(I) = "([" & SF(I) & "]" & " like " & Expre(I) & ")"
                End If
                'MsgBox(CvObj(I))
            End If


            End If



            'End If

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
            ANDOR_orTrue(I) = False

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
        SF(0) = T.ToString
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
        SF(2) = t3.ToString

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
        SF(2) = t3.ToString
        SF(3) = T4.ToString
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
        SF(2) = t3.ToString
        SF(3) = T4.ToString
        SF(4) = T5.ToString

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
        SF(2) = t3.ToString
        SF(3) = T4.ToString
        SF(4) = T5.ToString
        SF(5) = T6.ToString
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object)
        SF(0) = T.ToString
        SF(1) = T2.ToString
        SF(2) = t3.ToString
        SF(3) = T4.ToString
        SF(4) = T5.ToString
        SF(5) = T6.ToString
        SF(6) = T7.ToString

    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If SF(0) = "" Then SF(0) = T.ToString
        If SF(1) = "" Then SF(1) = T2.ToString
        If SF(2) = "" Then SF(2) = t3.ToString
        If SF(3) = "" Then SF(3) = T4.ToString
        If SF(4) = "" Then SF(4) = T5.ToString
        If SF(5) = "" Then SF(5) = T6.ToString
        If SF(6) = "" Then SF(6) = T7.ToString
        If SF(7) = "" Then SF(7) = T8.ToString
    End Function
    Public Function SFC(ByVal T As Object, ByVal T2 As Object, ByVal t3 As Object, ByVal T4 As Object, ByVal T5 As Object, ByVal T6 As Object, ByVal T7 As Object, ByVal T8 As Object)
        If SF(0) = "" Then SF(0) = T.ToString
        If SF(1) = "" Then SF(1) = T2.ToString
        If SF(2) = "" Then SF(2) = t3.ToString
        If SF(3) = "" Then SF(3) = T4.ToString
        If SF(4) = "" Then SF(4) = T5.ToString
        If SF(5) = "" Then SF(5) = T6.ToString
        If SF(6) = "" Then SF(6) = T7.ToString
        If SF(7) = "" Then SF(7) = T8.ToString
        If SF(8) = "" Then SF(8) = T9.ToString
    End Function
    
End Module

