Public Module SqlBuilder
    Public mFrm As New SqlQueryBuilder
    Public xFrm As New Form
    Public Flv As AxShockwaveFlashObjects.AxShockwaveFlash = mFrm.AxShockwaveFlash1
    Public CText As New TextBox

    Public Function FirstStep(ByVal SqlTableName As String, ByVal ColumnName As String)

        'Flv = mFrm.AxShockwaveFlash1
        xFrm.Enabled = False
        mFrm.Show()
        Flv.SetVariable("column", ColumnName)
        Flv.SetVariable("tablename", SqlTableName)
        Flv.SetVariable("sqlcmd", "")

        'Sql2 = "Select " & SqlTitle & " from  " & Sqltab & " Order By " & OrderTitle & " where " & textboxtext



    End Function
    'Public Function CrSql(ByVal Sqltab As String, ByVal SqlTitle As String, ByVal BeforeText As String, ByVal OrderTitle As String)

    'End Function
    'public function (
End Module
