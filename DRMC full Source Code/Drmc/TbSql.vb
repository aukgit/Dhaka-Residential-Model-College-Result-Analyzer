Module TbSql
    Public Function Sql_Cls_Ord_like_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataTable)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, True)
        DsSet.Clear()

        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)
        End Try
    End Function
    Public Function Sql_NonCls_Ord_like_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataTable)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, True)
        'DsSet.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)
        End Try
    End Function
    Public Function Sql_Gr_LikeUse_False(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, False)
        DSetX.Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try

    End Function
    Public Function Sql_Gr_LikeUse(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, True)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function SqlNonClr_Gr_likeUse_false(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, False)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function Sql_ORD_like_false(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, False)
        DSetX.Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try

    End Function
    Public Function Sql_ORD_likeUse(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, True)
        DSetX.Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try

    End Function
    Public Function NonCls_ORD_LikeCommand(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, True)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function NonCls_ORD_NonLikeCommand(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataTable)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, False)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function ExpressionQueryTxt(ByVal OpenWith As Boolean, ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal Expression As String, ByVal DSetX As DataTable)
        Sql = "select " & TabTitles & " from where " & Expression
        'AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, OpenTableName)
        Try
            If OpenWith = True Then
            Else
                DSetX.Clear()
            End If
            '
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX)
        Catch ex As Exception
            Epx()

        End Try
   
    End Function
End Module
