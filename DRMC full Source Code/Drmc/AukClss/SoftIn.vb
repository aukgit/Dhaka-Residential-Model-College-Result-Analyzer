Public Module SoftIn
    Public MultiF As Form
    ''' <summary>
    ''' BpFind:Find Items From...
    ''' BpRp:Relation BindingSource ...
    ''' RColumn:Select Same Item what found in this Column...
    ''' FoundChk:If True then if found then Items Check Auto...
    ''' </summary>
    ''' <remarks></remarks>
    ''' <param name="BpFind"></param>
    ''' <param name="BpRp"></param>
    ''' <param name="RColumn"></param>
    ''' <param name="FoundChk"></param>
    ''' <param name="BeforeUnCheck"></param>
    ''' <returns></returns>
    ''' 
    Dim Iw As Integer

    Public Function CheckListBoxRelationChecked(ByVal ChkLst As CheckedListBox, ByVal BpFind As BindingSource, ByVal BpRp As System.Windows.Forms.BindingSource, ByVal FColumn As Integer, ByVal RColumn As Integer, ByVal FoundChk As Boolean, ByVal BeforeUnCheck As Boolean)
        'BpFind :from Find Item ....and BpRp is a common Binding source that any Column mustbe lined with Chklst... 
        Dim d As DataSet = BpFind.DataSource
        Dim t As String = BpFind.DataMember.ToString
        Dim t2 As String = BpRp.DataMember.ToString
        Dim tn As String = d.Tables(t2).Columns(RColumn).ColumnName.ToString

        Dim Aq As Integer
        'Try

        If BeforeUnCheck = True Then AukF2.AukChkListUnCheck_Item_all(ChkLst)
        For Iw = 0 To d.Tables(t).Rows.Count - 1
            str1 = d.Tables(t).Rows(Iw).Item(FColumn).ToString
            If AukF2.BindFind(BpRp, tn, str1) = True Then
                ChkLst.SetItemChecked(ComRow, FoundChk)

            End If


        Next
        'Catch ex As Exception
        '    Epx()

        'End Try

    End Function
    Public Function BindFilterByCategory(ByVal Bp As BindingSource, ByVal TabName As String, ByVal FindText As String, ByVal Quality As String, ByVal Sign As String, ByVal withFilter As Boolean)
        Dim d As DataSet = Bp.DataSource
        Dim Tb As String = Bp.DataMember
        If d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Decimal" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Double" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Single" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.DateTime" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Double" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Int32" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Single" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Int64" Or d.Tables(Tb).Columns(TabName).DataType.ToString = "System.Int16" Then
            MsgBox("num")
            If d.Tables(Tb).Columns(TabName).DataType.ToString = "System.DateTime" Then
                AukF2.BindFilterNumber(Bp, TabName, "#" & FindText & "#", Sign, withFilter)
            Else
                AukF2.BindFilterNumber(Bp, TabName, FindText, Sign, withFilter)

            End If
        Else

            If Sign = "<>" Then
                AukF2.BindFilterNot(Bp, TabName, FindText)
            Else

                AukF2.BindFilter(Bp, TabName, FindText, Quality, withFilter)
            End If
        End If
        'MsgBox(Bp.Filter.ToString)
    End Function
    Public Function Prnt(ByVal Pr As Object, ByVal Dset As DataSet)
        Dim CrpT As New Object
        CrpT = Pr
        CrpT.Database.Tables(0).SetDataSource(Dset)
        ReportViewer.CrystalReportViewer1.ReportSource = CrpT
        ReportViewer.Show()
        ReportViewer.Activate()


    End Function
    Public Function BindFilterByAdvanceCategory(ByVal Bp As BindingSource, ByVal TabName As String, ByVal FindText As String, ByVal Exact As RadioButton, ByVal FExact As RadioButton, ByVal AnyWhere As RadioButton, ByVal Sign As String, ByVal withFilter As Boolean)
        Dim T As DataTable = AukF2.GetTableFromBindingSouce(Bp)

        Dim Quality As String

        If Exact.Checked = True Then
            Quality = ""
        ElseIf FExact.Checked = True Then
            Quality = "aukfunctions"
        ElseIf AnyWhere.Checked = True Then
            Quality = "LK"
        End If

        If T.Columns(TabName).DataType.ToString = "System.Decimal" Or T.Columns(TabName).DataType.ToString = "System.Double" Or T.Columns(TabName).DataType.ToString = "System.Single" Or T.Columns(TabName).DataType.ToString = "System.DateTime" Or T.Columns(TabName).DataType.ToString = "System.Double" Or T.Columns(TabName).DataType.ToString = "System.Int32" Or T.Columns(TabName).DataType.ToString = "System.Single" Or T.Columns(TabName).DataType.ToString = "System.Int64" Or T.Columns(TabName).DataType.ToString = "System.Int16" Then
            'MsgBox("num")
            'MsgBox("Num", T.Columns(TabName).DataType.ToString)
            If T.Columns(TabName).DataType.ToString = "System.DateTime" Then
                AukF2.BindFilterNumber(Bp, TabName, "#" & FindText & "#", Sign, withFilter)
            Else
                AukF2.BindFilterNumber(Bp, TabName, FindText, Sign, withFilter)

            End If
        Else
            'MsgBox("str", T.Columns(TabName).DataType.ToString)
            If Sign = "<>" Then
                AukF2.BindFilterNot(Bp, TabName, FindText)
            Else
                'MsgBox("str")
                AukF2.BindFilter(Bp, TabName, FindText, Quality, withFilter)
            End If
        End If
        'MsgBox(Bp.Filter.ToString)
    End Function
    Public Function BindFilterByAdvanceCategory(ByVal Bp As BindingSource, ByVal TabName As String, ByVal FindText As String, ByVal Exact As Boolean, ByVal FExact As Boolean, ByVal AnyWhere As Boolean, ByVal Sign As String, ByVal withFilter As Boolean)
        Dim T As DataTable
        T = AukF2.GetTableFromBindingSouce(Bp)



        Dim Quality As String

        If Exact = True Then
            Quality = ""
        ElseIf FExact = True Then
            Quality = "aukfunctions"
        ElseIf AnyWhere = True Then
            Quality = "LK"
        End If

        If T.Columns(TabName).DataType.ToString = "System.Decimal" Or T.Columns(TabName).DataType.ToString = "System.Double" Or T.Columns(TabName).DataType.ToString = "System.Single" Or T.Columns(TabName).DataType.ToString = "System.DateTime" Or T.Columns(TabName).DataType.ToString = "System.Double" Or T.Columns(TabName).DataType.ToString = "System.Int32" Or T.Columns(TabName).DataType.ToString = "System.Single" Or T.Columns(TabName).DataType.ToString = "System.Int64" Or T.Columns(TabName).DataType.ToString = "System.Int16" Then
            'MsgBox("num")
            'MsgBox("Num", T.Columns(TabName).DataType.ToString)
            If T.Columns(TabName).DataType.ToString = "System.DateTime" Then
                AukF2.BindFilterNumber(Bp, TabName, "#" & FindText & "#", Sign, withFilter)
            Else
                AukF2.BindFilterNumber(Bp, TabName, FindText, Sign, withFilter)

            End If
        Else
            'MsgBox("str", T.Columns(TabName).DataType.ToString)
            If Sign = "<>" Then
                AukF2.BindFilterNot(Bp, TabName, FindText)
            Else
                'MsgBox("str")
                AukF2.BindFilter(Bp, TabName, FindText, Quality, withFilter)
            End If
        End If
        'MsgBox(Bp.Filter.ToString)
    End Function
End Module
