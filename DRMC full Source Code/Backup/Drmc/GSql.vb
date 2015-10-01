Module GSql
    'Public Adp As OleDb.OleDbDataAdapter
    'Public Function SqlQuery_GroupSection_LikeUse(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
    '    AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, True)
    '    DSetX.Tables(OpenTableName).Clear()
    '    Try
    '        Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
    '        Adp.Fill(DSetX, OpenTableName)
    '    Catch ex As Exception
    '        Ebx(Err.Number, Err.Description)

    '    End Try

    'End Function
    Public Function Sql_Cls_Ord_like_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataSet)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, True)
        DsSet.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function Sql_NonCls_Ord_like_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataSet)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, True)
        'DsSet.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function Sql_Cls_Ord_NonLike_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataSet)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, False)
        DsSet.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)
        End Try
    End Function
    Public Function Sql_NonCls_Ord_NonLike_From_First(ByVal TableTiles As String, ByVal OpenTableName As String, ByVal OrdTab As String, ByVal DsSet As DataSet)
        FirstSqlAukCmDND(TableTiles, GrpTXT, False, True, OpenTableName, False)
        'DsSet.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DsSet, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
    End Function
    Public Function Sql_Gr_LikeUse_False(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, False)
        DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try

    End Function
    Public Function Sql_Gr_LikeUse(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, True)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try
    End Function
    Public Function SqlNonClr_Gr_likeUse_false(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, False, OpenTableName, False)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try
    End Function
    Public Function Sql_ORD_like_false(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, False)
        DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Epx(Sql)



        End Try

    End Function
    Public Function Sql_ORD_likeUse(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, True)
        DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try

    End Function
    Public Function NonCls_ORD_LikeCommand(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, True)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try
    End Function
    Public Function NonCls_ORD_NonLikeCommand(ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal DSetX As DataSet)
        AukSql.SqlAukCmDND(TabTitles, GrpTXT, False, True, OpenTableName, False)
        'DSetX.Tables(OpenTableName).Clear()
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)


        End Try
    End Function
    Public Function ExpressionQueryTxt(ByVal OpenWith As Boolean, ByVal TabTitles As String, ByVal OpenTableName As String, ByVal GrpTXT As String, ByVal Expression As String, ByVal DSetX As DataSet)
        Sql = "select " & TabTitles & " from where " & Expression
        'AukSql.SqlAukCmDND(TabTitles, GrpTXT, True, OpenTableName)
        If OpenWith = True Then
        Else
            DSetX.Tables(OpenTableName).Clear()
        End If
        '
        Try
            Adp = New OleDb.OleDbDataAdapter(Sql, Cn)
            Adp.Fill(DSetX, OpenTableName)
        Catch ex As Exception
            Ebx(Err.Number, Err.Description & vbCrLf & "Sql : " & Sql)

        End Try
 
    End Function
End Module
