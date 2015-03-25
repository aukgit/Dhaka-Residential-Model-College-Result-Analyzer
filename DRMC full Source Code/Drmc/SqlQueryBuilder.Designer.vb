<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SqlQueryBuilder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(SqlQueryBuilder))
        Me.AxShockwaveFlash1 = New AxShockwaveFlashObjects.AxShockwaveFlash
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.NextTableNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.PreviousTableNameToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.InsertCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.AddNewThisColumnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem
        Me.TableCombo = New System.Windows.Forms.ComboBox
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'AxShockwaveFlash1
        '
        Me.AxShockwaveFlash1.ContextMenuStrip = Me.ContextMenuStrip1
        Me.AxShockwaveFlash1.Enabled = True
        Me.AxShockwaveFlash1.Location = New System.Drawing.Point(-2, 1)
        Me.AxShockwaveFlash1.Name = "AxShockwaveFlash1"
        Me.AxShockwaveFlash1.OcxState = CType(resources.GetObject("AxShockwaveFlash1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxShockwaveFlash1.Size = New System.Drawing.Size(592, 273)
        Me.AxShockwaveFlash1.TabIndex = 0
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NextTableNameToolStripMenuItem, Me.PreviousTableNameToolStripMenuItem, Me.InsertCommandToolStripMenuItem, Me.AddNewThisColumnToolStripMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(232, 92)
        '
        'NextTableNameToolStripMenuItem
        '
        Me.NextTableNameToolStripMenuItem.Name = "NextTableNameToolStripMenuItem"
        Me.NextTableNameToolStripMenuItem.ShortcutKeyDisplayString = "DownArrow"
        Me.NextTableNameToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.NextTableNameToolStripMenuItem.Text = "NextTableName"
        '
        'PreviousTableNameToolStripMenuItem
        '
        Me.PreviousTableNameToolStripMenuItem.Name = "PreviousTableNameToolStripMenuItem"
        Me.PreviousTableNameToolStripMenuItem.ShortcutKeyDisplayString = "UpArrow"
        Me.PreviousTableNameToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.PreviousTableNameToolStripMenuItem.Text = "Previous TableName"
        '
        'InsertCommandToolStripMenuItem
        '
        Me.InsertCommandToolStripMenuItem.Name = "InsertCommandToolStripMenuItem"
        Me.InsertCommandToolStripMenuItem.ShortcutKeyDisplayString = ""
        Me.InsertCommandToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.I), System.Windows.Forms.Keys)
        Me.InsertCommandToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.InsertCommandToolStripMenuItem.Text = "Insert Command"
        '
        'AddNewThisColumnToolStripMenuItem
        '
        Me.AddNewThisColumnToolStripMenuItem.Name = "AddNewThisColumnToolStripMenuItem"
        Me.AddNewThisColumnToolStripMenuItem.ShortcutKeyDisplayString = "Enter"
        Me.AddNewThisColumnToolStripMenuItem.Size = New System.Drawing.Size(231, 22)
        Me.AddNewThisColumnToolStripMenuItem.Text = "AddNewThis Column"
        '
        'TableCombo
        '
        Me.TableCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.TableCombo.FormattingEnabled = True
        Me.TableCombo.Location = New System.Drawing.Point(436, 32)
        Me.TableCombo.MaxLength = 1000
        Me.TableCombo.Name = "TableCombo"
        Me.TableCombo.Size = New System.Drawing.Size(129, 21)
        Me.TableCombo.TabIndex = 1
        '
        'SqlQueryBuilder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(592, 273)
        Me.Controls.Add(Me.TableCombo)
        Me.Controls.Add(Me.AxShockwaveFlash1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "SqlQueryBuilder"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "SqlQueryBuilder"
        CType(Me.AxShockwaveFlash1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AxShockwaveFlash1 As AxShockwaveFlashObjects.AxShockwaveFlash
    Friend WithEvents TableCombo As System.Windows.Forms.ComboBox
    Friend WithEvents ContextMenuStrip1 As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents NextTableNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PreviousTableNameToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InsertCommandToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AddNewThisColumnToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
